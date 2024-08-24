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
    public partial class UrunFiyatDegistir : Form
    {
        public UrunFiyatDegistir()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=MELIH\\MELIH;Initial Catalog=HareketVeriTabani;Integrated Security=True");

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand guncelle = new SqlCommand("UPDATE URUNLER SET SATISFIYAT=@P1 WHERE URUNAD=@P2", baglanti);
            guncelle.Parameters.AddWithValue("@P1", txtyenifiyat.Text);
            guncelle.Parameters.AddWithValue("@P2",cmburunler.Text);
            guncelle .ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("ÜRÜN FİYATI BAŞARILI BİR ŞEKİLDE DEĞİŞTİRLMİŞTİR", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            SqlCommand listele = new SqlCommand("SELECT URUNAD,SATISFIYAT FROM URUNLER", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(listele);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void UrunFiyatDegistir_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand getir = new SqlCommand("SELECT URUNAD FROM URUNLER", baglanti);
            SqlDataReader oku = getir.ExecuteReader();
            while(oku.Read())
            {
                cmburunler.Items.Add(oku[0].ToString());
            }
            baglanti.Close();

            SqlCommand listele = new SqlCommand("SELECT URUNAD,SATISFIYAT FROM URUNLER", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(listele);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void cmburunler_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand getir = new SqlCommand("SELECT SATISFIYAT FROM URUNLER WHERE URUNAD=@P1", baglanti);
            getir.Parameters.AddWithValue("P1",cmburunler.Text);
            SqlDataReader oku = getir.ExecuteReader();
            while (oku.Read())
            {
                txteskifiyat.Text = oku[0].ToString();
            }
            baglanti.Close();
        }
    }
}
