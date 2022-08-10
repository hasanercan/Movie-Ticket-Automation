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
using System.IO;

namespace WindowsFormsApp2
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        string dosyayolu;
        string dosyaAdi;

        SqlConnection baglanti = new SqlConnection("Data Source=SKY;Initial Catalog=190716043;Integrated Security=True");
        private void Form5_Load(object sender, EventArgs e)
        {// salon ekle ve seans ekle panellerinden eklenen salon ve seansların combobaxlardan seçilebilmesi sağlandı.
            try
            {
                baglanti.Open();
                SqlCommand listele = new SqlCommand("select * from salon", baglanti);
                SqlDataReader dr = listele.ExecuteReader();
                while (dr.Read())
                {
                    comboBox1.Items.Add(dr["salon_id"].ToString());
                    comboBox3.Items.Add(dr["salon_adi"].ToString());
                }
                baglanti.Close();

                baglanti.Open();
                SqlCommand listeleseans = new SqlCommand("select * from seans", baglanti);
                SqlDataReader drs = listeleseans.ExecuteReader();
                while (drs.Read())
                {
                    comboBox2.Items.Add(drs["seans_id"].ToString());
                    comboBox4.Items.Add(drs["seans_adi"].ToString());
                }
                baglanti.Close();
            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.Message);
            }
        }
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Dosya aç isminde bir metod oluşturarak Afiş ekle butonuna basıldığında bilgisayardan dosya seçilebilmesini sağladık.Eğer dosya girilmediyse dosya
            //girmediniz uyarısı veriyor.
            if (DosyaAc.ShowDialog() == DialogResult.OK)
            {
                foreach (string i in DosyaAc.FileName.Split('\\'))
                {
                    if (i.Contains(".jpg")) { dosyaAdi = i; }
                    else if (i.Contains(".png")) { dosyaAdi = i; }
                    else { dosyayolu += i + "\\"; }
                }
                pictureBox1.ImageLocation = DosyaAc.FileName;
            }
            else
            {
                MessageBox.Show("Dosya Girmediniz!");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {//insert into ,le datagridwiev1 de kullanıcıı film seçtiğinde textbox ve combobax a girilen verilerin
            //filmler tablosun kaydedilmesini sağladık
            try
            {
                baglanti.Open();
                SqlCommand ekle = new SqlCommand("insert into filmler(seans_id,salon_id,film_adi,film_turu,yonetmen,afis) values ('" + comboBox1.Text + "','" + comboBox2.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + dosyaAdi + "')", baglanti);
                ekle.ExecuteNonQuery();
                ekle.Dispose();
                MessageBox.Show("Ekleme İşleminiz Başarıyla Gerçekleşmiştir.");
                if (dosyaAdi != "") File.WriteAllBytes(dosyaAdi, File.ReadAllBytes(DosyaAc.FileName));
                MessageBox.Show("Kayıt İşlemi Tamamlandı ! ", "İşlem Sonucu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                baglanti.Close();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                comboBox1.Text = "";
                comboBox2.Text = "";
                comboBox3.Text = "";
                comboBox4.Text = "";
                pictureBox1.ImageLocation = "AFİSEKLE.png";
            }
            catch (Exception hata)
            {

                MessageBox.Show("hata" + hata.Message);
            }
        }

        private void DosyaAc_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
