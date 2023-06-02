using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eczane
{
    public partial class Tedavi : Form
    {
        public Tedavi()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string query = "insert into TedaviTbl values('" + TedaviAdıTb.Text + "','" + TutarTb.Text + "', '" + AcıklamaTb.Text + "') ";
            Hastalar Hs = new Hastalar();
            try
            {
                Hs.HastaEkle(query);
                MessageBox.Show("Tedavi Başarıyla Eklendi");
                uyeler();
                Reset();



            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }




        int key = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            Hastalar Hs = new Hastalar();
            if (key == 0)
            {
                _ = MessageBox.Show("Güncellenecek Tedaviyi Seçiniz");

            }
            else
            {
                try
                {
                    string query = " Update TedaviTbl set TAd='" + TedaviAdıTb.Text + "', TUcret='" + TutarTb.Text + "',TAçıklama='" + AcıklamaTb.Text + "' where TedaviId=" + key + ";";

                    Hs.HastaGüncelle(query);
                    MessageBox.Show("Tedavi Başarıyla Güncellendi");
                    uyeler();
                    Reset();




                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hastalar Hs = new Hastalar();
            if (key == 0)
            {
                MessageBox.Show("Silinecek Tedavi Seçiniz");

            }
            else
            {
                try
                {
                    string query = " Delete from TedaviTbl where TedaviId=" + key + "";
                    Hs.HastaSil(query);
                    MessageBox.Show("Tedavi Başarıyla Silindi");
                    uyeler();
                    Reset();




                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        void uyeler()
        {
            Hastalar Hs = new Hastalar();
            string query = "select * from TedaviTbl";
            DataSet ds = Hs.ShowHasta(query);
            TedaviDGV.DataSource = ds.Tables[0];
        }
        void filter()
        {
            Hastalar Hs = new Hastalar();
            string query = "select * from TedaviTbl where TAd like '%" + AraaaTb.Text + "%'";
            DataSet ds = Hs.ShowHasta(query);
            TedaviDGV.DataSource = ds.Tables[0];
        }

        void Reset()
        {
            TedaviAdıTb.Text = "";
            TutarTb.Text = "";
            AcıklamaTb.Text = "";
        }

        private void Tedavi_Load(object sender, EventArgs e)
        {

            uyeler();
            Reset();
        }

        private void TedaviDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TedaviAdıTb.Text = TedaviDGV.SelectedRows[0].Cells[1].Value.ToString();
            TutarTb.Text = TedaviDGV.SelectedRows[0].Cells[2].Value.ToString();
            AcıklamaTb.Text = TedaviDGV.SelectedRows[0].Cells[3].Value.ToString();
           
            if (TedaviAdıTb.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(TedaviDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void button7_Click(object sender, EventArgs e)
        {

            Reçete rct = new Reçete();
            rct.Show();
            this.Hide();

        }

        private void AraaaTb_TextChanged(object sender, EventArgs e)
        {
            filter();
        }
    }
}
