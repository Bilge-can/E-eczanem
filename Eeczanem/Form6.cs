using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eeczanem
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.adanaeo.org.tr/nobetci-eczaneler");
        }

        private void simpleButton11_Click(object sender, EventArgs e)
        {
            Form2 yeni = new Form2();
            yeni.Show();
            this.Hide();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            simpleButton1.Enabled = false;

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            simpleButton2.Enabled = false;
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            simpleButton3.Enabled = false;

        }
    }
}
