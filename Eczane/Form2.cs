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
using System.Data.Sql;


namespace Eczane
{
    public partial class Form2 : Form
    {
        public Form2()

        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\ismet\OneDrive\Belgeler\dentaldb.mdf;Integrated Security = True; Connect Timeout = 30");






        private void kayıtt_Click(object sender, EventArgs e)
        {
            string query = "insert into KGirisTbl values('" + KAd.Text + "','" + Sifre.Text + "') ";
            Kayıt Hs = new Kayıt();
            try
            {
                Hs.KayıtEkle(query);
                MessageBox.Show("Kayıt Başarıyla Eklendi");




            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 log = new Form1();
            log.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void KayıtAdTb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
