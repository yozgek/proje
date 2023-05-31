using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


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
                SqlConnection baglanti = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\ismet\OneDrive\Belgeler\dentaldb.mdf;Integrated Security = True; Connect Timeout = 30");


        public void button1_Click(object sender, EventArgs e)



        {
        try
            {
                baglanti.Open();
                string sql = "Select * From KGirisTbl where KAd = @KAd AND Sifre = @Sifre ";
                SqlParameter prm1 = new SqlParameter("KAd", GADTb.Text.Trim());
                SqlParameter prm2 = new SqlParameter("Sifre", GSTb.Text.Trim());
                SqlCommand komut = new SqlCommand(sql, baglanti);
                komut.Parameters.Add(prm1);
                komut.Parameters.Add(prm2);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    Anasayfa fre = new Anasayfa();
                    fre.ShowDialog();
                }
            }
            catch(Exception)
            {
                MessageBox.Show("hatalı giriş");
            }
        }

        private void kayıt_Click(object sender, EventArgs e)
        {
            Form2 frm1 = new Form2();
            frm1.ShowDialog();
        }
        public static string KayıtAdTb;
        public static string KayıtParolaTb;




        private void Form1_Activated(object sender, EventArgs e)
        {
  
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
