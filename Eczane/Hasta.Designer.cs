﻿
using System;
using System.Windows.Forms;

namespace Eczane
{
    partial class Hasta
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hasta));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.HAdSoyadTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.HTelefonTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.HDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.HCinsiyetCb = new System.Windows.Forms.ComboBox();
            this.AlerjiTb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.AdresTb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.AraTb = new System.Windows.Forms.TextBox();
            this.dentaldbDataSet1 = new Eczane.dentaldbDataSet1();
            this.dentaldbDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HastaDGV = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dentaldbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dentaldbDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HastaDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(931, 94);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel2.Controls.Add(this.label9);
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
            this.panel2.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(110, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 24);
            this.label9.TabIndex = 94;
            this.label9.Text = "<<<";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.BurlyWood;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button6.ForeColor = System.Drawing.Color.SaddleBrown;
            this.button6.Location = new System.Drawing.Point(355, 27);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(124, 40);
            this.button6.TabIndex = 9;
            this.button6.Text = "RANDEVU";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.BurlyWood;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button7.ForeColor = System.Drawing.Color.SaddleBrown;
            this.button7.Location = new System.Drawing.Point(720, 27);
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
            this.button8.Location = new System.Drawing.Point(538, 27);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(123, 40);
            this.button8.TabIndex = 7;
            this.button8.Text = "TEDAVİ";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.SaddleBrown;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(171, 27);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(125, 40);
            this.button9.TabIndex = 6;
            this.button9.Text = "HASTA";
            this.button9.UseVisualStyleBackColor = false;
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
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label4.Location = new System.Drawing.Point(254, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(406, 35);
            this.label4.TabIndex = 4;
            this.label4.Text = "     KONYA DENTAL KLİNİK     ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // HAdSoyadTb
            // 
            this.HAdSoyadTb.BackColor = System.Drawing.Color.Ivory;
            this.HAdSoyadTb.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.HAdSoyadTb.ForeColor = System.Drawing.SystemColors.MenuText;
            this.HAdSoyadTb.Location = new System.Drawing.Point(175, 195);
            this.HAdSoyadTb.Multiline = true;
            this.HAdSoyadTb.Name = "HAdSoyadTb";
            this.HAdSoyadTb.Size = new System.Drawing.Size(210, 26);
            this.HAdSoyadTb.TabIndex = 5;
            this.HAdSoyadTb.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(44, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "AD SOYAD :";
            // 
            // HTelefonTb
            // 
            this.HTelefonTb.BackColor = System.Drawing.Color.Ivory;
            this.HTelefonTb.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.HTelefonTb.ForeColor = System.Drawing.SystemColors.MenuText;
            this.HTelefonTb.Location = new System.Drawing.Point(175, 239);
            this.HTelefonTb.Multiline = true;
            this.HTelefonTb.Name = "HTelefonTb";
            this.HTelefonTb.Size = new System.Drawing.Size(210, 26);
            this.HTelefonTb.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(57, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "TELEFON :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(14, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "DOĞUM TARİHİ :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // HDogumTarihi
            // 
            this.HDogumTarihi.CalendarMonthBackground = System.Drawing.Color.Ivory;
            this.HDogumTarihi.CalendarTitleBackColor = System.Drawing.Color.Ivory;
            this.HDogumTarihi.CalendarTrailingForeColor = System.Drawing.Color.Ivory;
            this.HDogumTarihi.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.HDogumTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.HDogumTarihi.Location = new System.Drawing.Point(175, 283);
            this.HDogumTarihi.MaxDate = new System.DateTime(2023, 12, 31, 0, 0, 0, 0);
            this.HDogumTarihi.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.HDogumTarihi.Name = "HDogumTarihi";
            this.HDogumTarihi.Size = new System.Drawing.Size(210, 29);
            this.HDogumTarihi.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(57, 329);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "CİNSİYET :";
            // 
            // HCinsiyetCb
            // 
            this.HCinsiyetCb.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.HCinsiyetCb.BackColor = System.Drawing.Color.Ivory;
            this.HCinsiyetCb.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.HCinsiyetCb.FormattingEnabled = true;
            this.HCinsiyetCb.Items.AddRange(new object[] {
            "Kadin ",
            "Erkek"});
            this.HCinsiyetCb.Location = new System.Drawing.Point(175, 327);
            this.HCinsiyetCb.Name = "HCinsiyetCb";
            this.HCinsiyetCb.Size = new System.Drawing.Size(210, 29);
            this.HCinsiyetCb.TabIndex = 12;
            // 
            // AlerjiTb
            // 
            this.AlerjiTb.BackColor = System.Drawing.Color.Ivory;
            this.AlerjiTb.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AlerjiTb.ForeColor = System.Drawing.SystemColors.MenuText;
            this.AlerjiTb.Location = new System.Drawing.Point(175, 372);
            this.AlerjiTb.Multiline = true;
            this.AlerjiTb.Name = "AlerjiTb";
            this.AlerjiTb.Size = new System.Drawing.Size(210, 26);
            this.AlerjiTb.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Mongolian Baiti", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(76, 371);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "ALERJİ :";
            // 
            // AdresTb
            // 
            this.AdresTb.BackColor = System.Drawing.Color.Ivory;
            this.AdresTb.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AdresTb.ForeColor = System.Drawing.SystemColors.MenuText;
            this.AdresTb.Location = new System.Drawing.Point(173, 416);
            this.AdresTb.Multiline = true;
            this.AdresTb.Name = "AdresTb";
            this.AdresTb.Size = new System.Drawing.Size(210, 26);
            this.AdresTb.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Mongolian Baiti", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(76, 413);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 18);
            this.label8.TabIndex = 15;
            this.label8.Text = "ADRES :";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.BurlyWood;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button1.Location = new System.Drawing.Point(287, 471);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 32);
            this.button1.TabIndex = 17;
            this.button1.Text = "SİL";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.BurlyWood;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button2.Location = new System.Drawing.Point(163, 471);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 32);
            this.button2.TabIndex = 18;
            this.button2.Text = "GÜNCELLE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.BurlyWood;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button3.Location = new System.Drawing.Point(39, 471);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 32);
            this.button3.TabIndex = 19;
            this.button3.Text = "KAYDET";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // AraTb
            // 
            this.AraTb.BackColor = System.Drawing.Color.Ivory;
            this.AraTb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AraTb.ForeColor = System.Drawing.SystemColors.MenuText;
            this.AraTb.Location = new System.Drawing.Point(506, 157);
            this.AraTb.Multiline = true;
            this.AraTb.Name = "AraTb";
            this.AraTb.Size = new System.Drawing.Size(291, 32);
            this.AraTb.TabIndex = 21;
            this.AraTb.TextChanged += new System.EventHandler(this.AraTb_TextChanged);
            // 
            // dentaldbDataSet1
            // 
            this.dentaldbDataSet1.DataSetName = "dentaldbDataSet1";
            this.dentaldbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dentaldbDataSet1BindingSource
            // 
            this.dentaldbDataSet1BindingSource.DataSource = this.dentaldbDataSet1;
            this.dentaldbDataSet1BindingSource.Position = 0;
            // 
            // HastaDGV
            // 
            this.HastaDGV.BackgroundColor = System.Drawing.Color.Bisque;
            this.HastaDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HastaDGV.Location = new System.Drawing.Point(416, 195);
            this.HastaDGV.Name = "HastaDGV";
            this.HastaDGV.Size = new System.Drawing.Size(478, 247);
            this.HastaDGV.TabIndex = 40;
            this.HastaDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.HastaDGV_CellClick);
            this.HastaDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.HastaDGV_CellContentClick_1);
            // 
            // Hasta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(931, 604);
            this.Controls.Add(this.HastaDGV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AraTb);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AdresTb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.AlerjiTb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.HCinsiyetCb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.HDogumTarihi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.HTelefonTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.HAdSoyadTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Hasta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hasta";
            this.Load += new System.EventHandler(this.Hasta_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dentaldbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dentaldbDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HastaDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void HastaDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox HAdSoyadTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox HTelefonTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker HDogumTarihi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox HCinsiyetCb;
        private System.Windows.Forms.TextBox AlerjiTb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox AdresTb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox AraTb;
        private System.Windows.Forms.BindingSource dentaldbDataSet1BindingSource;
        private dentaldbDataSet1 dentaldbDataSet1;
        private DataGridView HastaDGV;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Label label9;
    }
}