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
using System.Data.SqlClient;

namespace Eczane
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {




        }

      
            public void button1_Click(object sender, EventArgs e)
            {
            if (GADTb.Text == KAdı && GSTb.Text == GSifre)
            {
                Anasayfa frm3 = new Anasayfa();
                frm3.ShowDialog();
            }

            else
                MessageBox.Show("Hatalı Kullanıcı Adı veya Parola. Lütfen Tekrar Deneyiniz.");
            }

        private void kayıt_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.ShowDialog();
        }
        public static string KAdı;
        public static string GSifre;




        private void Form1_Activated(object sender, EventArgs e)
        {
            GADTb.Text = KAdı;
            GSTb.Text = GSifre;
        }
    }
}
