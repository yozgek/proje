﻿using System;
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
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Tedavi tdv = new Tedavi();
            tdv.Show();
            this.Hide();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            {
                Randevu rnd = new Randevu();
                rnd.Show();
                this.Hide();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

            Reçete rct = new Reçete();
            rct.Show();
            this.Hide();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hasta hst = new Hasta();
            hst.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {

        }
    }
}
