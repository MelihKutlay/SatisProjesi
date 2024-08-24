namespace ProjeHareket
{
    partial class SatisSayfasi
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmburunad = new System.Windows.Forms.ComboBox();
            this.cmbmusteriad = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbpersonelad = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnyenisatis = new System.Windows.Forms.Button();
            this.txtsatisfiyat = new System.Windows.Forms.TextBox();
            this.linkurunekle = new System.Windows.Forms.LinkLabel();
            this.linkmusteriekle = new System.Windows.Forms.LinkLabel();
            this.linkpersonelekle = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.txthareketid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblguncellebilgi = new System.Windows.Forms.Label();
            this.btnsil = new System.Windows.Forms.Button();
            this.lblsilbilgi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 24);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(867, 313);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(14, 299);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(873, 341);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SATIŞLAR";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "ÜRÜN ADI :";
            // 
            // cmburunad
            // 
            this.cmburunad.FormattingEnabled = true;
            this.cmburunad.Location = new System.Drawing.Point(143, 51);
            this.cmburunad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmburunad.Name = "cmburunad";
            this.cmburunad.Size = new System.Drawing.Size(214, 27);
            this.cmburunad.TabIndex = 3;
            this.cmburunad.SelectedIndexChanged += new System.EventHandler(this.cmburunad_SelectedIndexChanged);
            // 
            // cmbmusteriad
            // 
            this.cmbmusteriad.FormattingEnabled = true;
            this.cmbmusteriad.Location = new System.Drawing.Point(143, 86);
            this.cmbmusteriad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbmusteriad.Name = "cmbmusteriad";
            this.cmbmusteriad.Size = new System.Drawing.Size(214, 27);
            this.cmbmusteriad.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "MÜŞTERİ AD :";
            // 
            // cmbpersonelad
            // 
            this.cmbpersonelad.FormattingEnabled = true;
            this.cmbpersonelad.Location = new System.Drawing.Point(143, 121);
            this.cmbpersonelad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbpersonelad.Name = "cmbpersonelad";
            this.cmbpersonelad.Size = new System.Drawing.Size(214, 27);
            this.cmbpersonelad.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "PERSONEL AD :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "SATIŞ FİYATI :";
            // 
            // btnyenisatis
            // 
            this.btnyenisatis.Location = new System.Drawing.Point(143, 190);
            this.btnyenisatis.Name = "btnyenisatis";
            this.btnyenisatis.Size = new System.Drawing.Size(214, 31);
            this.btnyenisatis.TabIndex = 10;
            this.btnyenisatis.Text = "YENİ SATIŞ ";
            this.btnyenisatis.UseVisualStyleBackColor = true;
            this.btnyenisatis.Click += new System.EventHandler(this.btnyenisatis_Click);
            // 
            // txtsatisfiyat
            // 
            this.txtsatisfiyat.Location = new System.Drawing.Point(143, 157);
            this.txtsatisfiyat.Name = "txtsatisfiyat";
            this.txtsatisfiyat.Size = new System.Drawing.Size(214, 27);
            this.txtsatisfiyat.TabIndex = 11;
            // 
            // linkurunekle
            // 
            this.linkurunekle.AutoSize = true;
            this.linkurunekle.Location = new System.Drawing.Point(363, 54);
            this.linkurunekle.Name = "linkurunekle";
            this.linkurunekle.Size = new System.Drawing.Size(112, 19);
            this.linkurunekle.TabIndex = 12;
            this.linkurunekle.TabStop = true;
            this.linkurunekle.Text = "Yeni Ürün Ekle";
            this.linkurunekle.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkurunekle_LinkClicked);
            // 
            // linkmusteriekle
            // 
            this.linkmusteriekle.AutoSize = true;
            this.linkmusteriekle.Location = new System.Drawing.Point(363, 89);
            this.linkmusteriekle.Name = "linkmusteriekle";
            this.linkmusteriekle.Size = new System.Drawing.Size(132, 19);
            this.linkmusteriekle.TabIndex = 13;
            this.linkmusteriekle.TabStop = true;
            this.linkmusteriekle.Text = "Yeni Müşteri Ekle";
            this.linkmusteriekle.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkmusteriekle_LinkClicked);
            // 
            // linkpersonelekle
            // 
            this.linkpersonelekle.AutoSize = true;
            this.linkpersonelekle.Location = new System.Drawing.Point(363, 124);
            this.linkpersonelekle.Name = "linkpersonelekle";
            this.linkpersonelekle.Size = new System.Drawing.Size(139, 19);
            this.linkpersonelekle.TabIndex = 14;
            this.linkpersonelekle.TabStop = true;
            this.linkpersonelekle.Text = "Yeni Personel Ekle";
            this.linkpersonelekle.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkpersonelekle_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(363, 160);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(141, 19);
            this.linkLabel1.TabIndex = 15;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Ürün Fiyat Değiştir";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnguncelle
            // 
            this.btnguncelle.Location = new System.Drawing.Point(143, 224);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(214, 31);
            this.btnguncelle.TabIndex = 16;
            this.btnguncelle.Text = "SATIŞ GÜNCELLE";
            this.btnguncelle.UseVisualStyleBackColor = true;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            this.btnguncelle.MouseLeave += new System.EventHandler(this.btnguncelle_MouseLeave);
            this.btnguncelle.MouseHover += new System.EventHandler(this.btnguncelle_MouseHover);
            // 
            // txthareketid
            // 
            this.txthareketid.Enabled = false;
            this.txthareketid.Location = new System.Drawing.Point(143, 17);
            this.txthareketid.Name = "txthareketid";
            this.txthareketid.Size = new System.Drawing.Size(214, 27);
            this.txthareketid.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 19);
            this.label5.TabIndex = 17;
            this.label5.Text = "HAREKET ID :";
            // 
            // lblguncellebilgi
            // 
            this.lblguncellebilgi.AutoSize = true;
            this.lblguncellebilgi.Font = new System.Drawing.Font("Times New Roman", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblguncellebilgi.ForeColor = System.Drawing.Color.Red;
            this.lblguncellebilgi.Location = new System.Drawing.Point(376, 230);
            this.lblguncellebilgi.Name = "lblguncellebilgi";
            this.lblguncellebilgi.Size = new System.Drawing.Size(31, 15);
            this.lblguncellebilgi.TabIndex = 19;
            this.lblguncellebilgi.Text = "bilgi";
            this.lblguncellebilgi.Visible = false;
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(143, 261);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(214, 31);
            this.btnsil.TabIndex = 20;
            this.btnsil.Text = "SATIŞ SİL";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            this.btnsil.MouseLeave += new System.EventHandler(this.btnsil_MouseLeave);
            this.btnsil.MouseHover += new System.EventHandler(this.btnsil_MouseHover);
            // 
            // lblsilbilgi
            // 
            this.lblsilbilgi.AutoSize = true;
            this.lblsilbilgi.Font = new System.Drawing.Font("Times New Roman", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsilbilgi.ForeColor = System.Drawing.Color.Red;
            this.lblsilbilgi.Location = new System.Drawing.Point(376, 270);
            this.lblsilbilgi.Name = "lblsilbilgi";
            this.lblsilbilgi.Size = new System.Drawing.Size(31, 15);
            this.lblsilbilgi.TabIndex = 21;
            this.lblsilbilgi.Text = "bilgi";
            this.lblsilbilgi.Visible = false;
            // 
            // SatisSayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(900, 653);
            this.Controls.Add(this.lblsilbilgi);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.lblguncellebilgi);
            this.Controls.Add(this.txthareketid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.linkpersonelekle);
            this.Controls.Add(this.linkmusteriekle);
            this.Controls.Add(this.linkurunekle);
            this.Controls.Add(this.txtsatisfiyat);
            this.Controls.Add(this.btnyenisatis);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbpersonelad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbmusteriad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmburunad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SatisSayfasi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Satış Sayfası";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmburunad;
        private System.Windows.Forms.ComboBox cmbmusteriad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbpersonelad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnyenisatis;
        private System.Windows.Forms.TextBox txtsatisfiyat;
        private System.Windows.Forms.LinkLabel linkurunekle;
        private System.Windows.Forms.LinkLabel linkmusteriekle;
        private System.Windows.Forms.LinkLabel linkpersonelekle;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.TextBox txthareketid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblguncellebilgi;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Label lblsilbilgi;
    }
}

