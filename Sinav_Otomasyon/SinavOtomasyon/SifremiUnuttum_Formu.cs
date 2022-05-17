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

        private void KodGonder()
        {
            if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();
            string from, pass, messageBody, randomcode, to;
            Random rand = new Random();
            randomcode = (rand.Next(999999)).ToString();
            MailMessage message = new MailMessage();
            to = (txtMailDogrulama.Text).ToString();
            from = "211305071@yetgen.mef.edu.tr";
            pass = "Yetgen@Mef2021!";
            messageBody = $"Şifre kodu:{randomcode}";
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = messageBody;
            message.Subject = "Şifre kodu";
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);
            smtp.Send(message);
            MessageBox.Show("kod gönderildi");

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
                MessageBox.Show(ex+"hatalı mail");
            }



         
            
        }
    }
}
