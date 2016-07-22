namespace VideoMarket1
{
    partial class frmDetayliSatisSorgulama
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
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtToplamTutar = new System.Windows.Forms.TextBox();
            this.txtToplamAdet = new System.Windows.Forms.TextBox();
            this.btnGetir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpTarih2 = new System.Windows.Forms.DateTimePicker();
            this.dtpTarih1 = new System.Windows.Forms.DateTimePicker();
            this.dgvDetayliSatis = new System.Windows.Forms.DataGridView();
            this.txtFilmNo = new System.Windows.Forms.TextBox();
            this.txtMusteriNo = new System.Windows.Forms.TextBox();
            this.btnFilmAra = new System.Windows.Forms.Button();
            this.btnMusteriAra = new System.Windows.Forms.Button();
            this.txtFilm = new System.Windows.Forms.TextBox();
            this.txtMusteri = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxTumMusteriler = new System.Windows.Forms.CheckBox();
            this.cbxTumFilmler = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbFilmTurleri = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetayliSatis)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(1039, 624);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 20);
            this.label9.TabIndex = 75;
            this.label9.Text = "Toplam Tutar :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(812, 624);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 20);
            this.label8.TabIndex = 74;
            this.label8.Text = "Toplam Adet :";
            // 
            // txtToplamTutar
            // 
            this.txtToplamTutar.Enabled = false;
            this.txtToplamTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtToplamTutar.Location = new System.Drawing.Point(1183, 621);
            this.txtToplamTutar.Name = "txtToplamTutar";
            this.txtToplamTutar.Size = new System.Drawing.Size(69, 26);
            this.txtToplamTutar.TabIndex = 73;
            this.txtToplamTutar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtToplamAdet
            // 
            this.txtToplamAdet.Enabled = false;
            this.txtToplamAdet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtToplamAdet.Location = new System.Drawing.Point(948, 621);
            this.txtToplamAdet.Name = "txtToplamAdet";
            this.txtToplamAdet.Size = new System.Drawing.Size(69, 26);
            this.txtToplamAdet.TabIndex = 72;
            this.txtToplamAdet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnGetir
            // 
            this.btnGetir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGetir.Location = new System.Drawing.Point(143, 481);
            this.btnGetir.Name = "btnGetir";
            this.btnGetir.Size = new System.Drawing.Size(134, 31);
            this.btnGetir.TabIndex = 71;
            this.btnGetir.Text = "Satışları Getir";
            this.btnGetir.UseVisualStyleBackColor = true;
            this.btnGetir.Click += new System.EventHandler(this.btnGetir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(39, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 70;
            this.label2.Text = "Son Tarih :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(39, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 69;
            this.label1.Text = "ilk Tarih :";
            // 
            // dtpTarih2
            // 
            this.dtpTarih2.Location = new System.Drawing.Point(140, 74);
            this.dtpTarih2.Name = "dtpTarih2";
            this.dtpTarih2.Size = new System.Drawing.Size(137, 22);
            this.dtpTarih2.TabIndex = 68;
            // 
            // dtpTarih1
            // 
            this.dtpTarih1.Location = new System.Drawing.Point(140, 24);
            this.dtpTarih1.Name = "dtpTarih1";
            this.dtpTarih1.Size = new System.Drawing.Size(136, 22);
            this.dtpTarih1.TabIndex = 67;
            // 
            // dgvDetayliSatis
            // 
            this.dgvDetayliSatis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetayliSatis.Location = new System.Drawing.Point(442, 26);
            this.dgvDetayliSatis.Name = "dgvDetayliSatis";
            this.dgvDetayliSatis.RowTemplate.Height = 24;
            this.dgvDetayliSatis.Size = new System.Drawing.Size(810, 577);
            this.dgvDetayliSatis.TabIndex = 66;
            // 
            // txtFilmNo
            // 
            this.txtFilmNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFilmNo.Location = new System.Drawing.Point(9, 241);
            this.txtFilmNo.Name = "txtFilmNo";
            this.txtFilmNo.ReadOnly = true;
            this.txtFilmNo.Size = new System.Drawing.Size(24, 26);
            this.txtFilmNo.TabIndex = 83;
            // 
            // txtMusteriNo
            // 
            this.txtMusteriNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMusteriNo.Location = new System.Drawing.Point(9, 149);
            this.txtMusteriNo.Name = "txtMusteriNo";
            this.txtMusteriNo.ReadOnly = true;
            this.txtMusteriNo.Size = new System.Drawing.Size(24, 26);
            this.txtMusteriNo.TabIndex = 82;
            // 
            // btnFilmAra
            // 
            this.btnFilmAra.BackColor = System.Drawing.Color.DarkOrange;
            this.btnFilmAra.Enabled = false;
            this.btnFilmAra.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFilmAra.Location = new System.Drawing.Point(331, 242);
            this.btnFilmAra.Name = "btnFilmAra";
            this.btnFilmAra.Size = new System.Drawing.Size(70, 26);
            this.btnFilmAra.TabIndex = 81;
            this.btnFilmAra.Text = "...";
            this.btnFilmAra.UseVisualStyleBackColor = false;
            this.btnFilmAra.Click += new System.EventHandler(this.btnFilmAra_Click);
            // 
            // btnMusteriAra
            // 
            this.btnMusteriAra.BackColor = System.Drawing.Color.DarkOrange;
            this.btnMusteriAra.Enabled = false;
            this.btnMusteriAra.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMusteriAra.Location = new System.Drawing.Point(331, 149);
            this.btnMusteriAra.Name = "btnMusteriAra";
            this.btnMusteriAra.Size = new System.Drawing.Size(70, 26);
            this.btnMusteriAra.TabIndex = 80;
            this.btnMusteriAra.Text = "...";
            this.btnMusteriAra.UseVisualStyleBackColor = false;
            this.btnMusteriAra.Click += new System.EventHandler(this.btnMusteriAra_Click);
            // 
            // txtFilm
            // 
            this.txtFilm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFilm.Location = new System.Drawing.Point(127, 241);
            this.txtFilm.Name = "txtFilm";
            this.txtFilm.Size = new System.Drawing.Size(186, 26);
            this.txtFilm.TabIndex = 77;
            // 
            // txtMusteri
            // 
            this.txtMusteri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMusteri.Location = new System.Drawing.Point(127, 149);
            this.txtMusteri.Name = "txtMusteri";
            this.txtMusteri.Size = new System.Drawing.Size(186, 26);
            this.txtMusteri.TabIndex = 76;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(39, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 79;
            this.label3.Text = "Film :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(39, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 78;
            this.label4.Text = "Müşteri :";
            // 
            // cbxTumMusteriler
            // 
            this.cbxTumMusteriler.AutoSize = true;
            this.cbxTumMusteriler.Checked = true;
            this.cbxTumMusteriler.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxTumMusteriler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxTumMusteriler.Location = new System.Drawing.Point(132, 196);
            this.cbxTumMusteriler.Name = "cbxTumMusteriler";
            this.cbxTumMusteriler.Size = new System.Drawing.Size(144, 24);
            this.cbxTumMusteriler.TabIndex = 84;
            this.cbxTumMusteriler.Text = "Tüm Müşteriler";
            this.cbxTumMusteriler.UseVisualStyleBackColor = true;
            // 
            // cbxTumFilmler
            // 
            this.cbxTumFilmler.AutoSize = true;
            this.cbxTumFilmler.Checked = true;
            this.cbxTumFilmler.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxTumFilmler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxTumFilmler.Location = new System.Drawing.Point(132, 297);
            this.cbxTumFilmler.Name = "cbxTumFilmler";
            this.cbxTumFilmler.Size = new System.Drawing.Size(120, 24);
            this.cbxTumFilmler.TabIndex = 85;
            this.cbxTumFilmler.Text = "Tüm Filmler";
            this.cbxTumFilmler.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(39, 382);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 20);
            this.label5.TabIndex = 86;
            this.label5.Text = "Film Türleri :";
            // 
            // cbFilmTurleri
            // 
            this.cbFilmTurleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbFilmTurleri.FormattingEnabled = true;
            this.cbFilmTurleri.Location = new System.Drawing.Point(173, 380);
            this.cbFilmTurleri.Name = "cbFilmTurleri";
            this.cbFilmTurleri.Size = new System.Drawing.Size(186, 26);
            this.cbFilmTurleri.TabIndex = 87;
            // 
            // frmDetayliSatisSorgulama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(1282, 659);
            this.Controls.Add(this.cbFilmTurleri);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbxTumFilmler);
            this.Controls.Add(this.cbxTumMusteriler);
            this.Controls.Add(this.txtFilmNo);
            this.Controls.Add(this.txtMusteriNo);
            this.Controls.Add(this.btnFilmAra);
            this.Controls.Add(this.btnMusteriAra);
            this.Controls.Add(this.txtFilm);
            this.Controls.Add(this.txtMusteri);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtToplamTutar);
            this.Controls.Add(this.txtToplamAdet);
            this.Controls.Add(this.btnGetir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpTarih2);
            this.Controls.Add(this.dtpTarih1);
            this.Controls.Add(this.dgvDetayliSatis);
            this.Name = "frmDetayliSatisSorgulama";
            this.Text = "frmDetayliSatisSorgulama";
            this.Load += new System.EventHandler(this.frmDetayliSatisSorgulama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetayliSatis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtToplamTutar;
        private System.Windows.Forms.TextBox txtToplamAdet;
        private System.Windows.Forms.Button btnGetir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpTarih2;
        private System.Windows.Forms.DateTimePicker dtpTarih1;
        private System.Windows.Forms.DataGridView dgvDetayliSatis;
        private System.Windows.Forms.TextBox txtFilmNo;
        private System.Windows.Forms.TextBox txtMusteriNo;
        private System.Windows.Forms.Button btnFilmAra;
        private System.Windows.Forms.Button btnMusteriAra;
        private System.Windows.Forms.TextBox txtFilm;
        private System.Windows.Forms.TextBox txtMusteri;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbxTumMusteriler;
        private System.Windows.Forms.CheckBox cbxTumFilmler;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbFilmTurleri;
    }
}