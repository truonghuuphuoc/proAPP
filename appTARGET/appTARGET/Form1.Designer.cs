using System;
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
            this.mValueBia_1 = new System.Windows.Forms.TextBox();
            this.mLableBia_1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mLableBia_1
            // 
            this.mLableBia_1.Controls.Add(this.mValueBia_1);
            this.mLableBia_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mLableBia_1.Location = new System.Drawing.Point(494, 43);
            this.mLableBia_1.Margin = new System.Windows.Forms.Padding(4);
            this.mLableBia_1.Name = "mLableBia_1";
            this.mLableBia_1.Padding = new System.Windows.Forms.Padding(4);
            this.mLableBia_1.Size = new System.Drawing.Size(160, 151);
            this.mLableBia_1.TabIndex = 0;
            this.mLableBia_1.TabStop = false;
            this.mLableBia_1.Text = "BIA 1";
            // 
            // mValueBia_1
            // 
            this.mValueBia_1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mValueBia_1.Cursor = System.Windows.Forms.Cursors.No;
            this.mValueBia_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mValueBia_1.Location = new System.Drawing.Point(7, 53);
            this.mValueBia_1.Name = "mValueBia_1";
            this.mValueBia_1.ReadOnly = true;
            this.mValueBia_1.Size = new System.Drawing.Size(146, 73);
            this.mValueBia_1.TabIndex = 0;
            this.mValueBia_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 448);
            this.Controls.Add(this.mLableBia_1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.mLableBia_1.ResumeLayout(false);
            this.mLableBia_1.PerformLayout();
            this.ResumeLayout(false);

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
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

                int bErr = mRfReceive.phnRfReceive_IntializePort("COM9");
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
                    mValueBia_1.Text = value.ToString() + "";
                    mLableBia_1.Focus();
                }));
            }
            catch
            {
            }
           
        }

        #endregion

        private System.Windows.Forms.GroupBox mLableBia_1;
        private System.Windows.Forms.TextBox mValueBia_1;
    }
}

