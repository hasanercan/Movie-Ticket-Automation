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

namespace WindowsFormsApp2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        //Db bağlantısı oluştruduk
        SqlConnection baglanti = new SqlConnection("Data Source=SKY;Initial Catalog=190716043;Integrated Security=True");
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();//form 2 ye gitmeyi sağlayan kod bloğu formlar arası geçiş 
            frm.Show();
            this.Hide();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {   //insert into ile seans tablomuza textbox1 datetimepicker1 maskedtextbox1 e kullanıcının girdiği verilerin seans tablosuna kaydedilmesi sağlandı
            baglanti.Open();
            SqlCommand ekle = new SqlCommand("insert into seans(seans_adi,seans_tarih,seans_saat) values('" + textBox1.Text + "','" + dateTimePicker1.Text + "','" + maskedTextBox1.Text + "')", baglanti);
            ekle.ExecuteNonQuery();
            ekle.Dispose();
            baglanti.Close();
            MessageBox.Show("Seans Ekleme İşlemi Başarılı");
            textBox1.Text = "";
            maskedTextBox1.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
