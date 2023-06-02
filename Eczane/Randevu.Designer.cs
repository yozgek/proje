
namespace Eczane
{
    partial class Randevu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Randevu));
            this.RandevuDGV = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.Rtarih = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.RadCb = new System.Windows.Forms.ComboBox();
            this.RtedaviCb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SaatCb = new System.Windows.Forms.ComboBox();
            this.AraaTb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.RandevuDGV)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // RandevuDGV
            // 
            this.RandevuDGV.BackgroundColor = System.Drawing.Color.Bisque;
            this.RandevuDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RandevuDGV.Location = new System.Drawing.Point(428, 211);
            this.RandevuDGV.Name = "RandevuDGV";
            this.RandevuDGV.Size = new System.Drawing.Size(478, 247);
            this.RandevuDGV.TabIndex = 39;
            this.RandevuDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RandevuDGV_CellClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(87, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 18);
            this.label6.TabIndex = 30;
            this.label6.Text = "SAAT :";
            // 
            // Rtarih
            // 
            this.Rtarih.CalendarMonthBackground = System.Drawing.Color.Ivory;
            this.Rtarih.CalendarTitleBackColor = System.Drawing.Color.Ivory;
            this.Rtarih.CalendarTrailingForeColor = System.Drawing.Color.Ivory;
            this.Rtarih.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Rtarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Rtarih.Location = new System.Drawing.Point(169, 255);
            this.Rtarih.MaxDate = new System.DateTime(2023, 12, 31, 0, 0, 0, 0);
            this.Rtarih.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.Rtarih.Name = "Rtarih";
            this.Rtarih.Size = new System.Drawing.Size(210, 26);
            this.Rtarih.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(81, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 18);
            this.label5.TabIndex = 28;
            this.label5.Text = "TARHİ :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(41, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 18);
            this.label2.TabIndex = 24;
            this.label2.Text = "AD SOYAD :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.button8);
            this.panel2.Controls.Add(this.button9);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(931, 94);
            this.panel2.TabIndex = 43;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(107, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 24);
            this.label8.TabIndex = 94;
            this.label8.Text = "<<<";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.SaddleBrown;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(361, 27);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(124, 40);
            this.button6.TabIndex = 9;
            this.button6.Text = "RANDEVU";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.BurlyWood;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button7.ForeColor = System.Drawing.Color.SaddleBrown;
            this.button7.Location = new System.Drawing.Point(726, 27);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(119, 40);
            this.button7.TabIndex = 8;
            this.button7.Text = "REÇETE";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.BurlyWood;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button8.ForeColor = System.Drawing.Color.SaddleBrown;
            this.button8.Location = new System.Drawing.Point(544, 27);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(123, 40);
            this.button8.TabIndex = 7;
            this.button8.Text = "TEDAVİ";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.BurlyWood;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button9.ForeColor = System.Drawing.Color.SaddleBrown;
            this.button9.Location = new System.Drawing.Point(177, 27);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(125, 40);
            this.button9.TabIndex = 6;
            this.button9.Text = "HASTA";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label1.Location = new System.Drawing.Point(904, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.AntiqueWhite;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(71, 91);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label4.Location = new System.Drawing.Point(260, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(406, 35);
            this.label4.TabIndex = 4;
            this.label4.Text = "     KONYA DENTAL KLİNİK     ";
            // 
            // RadCb
            // 
            this.RadCb.BackColor = System.Drawing.Color.Ivory;
            this.RadCb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RadCb.FormattingEnabled = true;
            this.RadCb.Items.AddRange(new object[] {
            "KADIN",
            "ERKEK"});
            this.RadCb.Location = new System.Drawing.Point(169, 211);
            this.RadCb.Name = "RadCb";
            this.RadCb.Size = new System.Drawing.Size(210, 27);
            this.RadCb.TabIndex = 44;
            this.RadCb.SelectedIndexChanged += new System.EventHandler(this.RadCb_SelectedIndexChanged);
            // 
            // RtedaviCb
            // 
            this.RtedaviCb.BackColor = System.Drawing.Color.Ivory;
            this.RtedaviCb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RtedaviCb.FormattingEnabled = true;
            this.RtedaviCb.Items.AddRange(new object[] {
            "Dis Cürügü",
            "Dis eti hastaliklari",
            "Kanal Tedavi",
            "Dolgu",
            "Cene Cerrahi",
            "Dis Temizlik",
            "İmp"});
            this.RtedaviCb.Location = new System.Drawing.Point(169, 342);
            this.RtedaviCb.Name = "RtedaviCb";
            this.RtedaviCb.Size = new System.Drawing.Size(210, 27);
            this.RtedaviCb.TabIndex = 47;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(69, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 18);
            this.label3.TabIndex = 46;
            this.label3.Text = "TEDAVİ :";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.BurlyWood;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button3.Location = new System.Drawing.Point(39, 426);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 32);
            this.button3.TabIndex = 50;
            this.button3.Text = "KAYDET";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.BurlyWood;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button2.Location = new System.Drawing.Point(163, 426);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 32);
            this.button2.TabIndex = 49;
            this.button2.Text = "GÜNCELLE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.BurlyWood;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button1.Location = new System.Drawing.Point(287, 426);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 32);
            this.button1.TabIndex = 48;
            this.button1.Text = "SİL";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SaatCb
            // 
            this.SaatCb.BackColor = System.Drawing.Color.Ivory;
            this.SaatCb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SaatCb.FormattingEnabled = true;
            this.SaatCb.Items.AddRange(new object[] {
            "09:00 - 10:00",
            "10:30 - 11:30",
            "12:00 - 13:00",
            "13:30 - 14:30",
            "15:00 - 16:00"});
            this.SaatCb.Location = new System.Drawing.Point(169, 298);
            this.SaatCb.Name = "SaatCb";
            this.SaatCb.Size = new System.Drawing.Size(210, 27);
            this.SaatCb.TabIndex = 51;
            // 
            // AraaTb
            // 
            this.AraaTb.BackColor = System.Drawing.Color.Ivory;
            this.AraaTb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AraaTb.ForeColor = System.Drawing.SystemColors.MenuText;
            this.AraaTb.Location = new System.Drawing.Point(522, 173);
            this.AraaTb.Multiline = true;
            this.AraaTb.Name = "AraaTb";
            this.AraaTb.Size = new System.Drawing.Size(291, 32);
            this.AraaTb.TabIndex = 52;
            this.AraaTb.TextChanged += new System.EventHandler(this.AraaTb_TextChanged);
            // 
            // Randevu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(931, 604);
            this.Controls.Add(this.AraaTb);
            this.Controls.Add(this.SaatCb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RtedaviCb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RadCb);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.RandevuDGV);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Rtarih);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Randevu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Randevu";
            this.Load += new System.EventHandler(this.Randevu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RandevuDGV)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView RandevuDGV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker Rtarih;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox RadCb;
        private System.Windows.Forms.ComboBox RtedaviCb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox SaatCb;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox AraaTb;
    }
}