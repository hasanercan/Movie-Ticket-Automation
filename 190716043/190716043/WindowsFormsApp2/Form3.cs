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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=SKY;Initial Catalog=190716043;Integrated Security=True");
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //salonekle adında bir komut oluştruurldu ve insert ile salon tablosunda salon_adi kolonuna textbox 1 e girilen verilerin kaydedilmesi sağlandı
            SqlCommand salonekle = new SqlCommand("insert into salon(salon_adi) values('" + textBox1.Text + "')", baglanti);
            baglanti.Open();
            salonekle.ExecuteNonQuery();
            salonekle.Dispose();
            baglanti.Close();
            MessageBox.Show("Salon Ekleme İşlemi Başarıyla Gerçekleşti");
            textBox1.Text = "";
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //button 4 e tıklandığında uygulamadan çıkış yapılıyor.
            Application.Exit();
        }
    }
}
