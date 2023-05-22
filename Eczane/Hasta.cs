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
    }
}
