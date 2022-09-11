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
    public partial class Form4 : Form
    {
        SqlConnection connection = new SqlConnection("Server=.\\SQLEXPRESS; Database=proje; UID=SA;PWD=12345678;Integrated Security=SSPI");

        private void verileri_göster()
        {
            listView2.Items.Clear();
            connection.Open();
            SqlCommand komut = new SqlCommand("Select * From hasta", connection);
            SqlDataReader oku = komut.ExecuteReader();
            

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["TC Kimlik No"].ToString();
                ekle.SubItems.Add(oku["Ad Soyad"].ToString());
                ekle.SubItems.Add(oku["Sosyal Güvence"].ToString());
                ekle.SubItems.Add(oku["Adres"].ToString());
                ekle.SubItems.Add(oku["Telefon No"].ToString());
                ekle.SubItems.Add(oku["Kullandığı İlaçlar"].ToString());
                ekle.SubItems.Add(oku["Kullanım Şekli"].ToString());

                listView2.Items.Add(ekle);
            }
            connection.Close();
        }
        public Form4()
        {
            InitializeComponent();
        }

        private void simpleButton10_Click(object sender, EventArgs e)
        {
            Form2 yeni = new Form2();
            yeni.Show();
            this.Hide();
        }

        private void btnHastaBilgiListle_Click(object sender, EventArgs e)
        {
            verileri_göster();
        }

        private void btnYeniKayıt_Click(object sender, EventArgs e)
        {
            try
            {
                String TCKimlikNo = txtTCKimlikNo.Text;
                String AdSoyad = txtAdSoyad.Text;
                String SosyalGüvence = cmbSosyalGüvence.Text;
                String Adres = txtAdres.Text;
                String TelefonNo = txtTelefonNo.Text;
                String Kullandığıİlaçlar = txtKullandıgıİlaclar.Text;
                String KullanımŞekli = cmbKullanımSekli.Text;

                connection.Open();
                SqlCommand sqlCommand = new SqlCommand("INSERT INTO hasta([TC Kimlik No],[Ad Soyad],[Sosyal Güvence],[Adres],[Telefon No],[Kullandığı İlaçlar],[Kullanım Şekli])" +
                    " VALUES (@TCKimlikNo,@AdSoyad,@SosyalGüvence,@Adres,@TelefonNo,@Kullandığıİlaçlar,@KullanımŞekli)", connection);
                sqlCommand.Parameters.Add("@TCKimlikNo", TCKimlikNo);
                sqlCommand.Parameters.Add("@AdSoyad", AdSoyad);
                sqlCommand.Parameters.Add("@SosyalGüvence", SosyalGüvence);
                sqlCommand.Parameters.Add("@Adres", Adres);
                sqlCommand.Parameters.Add("@TelefonNo", TelefonNo);
                sqlCommand.Parameters.Add("@Kullandığıİlaçlar", Kullandığıİlaçlar);
                sqlCommand.Parameters.Add("@KullanımŞekli", KullanımŞekli);
                sqlCommand.ExecuteNonQuery();

                MessageBox.Show("Veritabanına eklendi");
                connection.Close();

                verileri_göster();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanına eklenirken hata oluştu. Hata: " + ex.Message);
            }
        }
        int TCKimlikNo = 0;
        private void btnSil_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand("Delete from hasta where [TC Kimlik No] =(" + TCKimlikNo + ")", connection);
            sqlCommand.ExecuteNonQuery();
            verileri_göster();
            connection.Close();

        }

        private void listView2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            TCKimlikNo = int.Parse(listView2.SelectedItems[0].SubItems[0].Text);
            txtTCKimlikNo.Text = listView2.SelectedItems[0].SubItems[0].Text;
            txtAdSoyad.Text = listView2.SelectedItems[0].SubItems[1].Text;
            cmbSosyalGüvence.Text = listView2.SelectedItems[0].SubItems[2].Text;
            txtAdres.Text = listView2.SelectedItems[0].SubItems[3].Text;
            txtTelefonNo.Text = listView2.SelectedItems[0].SubItems[4].Text;
            txtKullandıgıİlaclar.Text = listView2.SelectedItems[0].SubItems[5].Text;
            cmbKullanımSekli.Text = listView2.SelectedItems[0].SubItems[6].Text;
        }
    }
}
