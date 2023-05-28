﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Eczane
{
    public partial class Randevu : Form
    {
        public Randevu()
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
            RadCb.ValueMember = "HastaAd";
            RadCb.DataSource = dt;
            baglanti.Close();
            ;
        }
        private void fillTedavi()
        {
            SqlConnection baglanti = MyCon.GetCon();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select TAd from TedaviTbl", baglanti);
            SqlDataReader rdr;
            rdr = komut.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("TAd", typeof(string));
            dt.Load(rdr);
            RtedaviCb.ValueMember = "TAd";
            RtedaviCb.DataSource = dt;
            baglanti.Close();
            ;
        }

        private void Randevu_Load(object sender, EventArgs e)
        {
            fillHasta();
            fillTedavi();
            uyeler();
            Reset();
        }

        void uyeler()
        {
            Hastalar Hs = new Hastalar();
            string query = "select * from andevuTbl";
            DataSet ds = Hs.ShowHasta(query);
            RandevuDGV.DataSource = ds.Tables[0];
        }
        void filter()
        {
            Hastalar Hs = new Hastalar();
            string query = "select * from andevuTbl where Hasta like '%" + AraaTb.Text + "%'";
            DataSet ds = Hs.ShowHasta(query);
            RandevuDGV.DataSource = ds.Tables[0];
        }


        void Reset()
        {
            RadCb.SelectedIndex = -1;
            RtedaviCb.SelectedIndex = -1;
            Rtarih.Text = "";
            SaatCb.Text = "";
        }


        private void button3_Click(object sender, EventArgs e)
        {
            string query = "insert into andevuTbl values('"+ RadCb.SelectedValue.ToString() +"','"+ RtedaviCb.SelectedValue.ToString() +"', '"+ Rtarih.Text +"','"+ SaatCb.Text +"')";
            Hastalar Hs = new Hastalar();
            try
            {
                Hs.HastaEkle(query);
                MessageBox.Show("Randevu Başarıyla Eklendi");
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
                _ = MessageBox.Show("Güncellenecek Randevuyu Seçiniz");

            }
            else
            {
                try
                {
                    string query = " Update andevuTbl set Hasta='" + RadCb.SelectedValue.ToString() + "', Tedavi='" + RtedaviCb.SelectedValue.ToString() + "',RTarih='" + Rtarih.Text + "', RSaat='" + SaatCb.Text + "'  where RandevuId=" + key + ";";

                    Hs.HastaGüncelle(query);
                    MessageBox.Show("Randevu Başarıyla Güncellendi");
                    uyeler();
                    Reset();




                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void RandevuDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RadCb.SelectedValue = RandevuDGV.SelectedRows[0].Cells[1].Value.ToString();
            RtedaviCb.SelectedValue = RandevuDGV.SelectedRows[0].Cells[2].Value.ToString();
            Rtarih.Text = RandevuDGV.SelectedRows[0].Cells[3].Value.ToString();
            SaatCb.Text = RandevuDGV.SelectedRows[0].Cells[4].Value.ToString();


            if (RadCb.SelectedIndex == -1)
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(RandevuDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hastalar Hs = new Hastalar();
            if (key == 0)
            {
                MessageBox.Show("Silinecek Randevuyu Seçiniz");

            }
            else
            {
                try
                {
                    string query = " Delete from andevuTbl where RandevuId=" + key + "";
                    Hs.HastaSil(query);
                    MessageBox.Show("Randevu Başarıyla Silindi");
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

        private void AraaTb_TextChanged(object sender, EventArgs e)
        {
            filter();
        }

        private void RadCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
