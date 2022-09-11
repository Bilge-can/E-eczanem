using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Eeczanem
{
    public partial class Form1 : Form
    {
        SqlConnection connection = new SqlConnection("Server=.\\SQLEXPRESS; Database=proje; UID=SA;PWD=12345678;Integrated Security=SSPI");

       
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string k_adi = textBox1.Text;
            string sifre = textBox2.Text;
            bool kayitli_mi = false;
            connection.Open();
            SqlCommand cmd = new SqlCommand("Select * from login4",connection);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (k_adi == dr["K_adi"].ToString() && sifre == dr["Şifre"].ToString())
                {
                    kayitli_mi = true;
                    break;
                }
                else kayitli_mi = false;
            }
            connection.Close();
            if (kayitli_mi == true)
            {
                MessageBox.Show("Giriş Başarılı");
                Form2 yeni = new Form2();
                yeni.Show();
                this.Hide();
            }

            else MessageBox.Show("Kullanıcı Adı veya Şifre Yanlış");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("E-Eczanem Uygulamasına Hoşgeldiniz");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            

            }
        }
    }

