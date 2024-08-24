using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjeHareket
{
    public partial class SatisSayfasi : Form
    {
        public SatisSayfasi()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=MELIH\\MELIH;Initial Catalog=HareketVeriTabani;Integrated Security=True");

        void listele()
        {

            SqlCommand getir = new SqlCommand("EXEC HAREKET", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(getir);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            listele();

            {
                SqlCommand urunler = new SqlCommand("SELECT * FROM URUNLER", baglanti);
                SqlDataAdapter uyarla = new SqlDataAdapter(urunler);
                DataTable dt2 = new DataTable();
                uyarla.Fill(dt2);
                cmburunad.ValueMember = "ID";
                cmburunad.DisplayMember = "URUNAD";
                cmburunad.DataSource = dt2;

                SqlCommand musteriler = new SqlCommand("SELECT * FROM MUSTERI", baglanti);
                SqlDataAdapter uyarla2 = new SqlDataAdapter(musteriler);
                DataTable dt3 = new DataTable();
                uyarla2.Fill(dt3);
                cmbmusteriad.ValueMember = "ID";
                cmbmusteriad.DisplayMember = "MUSTERIADSOYAD";
                cmbmusteriad.DataSource = dt3;

                SqlCommand personeller = new SqlCommand("SELECT * FROM PERSONELLER", baglanti);
                SqlDataAdapter uyarla3 = new SqlDataAdapter(personeller);
                DataTable dt4 = new DataTable();
                uyarla3.Fill(dt4);
                cmbpersonelad.ValueMember = "ID";
                cmbpersonelad.DisplayMember = "PERSONELADSOYAD";
                cmbpersonelad.DataSource = dt4;
            }
        }

        private void btnyenisatis_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand ekle = new SqlCommand("INSERT INTO HAREKETLER (URUN,MUSTERI,PERSONEL,FIYAT) VALUES (@P1,@P2,@P3,@P4)", baglanti);
            ekle.Parameters.AddWithValue("@P1", cmburunad.SelectedValue);
            ekle.Parameters.AddWithValue("@P2", cmbmusteriad.SelectedValue);
            ekle.Parameters.AddWithValue("@P3", cmbpersonelad.SelectedValue);
            ekle.Parameters.AddWithValue("@P4", txtsatisfiyat.Text);
            ekle.ExecuteNonQuery();
            listele();
            baglanti.Close();
            MessageBox.Show("SATIŞ KAYDI BAŞARILI BİR ŞEKİLDE OLUŞTURULDU", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);



        }

        private void linkurunekle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UrunEkle git = new UrunEkle();
            git.Show();

        }

        private void linkmusteriekle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MusteriEkle git = new MusteriEkle();
            git.Show();
        }

        private void cmburunad_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand sec = new SqlCommand("select SATISFIYAT from URUNLER where URUNAD=@P1", baglanti);
            sec.Parameters.AddWithValue("@P1", cmburunad.Text);
            SqlDataReader OKU = sec.ExecuteReader();
            while (OKU.Read())
            {
                txtsatisfiyat.Text = OKU[0].ToString();
            }
            baglanti.Close();
        }

        private void linkpersonelekle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PersonelEkle git = new PersonelEkle();
            git.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UrunFiyatDegistir git = new UrunFiyatDegistir();
            git.Show();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand guncelle = new SqlCommand("UPDATE HAREKETLER SET URUN=@P1,MUSTERI=@P2,PERSONEL=@P3,FIYAT=@P4 WHERE HAREKETID=@P5", baglanti);
            guncelle.Parameters.AddWithValue("@P1", cmburunad.SelectedValue);
            guncelle.Parameters.AddWithValue("@P2", cmbmusteriad.SelectedValue);
            guncelle.Parameters.AddWithValue("@P3", cmbpersonelad.SelectedValue);
            guncelle.Parameters.AddWithValue("@P4", txtsatisfiyat.Text);
            guncelle.Parameters.AddWithValue("@P5", txthareketid.Text);
            guncelle.ExecuteNonQuery();
            listele();
            baglanti.Close();
            MessageBox.Show("SATIŞ KAYDI BAŞARILI BİR ŞEKİLDE GERÇEKLEŞTİRİLMİŞTİR", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txthareketid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            cmburunad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            cmbmusteriad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cmbpersonelad.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtsatisfiyat.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
        }

        private void btnguncelle_MouseHover(object sender, EventArgs e)
        {
            lblguncellebilgi.Visible = true;
            lblguncellebilgi.Text = "GÜNCELLEMEK İSTEDİĞİNİZ VERİNİN ÜSTÜNE 2 DEFA TIKLAYINIZ!!!";
        }

        private void btnguncelle_MouseLeave(object sender, EventArgs e)
        {
            lblguncellebilgi.Visible = false;

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand sil = new SqlCommand("DELETE FROM HAREKETLER WHERE HAREKETID=@P1", baglanti);
            sil.Parameters.AddWithValue("@P1", txthareketid.Text);
            sil.ExecuteNonQuery();
            listele();
            baglanti.Close();
            MessageBox.Show("KAYIT BAŞARILI BİR ŞEKİLDE SİLİNMİŞTİR", "BİLGİ0", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnsil_MouseHover(object sender, EventArgs e)
        {
            lblsilbilgi.Visible = true;
            lblsilbilgi.Text = "SİLMEK İSTEDİĞİNİZ VERİNİN ÜSTÜNE 2 DEFA TIKLAYINIZ!!!";
        }

        private void btnsil_MouseLeave(object sender, EventArgs e)
        {
            lblsilbilgi.Visible = false;
        }
    }
}
