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
            baglanti.Close();


        }

        private void dgvmouseclick(object sender, MouseEventArgs e)
        {


            byte[] imgdata=(byte[])dgvAdmin.CurrentRow.Cells[1].Value;
            MemoryStream ms=new MemoryStream(imgdata);
            pbAdmin.Image = Image.FromStream(ms);

            foreach(DataGridViewRow row in dgvAdmin.Rows)
            {
                for(int i = 0; i < row.Cells.Count; i++)
                {
                    if (row.Selected == true)
                    {

                   
                        txtAdminForm.Text = "Soru ID: "+row.Cells[0].Value.ToString() + Environment.NewLine+
                                            "Test ID: "+row.Cells[3].Value.ToString() + Environment.NewLine+
                                            "Ünite ID: "+row.Cells[4].Value.ToString() + Environment.NewLine+Environment.NewLine+
                                            "A) "+row.Cells[5].Value.ToString() + Environment.NewLine+
                                            "B) "+row.Cells[6].Value.ToString() + Environment.NewLine+
                                            "C) "+row.Cells[7].Value.ToString() + Environment.NewLine+
                                            "D) "+row.Cells[8].Value.ToString() + Environment.NewLine+
                                            "Doğru Cevap: " + row.Cells[2].Value.ToString() + Environment.NewLine;
                    }
                }
                
            }

        }
        

        private void btnAdminFormOnayla_Click(object sender, EventArgs e)
        {
            
        }
    }
}
