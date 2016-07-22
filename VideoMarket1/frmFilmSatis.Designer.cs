namespace VideoMarket1
{
    partial class frmFilmSatis
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
            this.dtpSatisTarihi = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMusteri = new System.Windows.Forms.TextBox();
            this.txtFilm = new System.Windows.Forms.TextBox();
            this.btnMusteriAra = new System.Windows.Forms.Button();
            this.btnFilmAra = new System.Windows.Forms.Button();
            this.lvSatisGoruntuleme = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSil = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnDegistir = new System.Windows.Forms.Button();
            this.btnYeni = new System.Windows.Forms.Button();
            this.txtTarih = new System.Windows.Forms.TextBox();
            this.txtMusteriNo = new System.Windows.Forms.TextBox();
            this.txtFilmNo = new System.Windows.Forms.TextBox();
            this.txtAdet = new System.Windows.Forms.TextBox();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtStok = new System.Windows.Forms.TextBox();
            this.txtToplamAdet = new System.Windows.Forms.TextBox();
            this.txtToplamTutar = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSatisNo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dtpSatisTarihi
            // 
            this.dtpSatisTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpSatisTarihi.Location = new System.Drawing.Point(333, 27);
            this.dtpSatisTarihi.Name = "dtpSatisTarihi";
            this.dtpSatisTarihi.Size = new System.Drawing.Size(24, 26);
            this.dtpSatisTarihi.TabIndex = 0;
            this.dtpSatisTarihi.ValueChanged += new System.EventHandler(this.dtpSatisTarihi_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(41, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tarih : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(41, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Müşteri :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(41, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Film :";
            // 
            // txtMusteri
            // 
            this.txtMusteri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMusteri.Location = new System.Drawing.Point(129, 75);
            this.txtMusteri.Name = "txtMusteri";
            this.txtMusteri.Size = new System.Drawing.Size(186, 26);
            this.txtMusteri.TabIndex = 0;
            // 
            // txtFilm
            // 
            this.txtFilm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFilm.Location = new System.Drawing.Point(129, 125);
            this.txtFilm.Name = "txtFilm";
            this.txtFilm.Size = new System.Drawing.Size(186, 26);
            this.txtFilm.TabIndex = 1;
            // 
            // btnMusteriAra
            // 
            this.btnMusteriAra.BackColor = System.Drawing.Color.DarkOrange;
            this.btnMusteriAra.Enabled = false;
            this.btnMusteriAra.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMusteriAra.Location = new System.Drawing.Point(333, 75);
            this.btnMusteriAra.Name = "btnMusteriAra";
            this.btnMusteriAra.Size = new System.Drawing.Size(70, 26);
            this.btnMusteriAra.TabIndex = 6;
            this.btnMusteriAra.Text = "...";
            this.btnMusteriAra.UseVisualStyleBackColor = false;
            this.btnMusteriAra.Click += new System.EventHandler(this.btnMusteriAra_Click);
            // 
            // btnFilmAra
            // 
            this.btnFilmAra.BackColor = System.Drawing.Color.DarkOrange;
            this.btnFilmAra.Enabled = false;
            this.btnFilmAra.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFilmAra.Location = new System.Drawing.Point(333, 126);
            this.btnFilmAra.Name = "btnFilmAra";
            this.btnFilmAra.Size = new System.Drawing.Size(70, 26);
            this.btnFilmAra.TabIndex = 7;
            this.btnFilmAra.Text = "...";
            this.btnFilmAra.UseVisualStyleBackColor = false;
            this.btnFilmAra.Click += new System.EventHandler(this.btnFilm_Click);
            // 
            // lvSatisGoruntuleme
            // 
            this.lvSatisGoruntuleme.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.lvSatisGoruntuleme.FullRowSelect = true;
            this.lvSatisGoruntuleme.GridLines = true;
            this.lvSatisGoruntuleme.Location = new System.Drawing.Point(12, 229);
            this.lvSatisGoruntuleme.Name = "lvSatisGoruntuleme";
            this.lvSatisGoruntuleme.Size = new System.Drawing.Size(760, 426);
            this.lvSatisGoruntuleme.TabIndex = 8;
            this.lvSatisGoruntuleme.UseCompatibleStateImageBehavior = false;
            this.lvSatisGoruntuleme.View = System.Windows.Forms.View.Details;
            this.lvSatisGoruntuleme.DoubleClick += new System.EventHandler(this.lvSatisGoruntuleme_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "No";
            this.columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "İşlem Tarihi";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Müşteri No";
            this.columnHeader3.Width = 0;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Müşteri";
            this.columnHeader4.Width = 90;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Film No";
            this.columnHeader5.Width = 0;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Film";
            this.columnHeader6.Width = 90;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Adet";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader7.Width = 50;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Birim Fiyat";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader8.Width = 80;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Tutar";
            this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader9.Width = 80;
            // 
            // btnSil
            // 
            this.btnSil.Enabled = false;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(563, 190);
            this.btnSil.Margin = new System.Windows.Forms.Padding(4);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(114, 32);
            this.btnSil.TabIndex = 46;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Enabled = false;
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(336, 190);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(4);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(107, 32);
            this.btnKaydet.TabIndex = 4;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnDegistir
            // 
            this.btnDegistir.Enabled = false;
            this.btnDegistir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDegistir.Location = new System.Drawing.Point(451, 190);
            this.btnDegistir.Margin = new System.Windows.Forms.Padding(4);
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.Size = new System.Drawing.Size(104, 32);
            this.btnDegistir.TabIndex = 45;
            this.btnDegistir.Text = "Değiştir";
            this.btnDegistir.UseVisualStyleBackColor = true;
            this.btnDegistir.Click += new System.EventHandler(this.btnDegistir_Click);
            // 
            // btnYeni
            // 
            this.btnYeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeni.Location = new System.Drawing.Point(11, 190);
            this.btnYeni.Margin = new System.Windows.Forms.Padding(4);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(103, 32);
            this.btnYeni.TabIndex = 44;
            this.btnYeni.Text = "Yeni";
            this.btnYeni.UseVisualStyleBackColor = true;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // txtTarih
            // 
            this.txtTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTarih.Location = new System.Drawing.Point(129, 28);
            this.txtTarih.Name = "txtTarih";
            this.txtTarih.ReadOnly = true;
            this.txtTarih.Size = new System.Drawing.Size(186, 26);
            this.txtTarih.TabIndex = 47;
            // 
            // txtMusteriNo
            // 
            this.txtMusteriNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMusteriNo.Location = new System.Drawing.Point(11, 75);
            this.txtMusteriNo.Name = "txtMusteriNo";
            this.txtMusteriNo.ReadOnly = true;
            this.txtMusteriNo.Size = new System.Drawing.Size(24, 26);
            this.txtMusteriNo.TabIndex = 48;
            // 
            // txtFilmNo
            // 
            this.txtFilmNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFilmNo.Location = new System.Drawing.Point(11, 125);
            this.txtFilmNo.Name = "txtFilmNo";
            this.txtFilmNo.ReadOnly = true;
            this.txtFilmNo.Size = new System.Drawing.Size(24, 26);
            this.txtFilmNo.TabIndex = 49;
            // 
            // txtAdet
            // 
            this.txtAdet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdet.Location = new System.Drawing.Point(129, 190);
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.Size = new System.Drawing.Size(50, 26);
            this.txtAdet.TabIndex = 2;
            this.txtAdet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAdet.Click += new System.EventHandler(this.txtAdet_Click);
            this.txtAdet.TextChanged += new System.EventHandler(this.txtAdet_TextChanged);
            // 
            // txtFiyat
            // 
            this.txtFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFiyat.Location = new System.Drawing.Point(185, 190);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(69, 26);
            this.txtFiyat.TabIndex = 3;
            this.txtFiyat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtFiyat.Click += new System.EventHandler(this.txtFiyat_Click);
            this.txtFiyat.TextChanged += new System.EventHandler(this.txtFiyat_TextChanged);
            // 
            // txtTutar
            // 
            this.txtTutar.Enabled = false;
            this.txtTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTutar.Location = new System.Drawing.Point(260, 190);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(69, 26);
            this.txtTutar.TabIndex = 52;
            this.txtTutar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(125, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 53;
            this.label4.Text = "Adet";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(181, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 20);
            this.label5.TabIndex = 54;
            this.label5.Text = "Fiyat";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(256, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 55;
            this.label6.Text = "Tutar";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(431, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 20);
            this.label7.TabIndex = 57;
            this.label7.Text = "Stok";
            // 
            // txtStok
            // 
            this.txtStok.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtStok.Location = new System.Drawing.Point(435, 126);
            this.txtStok.Name = "txtStok";
            this.txtStok.ReadOnly = true;
            this.txtStok.Size = new System.Drawing.Size(50, 26);
            this.txtStok.TabIndex = 56;
            this.txtStok.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtToplamAdet
            // 
            this.txtToplamAdet.Enabled = false;
            this.txtToplamAdet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtToplamAdet.Location = new System.Drawing.Point(468, 695);
            this.txtToplamAdet.Name = "txtToplamAdet";
            this.txtToplamAdet.Size = new System.Drawing.Size(69, 26);
            this.txtToplamAdet.TabIndex = 58;
            this.txtToplamAdet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtToplamTutar
            // 
            this.txtToplamTutar.Enabled = false;
            this.txtToplamTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtToplamTutar.Location = new System.Drawing.Point(703, 695);
            this.txtToplamTutar.Name = "txtToplamTutar";
            this.txtToplamTutar.Size = new System.Drawing.Size(69, 26);
            this.txtToplamTutar.TabIndex = 59;
            this.txtToplamTutar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(332, 698);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 20);
            this.label8.TabIndex = 60;
            this.label8.Text = "Toplam Adet :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(559, 698);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 20);
            this.label9.TabIndex = 61;
            this.label9.Text = "Toplam Tutar :";
            // 
            // txtSatisNo
            // 
            this.txtSatisNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSatisNo.Location = new System.Drawing.Point(11, 29);
            this.txtSatisNo.Name = "txtSatisNo";
            this.txtSatisNo.ReadOnly = true;
            this.txtSatisNo.Size = new System.Drawing.Size(24, 26);
            this.txtSatisNo.TabIndex = 62;
            // 
            // frmFilmSatis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(784, 755);
            this.Controls.Add(this.txtSatisNo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtToplamTutar);
            this.Controls.Add(this.txtToplamAdet);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtStok);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTutar);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.txtAdet);
            this.Controls.Add(this.txtFilmNo);
            this.Controls.Add(this.txtMusteriNo);
            this.Controls.Add(this.txtTarih);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnDegistir);
            this.Controls.Add(this.btnYeni);
            this.Controls.Add(this.lvSatisGoruntuleme);
            this.Controls.Add(this.btnFilmAra);
            this.Controls.Add(this.btnMusteriAra);
            this.Controls.Add(this.txtFilm);
            this.Controls.Add(this.txtMusteri);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpSatisTarihi);
            this.Name = "frmFilmSatis";
            this.Text = "Film Satış İşlemleri";
            this.Load += new System.EventHandler(this.frmFilmSatis_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpSatisTarihi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMusteri;
        private System.Windows.Forms.TextBox txtFilm;
        private System.Windows.Forms.Button btnMusteriAra;
        private System.Windows.Forms.Button btnFilmAra;
        private System.Windows.Forms.ListView lvSatisGoruntuleme;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnDegistir;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.TextBox txtTarih;
        private System.Windows.Forms.TextBox txtMusteriNo;
        private System.Windows.Forms.TextBox txtFilmNo;
        private System.Windows.Forms.TextBox txtAdet;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtStok;
        private System.Windows.Forms.TextBox txtToplamAdet;
        private System.Windows.Forms.TextBox txtToplamTutar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSatisNo;
    }
}