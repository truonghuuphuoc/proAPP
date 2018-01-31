using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appTARGET
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.mRfReceive.updateValue((byte) mBe.SelectedIndex, (byte)mBia.SelectedIndex, 1);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.mRfReceive.updateValue((byte) mBe.SelectedIndex, (byte)mBia.SelectedIndex, 6);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.mRfReceive.updateValue((byte) mBe.SelectedIndex, (byte)mBia.SelectedIndex, 7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.mRfReceive.updateValue((byte) mBe.SelectedIndex, (byte)mBia.SelectedIndex, 8);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.mRfReceive.updateValue((byte) mBe.SelectedIndex, (byte)mBia.SelectedIndex, 9);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.mRfReceive.updateValue((byte) mBe.SelectedIndex, (byte)mBia.SelectedIndex, 10);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.mRfReceive.updateValue((byte) mBe.SelectedIndex, (byte)mBia.SelectedIndex, 2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.mRfReceive.updateValue((byte) mBe.SelectedIndex, (byte)mBia.SelectedIndex, 3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.mRfReceive.updateValue((byte) mBe.SelectedIndex, (byte)mBia.SelectedIndex, 4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.mRfReceive.updateValue((byte) mBe.SelectedIndex, (byte)mBia.SelectedIndex, 5);
        }
    }
}
