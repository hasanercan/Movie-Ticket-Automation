using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if ve else if deyimleriyle arayüze girilen user name ve pasworda girilen değerlerin kontrol edilmesi ve değerler doğruysa giriş 
            //yapılabilmesi sağlandı.
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Kullanıcı adı ve/veya şifre boş geçilemez.", "Uyarı!");
            }
            else
            {
                if (textBox1.Text == "admin" && textBox2.Text == "123")
                {
                    Form2 frm = new Form2();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre yanlış", "Uyarı!");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}