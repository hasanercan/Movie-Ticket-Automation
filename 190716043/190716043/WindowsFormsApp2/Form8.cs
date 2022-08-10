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
    public partial class Form8 : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;

        public Form8()
        {
            InitializeComponent();
        }

        void filmgetir()
        {
            baglanti = new SqlConnection("Data Source=SKY;Initial Catalog=190716043;Integrated Security=True");
            baglanti.Open();
            da = new SqlDataAdapter("select * from filmler", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        { // buton  2 ye basıldığında form 2 ye dönme olayını sağladık.
            Form2 frm = new Form2();
            frm.Show();
            this.Hide();
        }

        private void Form8_Load(object sender, EventArgs e)
        {//form load  olduğunda fonksiyon çalışacaktır ve tablomuz datagridview1 de görüntülenecektir.
            filmgetir();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {//textBox1 in textine seçilen yerin film_id sinin gelmesini sağladık
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {//delete komutu ile datagridview1 de seçilen yerin film_id ye göre silenebilmesi sağlanıyor.
            string sorgu = "delete  from filmler where film_id=@film_id";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@film_id", Convert.ToInt32(textBox1.Text));
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            filmgetir();
        }

        private void button3_Click(object sender, EventArgs e)
        {//uygulamayı kapatma
            Application.Exit();
        }
    }
}
