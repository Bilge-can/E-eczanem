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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Form3 yeni = new Form3();
            yeni.Show();
            this.Hide();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Form7 yeni = new Form7();
            yeni.Show();
            this.Hide();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            Form8 yeni = new Form8();
            yeni.Show();
            this.Hide();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            Form6 yeni = new Form6();
            yeni.Show();
            this.Hide();

        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
