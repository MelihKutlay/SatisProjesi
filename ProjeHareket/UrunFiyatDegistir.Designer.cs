namespace ProjeHareket
{
    partial class UrunFiyatDegistir
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtyenifiyat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmburunler = new System.Windows.Forms.ComboBox();
            this.txteskifiyat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 143);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(601, 282);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "YENİ FİYAT LİSTESİ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(595, 261);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnkaydet
            // 
            this.btnkaydet.Location = new System.Drawing.Point(167, 107);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(116, 30);
            this.btnkaydet.TabIndex = 22;
            this.btnkaydet.Text = "KAYDET";
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "ÜRÜN AD :";
            // 
            // txtyenifiyat
            // 
            this.txtyenifiyat.Location = new System.Drawing.Point(110, 78);
            this.txtyenifiyat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtyenifiyat.Name = "txtyenifiyat";
            this.txtyenifiyat.Size = new System.Drawing.Size(173, 22);
            this.txtyenifiyat.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "YENİ FİYAT :";
            // 
            // cmburunler
            // 
            this.cmburunler.FormattingEnabled = true;
            this.cmburunler.Location = new System.Drawing.Point(110, 17);
            this.cmburunler.Name = "cmburunler";
            this.cmburunler.Size = new System.Drawing.Size(173, 24);
            this.cmburunler.TabIndex = 26;
            this.cmburunler.SelectedIndexChanged += new System.EventHandler(this.cmburunler_SelectedIndexChanged);
            // 
            // txteskifiyat
            // 
            this.txteskifiyat.Enabled = false;
            this.txteskifiyat.Location = new System.Drawing.Point(110, 48);
            this.txteskifiyat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txteskifiyat.Name = "txteskifiyat";
            this.txteskifiyat.Size = new System.Drawing.Size(173, 22);
            this.txteskifiyat.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 27;
            this.label3.Text = "ESKİ FİYAT :";
            // 
            // UrunFiyatDegistir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 432);
            this.Controls.Add(this.txteskifiyat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmburunler);
            this.Controls.Add(this.txtyenifiyat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnkaydet);
            this.Controls.Add(this.label1);
            this.Name = "UrunFiyatDegistir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Fiyat Değiştirme Sayfası";
            this.Load += new System.EventHandler(this.UrunFiyatDegistir_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtyenifiyat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmburunler;
        private System.Windows.Forms.TextBox txteskifiyat;
        private System.Windows.Forms.Label label3;
    }
}