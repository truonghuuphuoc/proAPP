﻿using System;
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
            this.mBia = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.mBe = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // mBia
            // 
            this.mBia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mBia.FormattingEnabled = true;
            this.mBia.Items.AddRange(new object[] {
            "Bia so 4",
            "Bia so 7",
            "Bia so 8"});
            this.mBia.Location = new System.Drawing.Point(55, 138);
            this.mBia.Name = "mBia";
            this.mBia.Size = new System.Drawing.Size(310, 24);
            this.mBia.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(55, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(225, 345);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(140, 23);
            this.button6.TabIndex = 2;
            this.button6.Text = "10";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(225, 304);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(140, 23);
            this.button7.TabIndex = 3;
            this.button7.Text = "9";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(225, 265);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(140, 23);
            this.button8.TabIndex = 4;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(225, 222);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(140, 23);
            this.button9.TabIndex = 5;
            this.button9.Text = "7";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(225, 183);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(140, 23);
            this.button10.TabIndex = 6;
            this.button10.Text = "6";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(55, 222);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(55, 265);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(55, 304);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(140, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(55, 345);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(140, 23);
            this.button5.TabIndex = 10;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // mBe
            // 
            this.mBe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mBe.FormattingEnabled = true;
            this.mBe.Items.AddRange(new object[] {
            "Be 1",
            "Be 2",
            "Be 3"});
            this.mBe.Location = new System.Drawing.Point(55, 98);
            this.mBe.Name = "mBe";
            this.mBe.Size = new System.Drawing.Size(310, 24);
            this.mBe.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 488);
            this.Controls.Add(this.mBe);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mBia);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

            phnSysConfig.phnReadConfig();

            this.mBia.SelectedIndex = 0;
            this.mBe.SelectedIndex = 0;

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

           
        }

        #endregion

        private System.Windows.Forms.ComboBox mBia;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox mBe;
    }
}

