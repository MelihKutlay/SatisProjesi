namespace ProjeHareket
{
    partial class UrunEkle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtyeniurun = new System.Windows.Forms.TextBox();
            this.txtstok = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtalisfiyat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtsatisfiyat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "YENİ ÜRÜN ADI :";
            // 
            // txtyeniurun
            // 
            this.txtyeniurun.Location = new System.Drawing.Point(174, 18);
            this.txtyeniurun.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtyeniurun.Name = "txtyeniurun";
            this.txtyeniurun.Size = new System.Drawing.Size(173, 27);
            this.txtyeniurun.TabIndex = 1;
            // 
            // txtstok
            // 
            this.txtstok.Location = new System.Drawing.Point(174, 53);
            this.txtstok.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtstok.Name = "txtstok";
            this.txtstok.Size = new System.Drawing.Size(173, 27);
            this.txtstok.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "STOK :";
            // 
            // txtalisfiyat
            // 
            this.txtalisfiyat.Location = new System.Drawing.Point(174, 88);
            this.txtalisfiyat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtalisfiyat.Name = "txtalisfiyat";
            this.txtalisfiyat.Size = new System.Drawing.Size(173, 27);
            this.txtalisfiyat.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "ALIŞ FİYATI :";
            // 
            // txtsatisfiyat
            // 
            this.txtsatisfiyat.Location = new System.Drawing.Point(174, 123);
            this.txtsatisfiyat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtsatisfiyat.Name = "txtsatisfiyat";
            this.txtsatisfiyat.Size = new System.Drawing.Size(173, 27);
            this.txtsatisfiyat.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "SATIŞ FİYATI :";
            // 
            // btnkaydet
            // 
            this.btnkaydet.Location = new System.Drawing.Point(231, 157);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(116, 30);
            this.btnkaydet.TabIndex = 8;
            this.btnkaydet.Text = "KAYDET";
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 193);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(742, 355);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ÜRÜNLER";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(736, 329);
            this.dataGridView1.TabIndex = 0;
            // 
            // UrunEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(766, 561);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnkaydet);
            this.Controls.Add(this.txtsatisfiyat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtalisfiyat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtstok);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtyeniurun);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UrunEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Ekleme Sayfası";
            this.Load += new System.EventHandler(this.UrunEkle_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtyeniurun;
        private System.Windows.Forms.TextBox txtstok;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtalisfiyat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtsatisfiyat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}