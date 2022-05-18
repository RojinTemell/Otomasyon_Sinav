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
using System.Drawing.Imaging;
using System.IO;


namespace SinavOtomasyon
{
    public partial class Admin_Form : Form
    {
        public Admin_Form()
        {
            InitializeComponent();

            
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-N6SCB07;Initial Catalog=SinavSistemi;Integrated Security=True");




        private void btnKayitGoruntule_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string kayit = "select  * from tblSoru";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();

            da.Fill(dt);

            dgvAdmin.DataSource = dt;
            dgvAdmin.AllowUserToAddRows = false;
            DataGridViewCheckBoxColumn checkBoxColumn= new DataGridViewCheckBoxColumn();
            checkBoxColumn.Width = 40;
            checkBoxColumn.Name = "Seç";
            checkBoxColumn.HeaderText = "";
            dgvAdmin.Columns.Insert(0,checkBoxColumn);
            baglanti.Close();


        }

        private void dgvmouseclick(object sender, MouseEventArgs e)
        {


            byte[] imgdata=(byte[])dgvAdmin.CurrentRow.Cells[2].Value;
            MemoryStream ms=new MemoryStream(imgdata);
            pbAdmin.Image = Image.FromStream(ms);

            foreach(DataGridViewRow row in dgvAdmin.Rows)
            {
                for(int i = 0; i < row.Cells.Count; i++)
                {
                    if (row.Selected == true)
                    {

                   
                        txtAdminForm.Text = "Soru ID: "+row.Cells[1].Value.ToString() + Environment.NewLine+
                                            "Test ID: "+row.Cells[4].Value.ToString() + Environment.NewLine+
                                            "Ünite ID: "+row.Cells[5].Value.ToString() + Environment.NewLine+Environment.NewLine+
                                            "A) "+row.Cells[6].Value.ToString() + Environment.NewLine+
                                            "B) "+row.Cells[7].Value.ToString() + Environment.NewLine+
                                            "C) "+row.Cells[8].Value.ToString() + Environment.NewLine+
                                            "D) "+row.Cells[9].Value.ToString() + Environment.NewLine+
                                            "Doğru Cevap: " + row.Cells[2].Value.ToString() + Environment.NewLine;
                    }
                }
                
            }

        }


        

        private void btnAdminFormOnayla_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in dgvAdmin.Rows)
            {
                bool select1 = Convert.ToBoolean(row.Cells["Seç"].Value);
                if (select1)
                {
                    SqlCommand komut = new SqlCommand("insert into tblAdminOnayli(soruResim,secenek1,secenek2,secenek3,secenek4,dogruSecenek,UniteID,TestID)values(@soruResim,@secenek1,@secenek2,@secenek3,@secenek4,@dogruSecenek,@UniteID,@TestID)", baglanti);
                    komut.Parameters.AddWithValue("soruResim", row.Cells["soruResim"].Value);
                    komut.Parameters.AddWithValue("secenek1", row.Cells["secenek1"].Value);
                    komut.Parameters.AddWithValue("secenek2", row.Cells["secenek2"].Value);
                    komut.Parameters.AddWithValue("secenek3", row.Cells["secenek3"].Value);
                    komut.Parameters.AddWithValue("secenek4", row.Cells["secenek4"].Value);
                    komut.Parameters.AddWithValue("dogruSecenek", row.Cells["dogruSecenek"].Value);
                    komut.Parameters.AddWithValue("UniteID", row.Cells["UniteID"].Value);
                    komut.Parameters.AddWithValue("TestID", row.Cells["TestID"].Value);
                    baglanti.Open();
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                }
            }
            MessageBox.Show("Sorular onaylandı");
        }

        private void btnAdminCikis_Click(object sender, EventArgs e)
        {
            GirisForm girisForm = new GirisForm();
            girisForm.Show();
            this.Hide();
        }
    }
}
