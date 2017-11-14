using System;
using System.Drawing;
using System.Threading;

namespace appTARGET
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;


        private phnRfReceive mRfReceive = new phnRfReceive();

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
            this.mLableBia_1 = new System.Windows.Forms.GroupBox();
            this.mValueLan_1_Bia_1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mValueLan_2_Bia_1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mValueLan_3_Bia_1 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.mValueTong_Bia_1 = new System.Windows.Forms.TextBox();
            this.mInforBia1 = new System.Windows.Forms.Label();
            this.mStatusBia_1 = new System.Windows.Forms.PictureBox();
            this.mStatusBia_2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.mValueTong_Bia_2 = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.mValueLan_3_Bia_2 = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.mValueLan_2_Bia_2 = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.mValueLan_1_Bia_2 = new System.Windows.Forms.TextBox();
            this.mStatusBia_3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.mValueTong_Bia_3 = new System.Windows.Forms.TextBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.mValueLan_3_Bia_3 = new System.Windows.Forms.TextBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.mValueLan_2_Bia_3 = new System.Windows.Forms.TextBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.mValueLan_1_Bia_3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mStatusApp = new System.Windows.Forms.PictureBox();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.mLableBia_1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mStatusBia_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mStatusBia_2)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mStatusBia_3)).BeginInit();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mStatusApp)).BeginInit();
            this.SuspendLayout();
            // 
            // mLableBia_1
            // 
            this.mLableBia_1.Controls.Add(this.mValueLan_1_Bia_1);
            this.mLableBia_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mLableBia_1.Location = new System.Drawing.Point(225, 130);
            this.mLableBia_1.Margin = new System.Windows.Forms.Padding(4);
            this.mLableBia_1.Name = "mLableBia_1";
            this.mLableBia_1.Padding = new System.Windows.Forms.Padding(4);
            this.mLableBia_1.Size = new System.Drawing.Size(152, 106);
            this.mLableBia_1.TabIndex = 0;
            this.mLableBia_1.TabStop = false;
            this.mLableBia_1.Text = "Lan 1";
            // 
            // mValueLan_1_Bia_1
            // 
            this.mValueLan_1_Bia_1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mValueLan_1_Bia_1.Cursor = System.Windows.Forms.Cursors.No;
            this.mValueLan_1_Bia_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mValueLan_1_Bia_1.Location = new System.Drawing.Point(8, 48);
            this.mValueLan_1_Bia_1.Name = "mValueLan_1_Bia_1";
            this.mValueLan_1_Bia_1.ReadOnly = true;
            this.mValueLan_1_Bia_1.Size = new System.Drawing.Size(135, 37);
            this.mValueLan_1_Bia_1.TabIndex = 0;
            this.mValueLan_1_Bia_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mValueLan_2_Bia_1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(394, 130);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(152, 106);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lan 2";
            // 
            // mValueLan_2_Bia_1
            // 
            this.mValueLan_2_Bia_1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mValueLan_2_Bia_1.Cursor = System.Windows.Forms.Cursors.No;
            this.mValueLan_2_Bia_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mValueLan_2_Bia_1.Location = new System.Drawing.Point(8, 48);
            this.mValueLan_2_Bia_1.Name = "mValueLan_2_Bia_1";
            this.mValueLan_2_Bia_1.ReadOnly = true;
            this.mValueLan_2_Bia_1.Size = new System.Drawing.Size(135, 37);
            this.mValueLan_2_Bia_1.TabIndex = 0;
            this.mValueLan_2_Bia_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.mValueLan_3_Bia_1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(564, 130);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(152, 106);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lan 3";
            // 
            // mValueLan_3_Bia_1
            // 
            this.mValueLan_3_Bia_1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mValueLan_3_Bia_1.Cursor = System.Windows.Forms.Cursors.No;
            this.mValueLan_3_Bia_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mValueLan_3_Bia_1.Location = new System.Drawing.Point(8, 48);
            this.mValueLan_3_Bia_1.Name = "mValueLan_3_Bia_1";
            this.mValueLan_3_Bia_1.ReadOnly = true;
            this.mValueLan_3_Bia_1.Size = new System.Drawing.Size(135, 37);
            this.mValueLan_3_Bia_1.TabIndex = 0;
            this.mValueLan_3_Bia_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.mValueTong_Bia_1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(783, 130);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(152, 106);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tong";
            // 
            // mValueTong_Bia_1
            // 
            this.mValueTong_Bia_1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mValueTong_Bia_1.Cursor = System.Windows.Forms.Cursors.No;
            this.mValueTong_Bia_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mValueTong_Bia_1.Location = new System.Drawing.Point(8, 48);
            this.mValueTong_Bia_1.Name = "mValueTong_Bia_1";
            this.mValueTong_Bia_1.ReadOnly = true;
            this.mValueTong_Bia_1.Size = new System.Drawing.Size(135, 37);
            this.mValueTong_Bia_1.TabIndex = 0;
            this.mValueTong_Bia_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mInforBia1
            // 
            this.mInforBia1.AutoSize = true;
            this.mInforBia1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mInforBia1.Location = new System.Drawing.Point(17, 167);
            this.mInforBia1.Name = "mInforBia1";
            this.mInforBia1.Size = new System.Drawing.Size(86, 33);
            this.mInforBia1.TabIndex = 4;
            this.mInforBia1.Text = "Bia 1";
            // 
            // mStatusBia_1
            // 
            this.mStatusBia_1.Location = new System.Drawing.Point(148, 168);
            this.mStatusBia_1.Name = "mStatusBia_1";
            this.mStatusBia_1.Size = new System.Drawing.Size(30, 30);
            this.mStatusBia_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mStatusBia_1.TabIndex = 5;
            this.mStatusBia_1.TabStop = false;
            // 
            // mStatusBia_2
            // 
            this.mStatusBia_2.Location = new System.Drawing.Point(148, 308);
            this.mStatusBia_2.Name = "mStatusBia_2";
            this.mStatusBia_2.Size = new System.Drawing.Size(30, 30);
            this.mStatusBia_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mStatusBia_2.TabIndex = 11;
            this.mStatusBia_2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 33);
            this.label1.TabIndex = 10;
            this.label1.Text = "Bia 2";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.mValueTong_Bia_2);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(783, 270);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(152, 106);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tong";
            // 
            // mValueTong_Bia_2
            // 
            this.mValueTong_Bia_2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mValueTong_Bia_2.Cursor = System.Windows.Forms.Cursors.No;
            this.mValueTong_Bia_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mValueTong_Bia_2.Location = new System.Drawing.Point(8, 48);
            this.mValueTong_Bia_2.Name = "mValueTong_Bia_2";
            this.mValueTong_Bia_2.ReadOnly = true;
            this.mValueTong_Bia_2.Size = new System.Drawing.Size(135, 37);
            this.mValueTong_Bia_2.TabIndex = 0;
            this.mValueTong_Bia_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.mValueLan_3_Bia_2);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(564, 270);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(152, 106);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Lan 3";
            // 
            // mValueLan_3_Bia_2
            // 
            this.mValueLan_3_Bia_2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mValueLan_3_Bia_2.Cursor = System.Windows.Forms.Cursors.No;
            this.mValueLan_3_Bia_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mValueLan_3_Bia_2.Location = new System.Drawing.Point(8, 48);
            this.mValueLan_3_Bia_2.Name = "mValueLan_3_Bia_2";
            this.mValueLan_3_Bia_2.ReadOnly = true;
            this.mValueLan_3_Bia_2.Size = new System.Drawing.Size(135, 37);
            this.mValueLan_3_Bia_2.TabIndex = 0;
            this.mValueLan_3_Bia_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.mValueLan_2_Bia_2);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(394, 270);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox6.Size = new System.Drawing.Size(152, 106);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Lan 2";
            // 
            // mValueLan_2_Bia_2
            // 
            this.mValueLan_2_Bia_2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mValueLan_2_Bia_2.Cursor = System.Windows.Forms.Cursors.No;
            this.mValueLan_2_Bia_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mValueLan_2_Bia_2.Location = new System.Drawing.Point(8, 48);
            this.mValueLan_2_Bia_2.Name = "mValueLan_2_Bia_2";
            this.mValueLan_2_Bia_2.ReadOnly = true;
            this.mValueLan_2_Bia_2.Size = new System.Drawing.Size(135, 37);
            this.mValueLan_2_Bia_2.TabIndex = 0;
            this.mValueLan_2_Bia_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.mValueLan_1_Bia_2);
            this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.Location = new System.Drawing.Point(225, 270);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox7.Size = new System.Drawing.Size(152, 106);
            this.groupBox7.TabIndex = 6;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Lan 1";
            // 
            // mValueLan_1_Bia_2
            // 
            this.mValueLan_1_Bia_2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mValueLan_1_Bia_2.Cursor = System.Windows.Forms.Cursors.No;
            this.mValueLan_1_Bia_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mValueLan_1_Bia_2.Location = new System.Drawing.Point(8, 48);
            this.mValueLan_1_Bia_2.Name = "mValueLan_1_Bia_2";
            this.mValueLan_1_Bia_2.ReadOnly = true;
            this.mValueLan_1_Bia_2.Size = new System.Drawing.Size(135, 37);
            this.mValueLan_1_Bia_2.TabIndex = 0;
            this.mValueLan_1_Bia_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mStatusBia_3
            // 
            this.mStatusBia_3.Location = new System.Drawing.Point(148, 454);
            this.mStatusBia_3.Name = "mStatusBia_3";
            this.mStatusBia_3.Size = new System.Drawing.Size(30, 30);
            this.mStatusBia_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.mStatusBia_3.TabIndex = 17;
            this.mStatusBia_3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 453);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 33);
            this.label2.TabIndex = 16;
            this.label2.Text = "Bia 3";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.mValueTong_Bia_3);
            this.groupBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox8.Location = new System.Drawing.Point(783, 416);
            this.groupBox8.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox8.Size = new System.Drawing.Size(152, 106);
            this.groupBox8.TabIndex = 15;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Tong";
            // 
            // mValueTong_Bia_3
            // 
            this.mValueTong_Bia_3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mValueTong_Bia_3.Cursor = System.Windows.Forms.Cursors.No;
            this.mValueTong_Bia_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mValueTong_Bia_3.Location = new System.Drawing.Point(8, 45);
            this.mValueTong_Bia_3.Name = "mValueTong_Bia_3";
            this.mValueTong_Bia_3.ReadOnly = true;
            this.mValueTong_Bia_3.Size = new System.Drawing.Size(135, 37);
            this.mValueTong_Bia_3.TabIndex = 0;
            this.mValueTong_Bia_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.mValueLan_3_Bia_3);
            this.groupBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox9.Location = new System.Drawing.Point(564, 416);
            this.groupBox9.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox9.Size = new System.Drawing.Size(152, 106);
            this.groupBox9.TabIndex = 14;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Lan 3";
            // 
            // mValueLan_3_Bia_3
            // 
            this.mValueLan_3_Bia_3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mValueLan_3_Bia_3.Cursor = System.Windows.Forms.Cursors.No;
            this.mValueLan_3_Bia_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mValueLan_3_Bia_3.Location = new System.Drawing.Point(8, 45);
            this.mValueLan_3_Bia_3.Name = "mValueLan_3_Bia_3";
            this.mValueLan_3_Bia_3.ReadOnly = true;
            this.mValueLan_3_Bia_3.Size = new System.Drawing.Size(135, 37);
            this.mValueLan_3_Bia_3.TabIndex = 0;
            this.mValueLan_3_Bia_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.mValueLan_2_Bia_3);
            this.groupBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox10.Location = new System.Drawing.Point(394, 416);
            this.groupBox10.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox10.Size = new System.Drawing.Size(152, 106);
            this.groupBox10.TabIndex = 13;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Lan 2";
            // 
            // mValueLan_2_Bia_3
            // 
            this.mValueLan_2_Bia_3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mValueLan_2_Bia_3.Cursor = System.Windows.Forms.Cursors.No;
            this.mValueLan_2_Bia_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mValueLan_2_Bia_3.Location = new System.Drawing.Point(8, 45);
            this.mValueLan_2_Bia_3.Name = "mValueLan_2_Bia_3";
            this.mValueLan_2_Bia_3.ReadOnly = true;
            this.mValueLan_2_Bia_3.Size = new System.Drawing.Size(135, 37);
            this.mValueLan_2_Bia_3.TabIndex = 0;
            this.mValueLan_2_Bia_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.mValueLan_1_Bia_3);
            this.groupBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox11.Location = new System.Drawing.Point(225, 416);
            this.groupBox11.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox11.Size = new System.Drawing.Size(152, 106);
            this.groupBox11.TabIndex = 12;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Lan 1";
            // 
            // mValueLan_1_Bia_3
            // 
            this.mValueLan_1_Bia_3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mValueLan_1_Bia_3.Cursor = System.Windows.Forms.Cursors.No;
            this.mValueLan_1_Bia_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mValueLan_1_Bia_3.Location = new System.Drawing.Point(8, 45);
            this.mValueLan_1_Bia_3.Name = "mValueLan_1_Bia_3";
            this.mValueLan_1_Bia_3.ReadOnly = true;
            this.mValueLan_1_Bia_3.Size = new System.Drawing.Size(135, 37);
            this.mValueLan_1_Bia_3.TabIndex = 0;
            this.mValueLan_1_Bia_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 33);
            this.label3.TabIndex = 18;
            this.label3.Text = "Status";
            // 
            // mStatusApp
            // 
            this.mStatusApp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mStatusApp.InitialImage = null;
            this.mStatusApp.Location = new System.Drawing.Point(148, 57);
            this.mStatusApp.Name = "mStatusApp";
            this.mStatusApp.Size = new System.Drawing.Size(30, 30);
            this.mStatusApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mStatusApp.TabIndex = 19;
            this.mStatusApp.TabStop = false;
            // 
            // groupBox12
            // 
            this.groupBox12.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox12.Location = new System.Drawing.Point(13, 119);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(934, 131);
            this.groupBox12.TabIndex = 20;
            this.groupBox12.TabStop = false;
            // 
            // groupBox13
            // 
            this.groupBox13.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox13.Location = new System.Drawing.Point(13, 258);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(934, 131);
            this.groupBox13.TabIndex = 21;
            this.groupBox13.TabStop = false;
            // 
            // groupBox14
            // 
            this.groupBox14.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox14.Location = new System.Drawing.Point(13, 402);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(934, 131);
            this.groupBox14.TabIndex = 22;
            this.groupBox14.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 564);
            this.Controls.Add(this.mStatusApp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mStatusBia_3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.groupBox11);
            this.Controls.Add(this.mStatusBia_2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.mStatusBia_1);
            this.Controls.Add(this.mInforBia1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mLableBia_1);
            this.Controls.Add(this.groupBox12);
            this.Controls.Add(this.groupBox13);
            this.Controls.Add(this.groupBox14);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.mLableBia_1.ResumeLayout(false);
            this.mLableBia_1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mStatusBia_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mStatusBia_2)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mStatusBia_3)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mStatusApp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            mStatusApp.Image = Image.FromFile(System.Windows.Forms.Application.StartupPath + @"\system\status_error.png");
            mStatusApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;

            mStatusBia_1.Image = Image.FromFile(System.Windows.Forms.Application.StartupPath + @"\system\status_wait.png");
            mStatusBia_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;

            mStatusBia_2.Image = Image.FromFile(System.Windows.Forms.Application.StartupPath + @"\system\status_wait.png");
            mStatusBia_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;

            mStatusBia_3.Image = Image.FromFile(System.Windows.Forms.Application.StartupPath + @"\system\status_wait.png");
            mStatusBia_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;

            mValueLan_1_Bia_1.Text = "0";
            mValueLan_2_Bia_1.Text = "0";
            mValueLan_3_Bia_1.Text = "0";
            mValueTong_Bia_1.Text = "0";

            mValueLan_1_Bia_2.Text = "0";
            mValueLan_2_Bia_2.Text = "0";
            mValueLan_3_Bia_2.Text = "0";
            mValueTong_Bia_2.Text = "0";

            mValueLan_1_Bia_3.Text = "0";
            mValueLan_2_Bia_3.Text = "0";
            mValueLan_3_Bia_3.Text = "0";
            mValueTong_Bia_3.Text = "0";

            phnSysConfig.phnReadConfig();

            Thread InitDeviceThread = new Thread(new ThreadStart(InitDevice));
            InitDeviceThread.IsBackground = true;
            InitDeviceThread.Start();
        }

        private void InitDevice()
        {
            while (true)
            {
                try
                {
                 
                }
                catch
                {
                }

                mRfReceive.mRfReceiveEvent += new phnRfReceiveDelegate(MainRfReceiveEvent);

                int bErr = mRfReceive.phnRfReceive_IntializePort(phnSysConfig.mSerialPort, phnSysConfig.mStartAddress, phnSysConfig.mDestinationAddress);
                if (bErr > 0)
                {
                    try
                    {
                    }
                    catch
                    {
                    }
                    Thread.Sleep(2000);

                }
                else
                {
                    break;
                }
            }
        }


        public void MainRfReceiveEvent(int type, int value)
        {
            try
            {
                this.BeginInvoke((EventHandler)(delegate
                {
                    mValueLan_1_Bia_1.Text = value.ToString() + "";
                    mLableBia_1.Focus();

                }));
            }
            catch
            {
            }
           
        }

        #endregion

        private System.Windows.Forms.GroupBox mLableBia_1;
        private System.Windows.Forms.TextBox mValueLan_1_Bia_1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox mValueLan_2_Bia_1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox mValueLan_3_Bia_1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox mValueTong_Bia_1;
        private System.Windows.Forms.Label mInforBia1;
        private System.Windows.Forms.PictureBox mStatusBia_1;
        private System.Windows.Forms.PictureBox mStatusBia_2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox mValueTong_Bia_2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox mValueLan_3_Bia_2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox mValueLan_2_Bia_2;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox mValueLan_1_Bia_2;
        private System.Windows.Forms.PictureBox mStatusBia_3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox mValueTong_Bia_3;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.TextBox mValueLan_3_Bia_3;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.TextBox mValueLan_2_Bia_3;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.TextBox mValueLan_1_Bia_3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox mStatusApp;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.GroupBox groupBox14;
    }
}

