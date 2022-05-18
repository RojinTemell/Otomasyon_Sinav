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
using System.IO;

namespace SinavOtomasyon
{
    public partial class Ogrenci_Form : Form
    {
        public Ogrenci_Form()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-N6SCB07;Initial Catalog=SinavSistemi;Integrated Security=True");

        int saniye = 60;
        int dakika = 10;
        int sorusayisi = 0;
        bool[] sonuc = new bool[10];
        string secilen ;

        private void btnTesteBasla_Click(object sender, EventArgs e)
        {
            timer1.Start();
            
            lblTarih.Text = DateTime.Now.ToLongDateString();
            
            
            baglanti.Open();
            string kayit = "select  top 1 * from tblAdminOnayli  order by newid() ";
          
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            
            
            if (dr.Read())
            {
               
                    Byte[] data = new Byte[0];
                    data = (Byte[])(dr["soruResim"]);
                    MemoryStream mem = new MemoryStream(data);
                    pbOgrenciSoru.Image = Image.FromStream(mem);

                    txtOgrA.Text = dr["secenek1"].ToString();
                    txtOgrB.Text = dr["secenek2"].ToString();
                    txtOgrC.Text = dr["secenek3"].ToString();
                    txtOgrD.Text = dr["secenek4"].ToString();
                
                
            }
            baglanti.Close();
        }

        private void btnSonrakiSoru_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string kayit = "select  top 1 * from tblAdminOnayli   order by newid() ";

            SqlCommand komut = new SqlCommand(kayit, baglanti);
            SqlDataReader dr = komut.ExecuteReader();
 
            lblsoruno.Text = sorusayisi.ToString()+".Soru";

            if (dr.Read())
                {
              
                Byte[] data = new Byte[0];
                    data = (Byte[])(dr["soruResim"]);
                    MemoryStream mem = new MemoryStream(data);
                    pbOgrenciSoru.Image = Image.FromStream(mem);

                    txtOgrA.Text = dr["secenek1"].ToString();
                    txtOgrB.Text = dr["secenek2"].ToString();
                    txtOgrC.Text = dr["secenek3"].ToString();
                    txtOgrD.Text = dr["secenek4"].ToString();
                
                 
                 

                }
            if(sorusayisi==10)
            {
                btnSonrakiSoru.Enabled = false;
                MessageBox.Show("sorular bitti");
               
            }

            

            baglanti.Close();




        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (dakika != 0)
            {
                saniye--;
                lblsn.Text = Convert.ToString(saniye);
                lbldk.Text = Convert.ToString(dakika-1);
                if (saniye == 0)
                {
                    dakika--;
                    lbldk.Text = Convert.ToString(dakika);
                    saniye = 59;
                }
            }
            if (dakika == 0)
            {
                timer1.Stop();
                MessageBox.Show("süreniz bitti");
            }
            



        }

        private void btnTestiBitir_Click(object sender, EventArgs e)
        {
            

            timer1.Stop();

            
        }

        private void Ogrenci_Form_Load(object sender, EventArgs e)
        {
            lblTarih.Text = DateTime.Now.ToLongDateString();
            
        }

        
    }
}
