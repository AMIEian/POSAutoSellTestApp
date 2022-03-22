using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TagidPOS;

namespace TestApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string barcodes = textBox1.Text;
            barcodes = barcodes.Replace("\r\n", ",");
            TagidPOS.TagidPOSHelper.PutBilledBarcodes(barcodes);
        }
    }
}
