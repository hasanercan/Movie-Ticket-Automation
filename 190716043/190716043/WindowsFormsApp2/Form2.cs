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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3(); // bu kodlarla butonlara tıklandığında formlar arası geçiş gerçekleştriliyor.
            frm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 frm = new Form5();  // bu kodlarla butonlara tıklandığında formlar arası geçiş gerçekleştriliyor.
            frm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 frm = new Form4();  // bu kodlarla butonlara tıklandığında formlar arası geçiş gerçekleştriliyor.
            frm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form8 frm = new Form8();  // bu kodlarla butonlara tıklandığında formlar arası geçiş gerçekleştriliyor.
            frm.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form6 frm = new Form6();  // bu kodlarla butonlara tıklandığında formlar arası geçiş gerçekleştriliyor.
            frm.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form7 frm = new Form7();  // bu kodlarla butonlara tıklandığında formlar arası geçiş gerçekleştriliyor.
            frm.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
