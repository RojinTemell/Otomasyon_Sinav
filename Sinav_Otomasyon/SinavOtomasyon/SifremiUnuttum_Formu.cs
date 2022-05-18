using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Data.SqlClient;



namespace SinavOtomasyon
{
    public partial class SifremiUnuttum_Formu : Form
    {
        
        
        public SifremiUnuttum_Formu()
        {

            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-N6SCB07;Initial Catalog=SinavSistemi;Integrated Security=True");

        
        string randomcode;
        public static string to;
        private void KodGonder()
        {

            
            string from, pass, messageBody;
            Random rand = new Random();
            randomcode = (rand.Next(999999)).ToString();
            MailMessage message = new MailMessage();
            to = (txtMailDogrulama.Text).ToString();
            from = "fadim.rojin@gmail.com";
            pass = "Turgutlu45";
            messageBody = $"Sıfırlama kodunuz: {randomcode}";
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = messageBody;
            message.Subject = "Şifre Sıfırlama Kodu";
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);
            try
            {
                smtp.Send(message);
                MessageBox.Show("Kod Gönderildi");
                txtMailDogrulama.Clear();

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                txtMailDogrulama.Clear();
                
            }
        

        }


        private void btnKodGonder_Click(object sender, EventArgs e)
        {
            

        try { 
            

            if (rbAdminSifreYenileme.Checked == true)
            {
                    KodGonder();
                                       
            }
            else if (rbOgrenciSifreYenileme.Checked == true)
            {

                    KodGonder();
                    

                }
            else if (rbSorumluSifreYenileme.Checked == true)
            {
                    KodGonder();
                    
            }
                else
                {
                    MessageBox.Show("Kullanıcı Tipi Seçmediniz");
                }


            
        }
            catch (Exception ex)
            {
                MessageBox.Show(ex+"Hatalı Mail");
                
            }

            grpbGuvenlikKod.Visible = true;
            grpbMailDogrulama.Visible = false;

         
            
        }

        private void btnOnaylaGuvKod_Click(object sender, EventArgs e)
        {
            if (randomcode == (txtGuvenlikKod.Text).ToString())
            {
                to = txtMailDogrulama.Text;
                MessageBox.Show("Kod Onaylandı");
                txtGuvenlikKod.Clear();
                


            }
            else
            {
                MessageBox.Show("Hatalı Kod");
                txtGuvenlikKod.Clear();
            }
            grpbGuvenlikKod.Visible = false;
            grpbYeniSifre.Visible = true;
        }

        private void btnOnaylaYeniSifre_Click(object sender, EventArgs e)
        {
            string Sifre=txtYeniSifre.Text;
            string Mail = txtMailDogrulama.Text;
            baglanti.Open();

            if (rbSorumluSifreYenileme.Checked == true) {
                string str = "update [tblSorumlu] set[Sifre]='" + Sifre + "'where Mail='" + Mail + "'";
                SqlCommand komut = new SqlCommand(str, baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                
                MessageBox.Show("Şifre Başarıyla Güncellendi");
                

            }
            else if (rbAdminSifreYenileme.Checked == true)
            {
                string str = "update [tblAdmin] set[Sifre]='" + Sifre + "'where Mail='" + Mail + "'";
                SqlCommand komut = new SqlCommand(str, baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                
                MessageBox.Show("Şifre Başarıyla Güncellendi");
                

            }
            else if (rbOgrenciSifreYenileme.Checked == true)
            {
                string str = "update [tblOgrenci] set[Sifre]='" + Sifre + "'where Mail='" + Mail + "'";
                SqlCommand komut = new SqlCommand(str, baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                
                MessageBox.Show("Şifre Başarıyla Güncellendi");
                
            }
            else
            {
                MessageBox.Show("Başarısız");
                
            }

            GirisForm giris = new GirisForm();
            giris.Show();
            this.Hide();



        }

        private void SifremiUnuttum_Formu_Load(object sender, EventArgs e)
        {
            grpbGuvenlikKod.Visible = false;
            grpbYeniSifre.Visible = false;
        }
    }
}
