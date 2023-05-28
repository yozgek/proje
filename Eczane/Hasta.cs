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
    public partial class Hasta : Form
    {
        public Hasta()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string query = "insert into HastaTbl values('" + HAdSoyadTb.Text + "','" + HTelefonTb.Text + "', '" + HDogumTarihi.Text + "','" + HCinsiyetCb.SelectedItem.ToString() + "', '" + AlerjiTb.Text + "','" + AdresTb.Text + "') ";
            Hastalar Hs = new Hastalar();
            try
            {
                Hs.HastaEkle(query);
                MessageBox.Show("Hasta Başarıyla Eklendi");
                uyeler();
                Reset();



            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
        void uyeler()
        {
                Hastalar Hs = new Hastalar();
                string query = "select * from HastaTbl";
                DataSet ds = Hs.ShowHasta(query);
                HastaDGV.DataSource = ds.Tables[0];     
        }
        void filter()
        {
            Hastalar Hs = new Hastalar();
            string query = "select * from HastaTbl where HastaAd like '%" + AraTb.Text + "%'";
            DataSet ds = Hs.ShowHasta(query);
            HastaDGV.DataSource = ds.Tables[0];
        }
        void Reset()
        {
            HAdSoyadTb.Text = "";
            HTelefonTb.Text = "";
            HDogumTarihi.Text = "";
            HCinsiyetCb.SelectedItem = "";
            AlerjiTb.Text = "";
            AdresTb.Text = "";
        }


        private void Hasta_Load(object sender, EventArgs e)
        {
            uyeler();
            Reset();

        } int key = 0;


        private void HastaDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            HAdSoyadTb.Text = HastaDGV.SelectedRows[0].Cells[1].Value.ToString();
            HTelefonTb.Text = HastaDGV.SelectedRows[0].Cells[2].Value.ToString();
            HDogumTarihi.Text = HastaDGV.SelectedRows[0].Cells[3].Value.ToString();
            HCinsiyetCb.SelectedItem = HastaDGV.SelectedRows[0].Cells[4].Value.ToString();
            AlerjiTb.Text = HastaDGV.SelectedRows[0].Cells[5].Value.ToString();
            AdresTb.Text = HastaDGV.SelectedRows[0].Cells[6].Value.ToString();
            if (HAdSoyadTb.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(HastaDGV.SelectedRows[0].Cells[0].Value.ToString());
            }


        }



        private void button1_Click(object sender, EventArgs e)
        {

            Hastalar Hs = new Hastalar();
            if(key==0)
            {
                MessageBox.Show("Silinecek Hastayı Seçiniz");

            }else
            {
                try
                {
                    string query = " Delete from HastaTbl where HId=" + key + "";
                    Hs.HastaSil(query);
                    MessageBox.Show("Hasta Başarıyla Silindi");
                    uyeler();
                    Reset();




                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
            
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hastalar Hs = new Hastalar();
            if (key == 0)
            {
                _ = MessageBox.Show("Güncellenecek Hastayı Seçiniz");

            }
            else
            {
                try
                {
                    string query = " Update HastaTbl set HastaAd='"+HAdSoyadTb.Text+"',HastaTel='"+HTelefonTb.Text+"',HastaDogumT='"+HDogumTarihi.Text+"',HastaCinsiyet='"+HCinsiyetCb.SelectedItem.ToString()+"',HastaAlerji='"+AlerjiTb.Text+"',HastaAdres='"+AdresTb.Text+"'where HId=" + key + ";";
                  
                    Hs.HastaGüncelle(query);
                    MessageBox.Show("Hasta Başarıyla Güncellendi");
                    uyeler();
                    Reset();




                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Anasayfa ana = new Anasayfa();
            ana.Show();
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

        private void button7_Click(object sender, EventArgs e)
        {
            Reçete rct = new Reçete();
            rct.Show();
            this.Hide();
        }

        private void HastaDGV_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AraTb_TextChanged(object sender, EventArgs e)
        {
            filter();
        }
    }
}
