using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjeHareket
{
    public partial class PersonelEkle : Form
    {
        public PersonelEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=MELIH\\MELIH;Initial Catalog=HareketVeriTabani;Integrated Security=True");

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand ekle = new SqlCommand("INSERT INTO PERSONELLER (PERSONELADSOYAD) VALUES (@P1)", baglanti);
            ekle.Parameters.AddWithValue("@P1", txtyenipersonel.Text);
            ekle.ExecuteNonQuery();
            baglanti.Close();

            SqlCommand getir = new SqlCommand("SELECT * FROM PERSONELLER", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(getir);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            MessageBox.Show("YENİ MÜŞTERİ EKLENMİŞTİR LÜTFEN UYGULAMAYI YENİDEN BAŞLATINIZ", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void PersonelEkle_Load(object sender, EventArgs e)
        {
            SqlCommand getir = new SqlCommand("SELECT * FROM PERSONELLER", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(getir);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
