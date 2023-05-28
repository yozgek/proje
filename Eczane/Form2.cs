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
    public partial class Form2 : Form
    {
        public Form2()

        {
            InitializeComponent();
        }
         
       
      
        

        private void kayıtt_Click(object sender, EventArgs e)
        {


         

            string query = "insert into Table values('" + kAd.Text + "','" + sifre.Text + "') ";
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
    }
}
