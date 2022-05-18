using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace SinavOtomasyon
{
    public partial class SinavSorumlu_Form : Form
    {
        public SinavSorumlu_Form()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-N6SCB07;Initial Catalog=SinavSistemi;Integrated Security=True");

      

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string imagefile = Path.GetFileName(pbSoru.ImageLocation);
            string imagepath = Path.Combine(Application.StartupPath + "\\img\\" + imagefile);
            File.Copy(pbSoru.ImageLocation, imagepath, true);
            MessageBox.Show("resim kaydedildi");
        }

        private void btnSoruResimEkle_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Resim Seç";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbSoru.ImageLocation = openFileDialog1.FileName;
                
            }

        }

        private void btnSoruEkle_Click(object sender, EventArgs e)
        {
            
            FileStream fileStream = new FileStream(pbSoru.ImageLocation, FileMode.Open, FileAccess.Read);
            BinaryReader binaryReader = new BinaryReader(fileStream);
            byte[] resim = binaryReader.ReadBytes((int)fileStream.Length);
            binaryReader.Close();
            fileStream.Close();

            baglanti.Open();

            SqlCommand komut = new SqlCommand("insert into tblSoru(soruResim,secenek1,secenek2,secenek3,secenek4,dogruSecenek,UniteID,TestID) values(@soruResim,@secenek1,@secenek2,@secenek3,@secenek4,@dogruSecenek,@UniteID,@TestID)",baglanti);

            komut.Parameters.Add("@soruResim",SqlDbType.Image,resim.Length).Value=resim;
            komut.Parameters.AddWithValue("@secenek1", txtASecenek.Text);
            komut.Parameters.AddWithValue("@secenek2", txtBSecenek.Text);
            komut.Parameters.AddWithValue("@secenek3", txtCSecenek.Text);
            komut.Parameters.AddWithValue("@secenek4", txtDSecenek.Text);
            string dsecenek = "";
            if (rbADogruScnk.Checked)
                dsecenek = rbADogruScnk.Text;
            else if (rbBDogruScnk.Checked)
                dsecenek = rbBDogruScnk.Text;
            else if (rbCDogruScnk.Checked)
                dsecenek = rbCDogruScnk.Text;
            else if (rbDDogruScnk.Checked)
                dsecenek = rbDDogruScnk.Text;
            komut.Parameters.AddWithValue("@dogruSecenek", dsecenek);
            komut.Parameters.AddWithValue("@UniteID", int.Parse(cmbxUniteSec.Text));
            komut.Parameters.AddWithValue("@TestID", int.Parse(cmbxTestSec.Text));
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Soru Eklendi");

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            foreach(Control item in this.Controls)
            {
                if(item is RadioButton)
                {
                    RadioButton rb = item as RadioButton;
                    rb.Checked = false;
                }
                if(item is TextBox)
                {
                    TextBox txt = item as TextBox;
                    txt.Clear();
                }
            }
            cmbxTestSec.Text = "";
            cmbxUniteSec.Text = "";
            pbSoru.Image = null;
        }

        private void btnSorumluCikis_Click(object sender, EventArgs e)
        {
            GirisForm girisForm = new GirisForm();
            girisForm.Show();
            this.Hide();

        }
    }
}
