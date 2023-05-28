using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eczane
{
    public partial class Reçete : Form
    {
        public Reçete()
        {
            InitializeComponent();
        }
        ConnectionString MyCon = new ConnectionString();



        private void fillHasta()
        {
            SqlConnection baglanti = MyCon.GetCon();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select HastaAd from HastaTbl", baglanti);
            SqlDataReader rdr;
            rdr = komut.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("HastaAd", typeof(string));
            dt.Load(rdr);
            RACb.ValueMember = "HastaAd";
            RACb.DataSource = dt;
            baglanti.Close();
            ;
        }
        private void fillTedavi()
        {
            SqlConnection baglanti = MyCon.GetCon();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from andevuTbl where Hasta ='"+ RACb.SelectedValue.ToString()+ "' ", baglanti);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(komut);
            sda.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {

                RTTb.Text = dr["Tedavi"].ToString();
            }
            baglanti.Close();
            
        }
        private void fillPriice()
        {
            SqlConnection baglanti = MyCon.GetCon();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from TedaviTbl where TAd ='" +RTTb.Text + "' ", baglanti);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(komut);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {

                TutarTb.Text = dr["TUcret"].ToString();
            }
            baglanti.Close();

        }


        private void Reçete_Load(object sender, EventArgs e)
        {
            fillHasta();
            uyeler();
            Reset();

        }

        void filter()
        {
            Hastalar Hs = new Hastalar();
            string query = "select * from RecTbl where HasAd like '%" + AraaaaTb.Text + "%'";
            DataSet ds = Hs.ShowHasta(query);
            RecDGV.DataSource = ds.Tables[0];
        }

        private void RACb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fillTedavi();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Anasayfa ana = new Anasayfa();
            ana.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Hasta hst = new Hasta();
            hst.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Randevu rnd = new Randevu();
            rnd.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Tedavi tdv = new Tedavi();
            tdv.Show();
            this.Hide();
        }

        private void TutarTb_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void RTTb_TextChanged(object sender, EventArgs e)
        {
            fillPriice();
        }

        void uyeler()
        {
            Hastalar Hs = new Hastalar();
            string query = "select * from RecTbl";
            DataSet ds = Hs.ShowHasta(query);
            RecDGV.DataSource = ds.Tables[0];
        }
        void Reset()
        {
            RACb.SelectedItem = "";
            RTTb.Text = "";
            TutarTb.Text = "";
            İlacTb.Text = "";
            MiktarTb.Text = "";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string query = "insert into RecTbl values('" + RACb.SelectedValue.ToString() + "','" + RTTb.Text + "', '" + TutarTb.Text + "','" + İlacTb.Text + "','" + MiktarTb.Text + "') ";
            Hastalar Hs = new Hastalar();
            try
            {
                Hs.HastaEkle(query);
                MessageBox.Show("Reçete Başarıyla Eklendi");
                uyeler();
                Reset();



            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        int key = 0;
        private void RecDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                RACb.Text =RecDGV.SelectedRows[0].Cells[1].Value.ToString();
                RTTb.Text = RecDGV.SelectedRows[0].Cells[2].Value.ToString();
                TutarTb.Text = RecDGV.SelectedRows[0].Cells[3].Value.ToString();
                İlacTb.Text = RecDGV.SelectedRows[0].Cells[4].Value.ToString();
                MiktarTb.Text = RecDGV.SelectedRows[0].Cells[5].Value.ToString();
                
                if (RTTb.Text == "")
                {
                    key = 0;
                }
                else
                {
                    key = Convert.ToInt32(RecDGV.SelectedRows[0].Cells[0].Value.ToString());
                }


            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Hastalar Hs = new Hastalar();
            if (key == 0)
            {
                MessageBox.Show("Silinecek Reçeteyi Seçiniz");

            }
            else
            {
                try
                {
                    string query = " Delete from RecTbl where RecId=" + key + "";
                    Hs.HastaSil(query);
                    MessageBox.Show("Reçete Başarıyla Silindi");
                    uyeler();
                    Reset();




                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void AraaaaTb_TextChanged(object sender, EventArgs e)
        {
            filter();
        }
        Bitmap bitmap;
        private void button2_Click(object sender, EventArgs e)
        {
            int height = RecDGV.Height;
            RecDGV.Height = RecDGV.RowCount * RecDGV.RowTemplate.Height * 2;
            bitmap = new Bitmap(RecDGV.Width, RecDGV.Height);
            RecDGV.DrawToBitmap(bitmap, new Rectangle(0, 10, RecDGV.Width, RecDGV.Height));
            RecDGV.Height = height;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }
    }
}
