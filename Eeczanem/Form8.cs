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
    public partial class Form8 : Form
    {
        SqlConnection connection = new SqlConnection("Server=.\\SQLEXPRESS; Database=proje; UID=SA;PWD=12345678;Integrated Security=SSPI");
        private void verilerigöster()
        {
            listView1.Items.Clear();
            connection.Open();
            SqlCommand komut = new SqlCommand("Select * From personel", connection);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["İd"].ToString();
                ekle.SubItems.Add(oku["TCKimlikNo"].ToString());
                ekle.SubItems.Add(oku["AdSoyad"].ToString());
                ekle.SubItems.Add(oku["DoğumTarihi"].ToString());
                ekle.SubItems.Add(oku["Adres"].ToString());
                ekle.SubItems.Add(oku["TelefonNo"].ToString());
                ekle.SubItems.Add(oku["Email"].ToString());
                ekle.SubItems.Add(oku["İşeGirişTarihi"].ToString());
                ekle.SubItems.Add(oku["Sigortası"].ToString());

                listView1.Items.Add(ekle);
            }
            connection.Close();
        }

        public Form8()
        {
            InitializeComponent();
        }

        private void simpleButton11_Click(object sender, EventArgs e)
        {
            Form2 yeni = new Form2();
            yeni.Show();
            this.Hide();

        }

        private void btnPersonelBilgileriniListele_Click(object sender, EventArgs e)
        {
            verilerigöster();
            
        }

        private void btnYeniKayıt_Click(object sender, EventArgs e)
        {
            try
            {
                String id = txtid.Text;
                String TCKimlikNo = txtTCKimlikNo.Text;
                String AdSoyad = txtAdSoyad.Text;
                String DoğumTarihi = txtDogumTarihi.Text;
                String Adres = txtAdres.Text;
                String TelefonNo = txtTelefonNo.Text;
                String Email = txtEmail.Text;
                String İşeGirişTarihi = txtİseGirisTarihi.Text;
                String Sigortası =cmbSigortası.Text;
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand("INSERT INTO personel([id],[TCKimlikNo],[AdSoyad],[DoğumTarihi],[Adres],[TelefonNo],[Email],[İşeGirişTarihi],[Sigortası])" +
                    " VALUES (@id,@TCKimlikNo,@AdSoyad,@DoğumTarihi,@Adres,@TelefonNo,@Email,@İşeGirişTarihi,@Sigortası)", connection);
                sqlCommand.Parameters.Add("@id", id);
                sqlCommand.Parameters.Add("@TCKimlikNo", TCKimlikNo);
                sqlCommand.Parameters.Add("@AdSoyad", AdSoyad);
                sqlCommand.Parameters.Add("@DoğumTarihi", DoğumTarihi);
                sqlCommand.Parameters.Add("@Adres", Adres);
                sqlCommand.Parameters.Add("@TelefonNo", TelefonNo);
                sqlCommand.Parameters.Add("@Email", Email);
                sqlCommand.Parameters.Add("@İşeGirişTarihi", İşeGirişTarihi);
                sqlCommand.Parameters.Add("@Sigortası", Sigortası);
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
            SqlCommand sqlCommand = new SqlCommand("Delete from personel where id =(" + id + ")", connection);
            sqlCommand.ExecuteNonQuery();
            connection.Close();
            verilerigöster();
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            txtid.Text = listView1.SelectedItems[0].SubItems[0].Text;
            txtTCKimlikNo.Text = listView1.SelectedItems[0].SubItems[1].Text;
            txtAdSoyad.Text = listView1.SelectedItems[0].SubItems[2].Text;
            txtDogumTarihi.Text = listView1.SelectedItems[0].SubItems[3].Text;
            txtAdres.Text = listView1.SelectedItems[0].SubItems[4].Text;
            txtTelefonNo.Text = listView1.SelectedItems[0].SubItems[5].Text;
            txtEmail.Text = listView1.SelectedItems[0].SubItems[6].Text;
            txtİseGirisTarihi.Text = listView1.SelectedItems[0].SubItems[7].Text;
            cmbSigortası.Text = listView1.SelectedItems[0].SubItems[8].Text;


        }
    }
    }

