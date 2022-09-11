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
    public partial class Form3 : Form
    {
        SqlConnection connection = new SqlConnection("Server=.\\SQLEXPRESS; Database=proje; UID=SA;PWD=12345678;Integrated Security=SSPI");

        private void verilerigöster()
        {
            listView1.Items.Clear();
           connection.Open();
            SqlCommand komut = new SqlCommand("Select * From ilaclar", connection);
            SqlDataReader oku = komut.ExecuteReader();
           

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["İd"].ToString();
                ekle.SubItems.Add(oku["ilacın adı"].ToString());
                ekle.SubItems.Add(oku["kutu sayısı"].ToString());
                ekle.SubItems.Add(oku["üretici firma"].ToString());
                ekle.SubItems.Add(oku["fiyat"].ToString());
                ekle.SubItems.Add(oku["kullanım amacı"].ToString());
                ekle.SubItems.Add(oku["teslim eden personel"].ToString());
                
                listView1.Items.Add(ekle);
            }
            connection.Close();
        }
        public Form3()
       
        {
            InitializeComponent();
        }

        private void simpleButton10_Click(object sender, EventArgs e)
        {
            Form2 yeni = new Form2();
            yeni.Show();
            this.Hide();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            verilerigöster();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                String id = textEdit1.Text;
                String ilacAdi = textEdit2.Text;   
                String kutuSayisi = textEdit3.Text;
                String ureticiFirma = textEdit4.Text;
                String fiyat = textEdit5.Text;  
                String amaci = textBox1.Text;
                String personel = textEdit6.Text;

                connection.Open();
                SqlCommand sqlCommand = new SqlCommand("INSERT INTO ilaclar([id],[ilacın adı],[kutu sayısı],[üretici firma],[fiyat],[kullanım amacı],[teslim eden personel])" +
                    " VALUES (@id,@ilacınAdı,@kutuSayısı,@üreticiFirma,@fiyat,@kullanımAmacı,@teslimEdenPersonel)", connection);
                sqlCommand.Parameters.Add("@id", id);
                sqlCommand.Parameters.Add("@ilacınAdı", ilacAdi);
                sqlCommand.Parameters.Add("@kutuSayısı", kutuSayisi);
                sqlCommand.Parameters.Add("@üreticiFirma", ureticiFirma);
                sqlCommand.Parameters.Add("@fiyat", fiyat);
                sqlCommand.Parameters.Add("@kullanımAmacı", amaci);
                sqlCommand.Parameters.Add("@teslimEdenPersonel", personel);
                sqlCommand.ExecuteNonQuery();

                MessageBox.Show("Veritabanına eklendi");
                connection.Close();
                verilerigöster();
            }
           
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanına eklenirken hata oluştu. Hata: " + ex.Message);
            }
           
        }
        int id = 0;
        private void btnSil_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand("Delete from ilaclar where id =(" + id + ")", connection);
            sqlCommand.ExecuteNonQuery();
            connection.Close();
            verilerigöster();
        }

        private void btnSil_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            textEdit1.Text = listView1.SelectedItems[0].SubItems[0].Text;
            textEdit2.Text = listView1.SelectedItems[0].SubItems[1].Text;
            textEdit3.Text = listView1.SelectedItems[0].SubItems[2].Text;
            textEdit4.Text = listView1.SelectedItems[0].SubItems[3].Text;
            textEdit5.Text = listView1.SelectedItems[0].SubItems[4].Text;
            textBox1.Text = listView1.SelectedItems[0].SubItems[5].Text;
            textEdit6.Text = listView1.SelectedItems[0].SubItems[6].Text;
        }

        private void btnDuzelt_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDüzelt_Click(object sender, EventArgs e)
        {

            // connection.Open();

             //String id = textEdit1.Text;
             //String ilacAdi = textEdit2.Text;
             //String kutuSayisi = textEdit3.Text;
             // String ureticiFirma = textEdit4.Text;
             // String fiyat = textEdit5.Text;
            //String amaci = textBox1.Text;
            //String personel = textEdit6.Text;



           //  SqlCommand sqlCommand = new SqlCommand("update ilaclar set([id],[ilacın adı],[kutu sayısı],[üretici firma],[fiyat],[kullanım amacı],[teslim eden personel])" +
             //" VALUES (@id,@ilacınAdı,@kutuSayısı,@üreticiFirma,@fiyat,@kullanımAmacı,@teslimEdenPersonel)", connection);
            // sqlCommand.Parameters.Add("@id", id);
            // sqlCommand.Parameters.Add("@ilacınAdı", ilacAdi);
            // sqlCommand.Parameters.Add("@kutuSayısı", kutuSayisi);
            // sqlCommand.Parameters.Add("@üreticiFirma", ureticiFirma);
            /// sqlCommand.Parameters.Add("@fiyat", fiyat);
           // sqlCommand.Parameters.Add("@kullanımAmacı", amaci);
            // sqlCommand.Parameters.Add("@teslimEdenPersonel", personel);
            //sqlCommand.ExecuteNonQuery();



             //connection.Close();
           // verilerigöster();

        }
    }
}
