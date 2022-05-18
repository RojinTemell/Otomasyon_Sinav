using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SinavOtomasyon
{
    public partial class GirisForm : Form
    {
        public GirisForm()
        {
            InitializeComponent();
            panel2.Visible= false;

        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-N6SCB07;Initial Catalog=SinavSistemi;Integrated Security=True");
        


        private void btngiris_Click(object sender, EventArgs e)
        {


            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();


                if (rbogrenci.Checked == true)
                {


                    string giris = "select * from tblOgr where KullaniciAd =@KullaniciAd and Sifre=@Sifre";
                    SqlParameter prm1 = new SqlParameter("KullaniciAd", txtkul_ad_giris.Text.Trim());
                    SqlParameter prm2 = new SqlParameter("Sifre", txtsifre_giris.Text.Trim());
                    SqlCommand komut = new SqlCommand(giris, baglanti);
                    komut.Parameters.Add(prm1);
                    komut.Parameters.Add(prm2);
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(komut);
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        Ogrenci_Form ogr_form = new Ogrenci_Form();
                        ogr_form.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Hatalı giriş");

                    }
                }
                else if (rbadmin.Checked == true)
                {

                    string giris = "select * from tblAdmin where KullaniciAd =@KullaniciAd and Sifre=@Sifre";
                    SqlParameter prm1 = new SqlParameter("KullaniciAd", txtkul_ad_giris.Text.Trim());
                    SqlParameter prm2 = new SqlParameter("Sifre", txtsifre_giris.Text.Trim());
                    SqlCommand komut = new SqlCommand(giris, baglanti);
                    komut.Parameters.Add(prm1);
                    komut.Parameters.Add(prm2);
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(komut);
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        Admin_Form admin_Form = new Admin_Form();
                        admin_Form.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Hatalı giriş");

                    }
                }
                else if (rbsinavsorumlusu.Checked == true)
                {

                    string giris = "select * from tblSorumlu where KullaniciAd =@KullaniciAd and Sifre=@Sifre";
                    SqlParameter prm1 = new SqlParameter("KullaniciAd", txtkul_ad_giris.Text.Trim());
                    SqlParameter prm2 = new SqlParameter("Sifre", txtsifre_giris.Text.Trim());
                    SqlCommand komut = new SqlCommand(giris, baglanti);
                    komut.Parameters.Add(prm1);
                    komut.Parameters.Add(prm2);
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(komut);
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        SinavSorumlu_Form sorumlu_Form = new SinavSorumlu_Form();
                        sorumlu_Form.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Hatalı giriş");

                    }
                }
                else
                {
                    MessageBox.Show("Kullanıcı Tipi Seçmediniz");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Hatalı Giriş" + ex.Message);
            }

        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (txtad.Text == "" || txtsoyad.Text == "" || txtkul_adi.Text == "" || txtsifre.Text == "" || txtmail.Text == "")
            {

                MessageBox.Show("Alanlar Boş Bırakılamaz!!");
            }
            else
            {
                try
                {
                    if (baglanti.State == ConnectionState.Closed)
                        baglanti.Open();

                    if (rbogrenci.Checked == true)
                    {
                        string kayit = "insert into tblOgr(Ad,Soyad,KullaniciAd,Sifre,Mail) values(@Ad,@Soyad,@KullaniciAd,@Sifre,@Mail)";
                        SqlCommand komut = new SqlCommand(kayit, baglanti);
                        komut.Parameters.AddWithValue("@Ad", txtad.Text);
                        komut.Parameters.AddWithValue("@Soyad", txtsoyad.Text);
                        komut.Parameters.AddWithValue("@KullaniciAd", txtkul_adi.Text);
                        komut.Parameters.AddWithValue("@Sifre", txtsifre.Text);
                        komut.Parameters.AddWithValue("@Mail", txtmail.Text);
                        komut.ExecuteNonQuery();
                        baglanti.Close();
                        MessageBox.Show("Öğrenci Olarak Kayıt Yapıldı");
                        panel2.Visible = false;
                        panel1.Visible = true;
                        foreach (Control item in panel2.Controls) if (item is TextBox) item.Text = "";
                    }
                    else if (rbadmin.Checked == true)
                    {
                        string kayit = "insert into tblAdmin(Ad,Soyad,KullaniciAd,Sifre,Mail) values(@Ad,@Soyad,@KullaniciAd,@Sifre,@Mail)";
                        SqlCommand komut = new SqlCommand(kayit, baglanti);
                        komut.Parameters.AddWithValue("@Ad", txtad.Text);
                        komut.Parameters.AddWithValue("@Soyad", txtsoyad.Text);
                        komut.Parameters.AddWithValue("@KullaniciAd", txtkul_adi.Text);
                        komut.Parameters.AddWithValue("@Sifre", txtsifre.Text);
                        komut.Parameters.AddWithValue("@Mail", txtmail.Text);
                        komut.ExecuteNonQuery();
                        baglanti.Close();
                        MessageBox.Show("Admin Olarak Kayıt Yapıldı");
                        panel2.Visible = false;
                        panel1.Visible = true;
                        foreach (Control item in panel2.Controls) if (item is TextBox) item.Text = "";
                    }
                    else if (rbsinavsorumlusu.Checked == true)
                    {
                        string kayit = "insert into tblSorumlu(Ad,Soyad,KullaniciAd,Sifre,Mail) values(@Ad,@Soyad,@KullaniciAd,@Sifre,@Mail)";
                        SqlCommand komut = new SqlCommand(kayit, baglanti);
                        komut.Parameters.AddWithValue("@Ad", txtad.Text);
                        komut.Parameters.AddWithValue("@Soyad", txtsoyad.Text);
                        komut.Parameters.AddWithValue("@KullaniciAd", txtkul_adi.Text);
                        komut.Parameters.AddWithValue("@Sifre", txtsifre.Text);
                        komut.Parameters.AddWithValue("@Mail", txtmail.Text);
                        komut.ExecuteNonQuery();
                        baglanti.Close();
                        MessageBox.Show("Sınav Sorumlusu Olarak Kayıt Yapıldı");
                        panel2.Visible = false;
                        panel1.Visible = true;

                        foreach (Control item in panel2.Controls) if (item is TextBox) item.Text = "";
                        
                        

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kayıt Yapılamadı" + ex);
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SifremiUnuttum_Formu sifremiUnuttum_Formu = new SifremiUnuttum_Formu();
            sifremiUnuttum_Formu.Show();
            this.Hide();

        }

        private void btnKatiyOlGiris_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
        }
    }
}
