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
    public partial class Form7 : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;
        public Form7()
        {
            InitializeComponent();
        }

        void satisgetir()
        {
            //satis tablosunun datagridwiev1 de görüntülenmesini sağlayan satisgetir isminde bir fonksiyon tanımladık.
            baglanti = new SqlConnection("Data Source=SKY;Initial Catalog=190716043;Integrated Security=True");
            baglanti.Open();
            da = new SqlDataAdapter("select * from satis", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            // buton  2 ye basıldığında form 2 ye dönme olayını sağladık.
            Form2 frm = new Form2();
            frm.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            //form load  olduğunda fonksiyon çalışacaktır ve tablomuz datagridview1 de görüntülenecektir.
            satisgetir();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //delete komutu ile datagridview1 de seçilen yerin satis_id ye göre silenebilmesi sağlanıyor.
            string sorgu = "delete  from satis where satis_id=@satis_id";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@satis_id",Convert.ToInt32(textBox1.Text));
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            satisgetir();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //textBox1 in textine seçilen yerin satis_id sinin gelmesini sağladık
             textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {//uygulamayı kapatma
            Application.Exit();
        }
    }
}
