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
    public partial class UrunEkle : Form
    {
        public UrunEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=MELIH\\MELIH;Initial Catalog=HareketVeriTabani;Integrated Security=True");

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand ekle = new SqlCommand("INSERT INTO URUNLER (URUNAD,STOK,ALISFIYAT,SATISFIYAT) VALUES (@P1,@P2,@P3,@P4)", baglanti);
            ekle.Parameters.AddWithValue("@P1", txtyeniurun.Text);
            ekle.Parameters.AddWithValue("@P2", txtstok.Text);
            ekle.Parameters.AddWithValue("@P3", txtalisfiyat.Text);
            ekle.Parameters.AddWithValue("@P4", txtsatisfiyat.Text);
            ekle.ExecuteNonQuery();
            baglanti.Close();

            SqlCommand getir = new SqlCommand("SELECT * FROM URUNLER", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(getir);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            MessageBox.Show("YENİ ÜRÜN EKLENMİŞTİR", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);

     

        }

        private void UrunEkle_Load(object sender, EventArgs e)
        {
            SqlCommand getir = new SqlCommand("SELECT * FROM URUNLER", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(getir);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }
    }
}
