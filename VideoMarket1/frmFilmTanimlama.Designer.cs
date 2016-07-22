namespace VideoMarket1
{
    partial class frmFilmTanimlama
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
            this.lvFilmGoruntuleme = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtAramaTuru = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbAramaTuru = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFilmAdi = new System.Windows.Forms.TextBox();
            this.cbFilmTuru = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTurNo = new System.Windows.Forms.TextBox();
            this.txtFilmNo = new System.Windows.Forms.TextBox();
            this.txtYonetmen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOyuncular = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOzet = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnDegistir = new System.Windows.Forms.Button();
            this.btnYeni = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lvFilmGoruntuleme
            // 
            this.lvFilmGoruntuleme.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.lvFilmGoruntuleme.FullRowSelect = true;
            this.lvFilmGoruntuleme.GridLines = true;
            this.lvFilmGoruntuleme.Location = new System.Drawing.Point(465, 13);
            this.lvFilmGoruntuleme.Margin = new System.Windows.Forms.Padding(4);
            this.lvFilmGoruntuleme.Name = "lvFilmGoruntuleme";
            this.lvFilmGoruntuleme.Size = new System.Drawing.Size(689, 610);
            this.lvFilmGoruntuleme.TabIndex = 19;
            this.lvFilmGoruntuleme.UseCompatibleStateImageBehavior = false;
            this.lvFilmGoruntuleme.View = System.Windows.Forms.View.Details;
            this.lvFilmGoruntuleme.DoubleClick += new System.EventHandler(this.lvFilmGoruntuleme_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Film No";
            this.columnHeader1.Width = 0;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Film Adı";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Film Türü";
            this.columnHeader3.Width = 90;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Yönetmen";
            this.columnHeader4.Width = 90;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Oyuncular";
            this.columnHeader5.Width = 80;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Özet";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Fiyat";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Miktar";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "TürNo";
            this.columnHeader9.Width = 0;
            // 
            // txtAramaTuru
            // 
            this.txtAramaTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAramaTuru.Location = new System.Drawing.Point(159, 75);
            this.txtAramaTuru.Margin = new System.Windows.Forms.Padding(4);
            this.txtAramaTuru.Name = "txtAramaTuru";
            this.txtAramaTuru.Size = new System.Drawing.Size(196, 28);
            this.txtAramaTuru.TabIndex = 0;
            this.txtAramaTuru.TextChanged += new System.EventHandler(this.txtAramaTuru_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(13, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 24);
            this.label1.TabIndex = 20;
            this.label1.Text = "Arama Türü :";
            // 
            // cbAramaTuru
            // 
            this.cbAramaTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAramaTuru.DropDownWidth = 100;
            this.cbAramaTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbAramaTuru.FormattingEnabled = true;
            this.cbAramaTuru.Items.AddRange(new object[] {
            "Film Adına Göre"});
            this.cbAramaTuru.Location = new System.Drawing.Point(159, 32);
            this.cbAramaTuru.Name = "cbAramaTuru";
            this.cbAramaTuru.Size = new System.Drawing.Size(196, 28);
            this.cbAramaTuru.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(13, 160);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 24);
            this.label2.TabIndex = 23;
            this.label2.Text = "Film Adı :";
            // 
            // txtFilmAdi
            // 
            this.txtFilmAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFilmAdi.Location = new System.Drawing.Point(159, 157);
            this.txtFilmAdi.Margin = new System.Windows.Forms.Padding(4);
            this.txtFilmAdi.Name = "txtFilmAdi";
            this.txtFilmAdi.Size = new System.Drawing.Size(196, 28);
            this.txtFilmAdi.TabIndex = 1;
            // 
            // cbFilmTuru
            // 
            this.cbFilmTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilmTuru.DropDownWidth = 100;
            this.cbFilmTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbFilmTuru.FormattingEnabled = true;
            this.cbFilmTuru.Items.AddRange(new object[] {
            "Film Adına Göre",
            "Film Türüne Göre",
            "Yönetmene Göre",
            "Oyunculara Göre"});
            this.cbFilmTuru.Location = new System.Drawing.Point(159, 204);
            this.cbFilmTuru.Name = "cbFilmTuru";
            this.cbFilmTuru.Size = new System.Drawing.Size(196, 28);
            this.cbFilmTuru.TabIndex = 26;
            this.cbFilmTuru.SelectedIndexChanged += new System.EventHandler(this.cbFilmTuru_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(13, 205);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 24);
            this.label3.TabIndex = 25;
            this.label3.Text = "Film Türü :";
            // 
            // txtTurNo
            // 
            this.txtTurNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTurNo.Location = new System.Drawing.Point(362, 202);
            this.txtTurNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtTurNo.Name = "txtTurNo";
            this.txtTurNo.ReadOnly = true;
            this.txtTurNo.Size = new System.Drawing.Size(24, 28);
            this.txtTurNo.TabIndex = 27;
            // 
            // txtFilmNo
            // 
            this.txtFilmNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFilmNo.Location = new System.Drawing.Point(363, 157);
            this.txtFilmNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtFilmNo.Name = "txtFilmNo";
            this.txtFilmNo.ReadOnly = true;
            this.txtFilmNo.Size = new System.Drawing.Size(24, 28);
            this.txtFilmNo.TabIndex = 28;
            // 
            // txtYonetmen
            // 
            this.txtYonetmen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYonetmen.Location = new System.Drawing.Point(159, 260);
            this.txtYonetmen.Margin = new System.Windows.Forms.Padding(4);
            this.txtYonetmen.Name = "txtYonetmen";
            this.txtYonetmen.Size = new System.Drawing.Size(196, 28);
            this.txtYonetmen.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(13, 263);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 24);
            this.label4.TabIndex = 29;
            this.label4.Text = "Yönetmen :";
            // 
            // txtOyuncular
            // 
            this.txtOyuncular.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOyuncular.Location = new System.Drawing.Point(159, 317);
            this.txtOyuncular.Margin = new System.Windows.Forms.Padding(4);
            this.txtOyuncular.Multiline = true;
            this.txtOyuncular.Name = "txtOyuncular";
            this.txtOyuncular.Size = new System.Drawing.Size(196, 82);
            this.txtOyuncular.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(13, 317);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 24);
            this.label5.TabIndex = 31;
            this.label5.Text = "Oyuncular :";
            // 
            // txtOzet
            // 
            this.txtOzet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOzet.Location = new System.Drawing.Point(159, 426);
            this.txtOzet.Margin = new System.Windows.Forms.Padding(4);
            this.txtOzet.Multiline = true;
            this.txtOzet.Name = "txtOzet";
            this.txtOzet.Size = new System.Drawing.Size(196, 82);
            this.txtOzet.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(13, 426);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 24);
            this.label6.TabIndex = 33;
            this.label6.Text = "Özet :";
            // 
            // txtFiyat
            // 
            this.txtFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFiyat.Location = new System.Drawing.Point(93, 531);
            this.txtFiyat.Margin = new System.Windows.Forms.Padding(4);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(92, 28);
            this.txtFiyat.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(11, 534);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 24);
            this.label7.TabIndex = 35;
            this.label7.Text = "Fiyat :";
            // 
            // txtMiktar
            // 
            this.txtMiktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMiktar.Location = new System.Drawing.Point(307, 530);
            this.txtMiktar.Margin = new System.Windows.Forms.Padding(4);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(92, 28);
            this.txtMiktar.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(225, 533);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 24);
            this.label8.TabIndex = 37;
            this.label8.Text = "Miktar :";
            // 
            // btnSil
            // 
            this.btnSil.Enabled = false;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(307, 562);
            this.btnSil.Margin = new System.Windows.Forms.Padding(4);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(139, 61);
            this.btnSil.TabIndex = 42;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Enabled = false;
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(162, 562);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(4);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(139, 61);
            this.btnKaydet.TabIndex = 7;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnDegistir
            // 
            this.btnDegistir.Enabled = false;
            this.btnDegistir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDegistir.Location = new System.Drawing.Point(17, 562);
            this.btnDegistir.Margin = new System.Windows.Forms.Padding(4);
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.Size = new System.Drawing.Size(137, 61);
            this.btnDegistir.TabIndex = 40;
            this.btnDegistir.Text = "Değiştir";
            this.btnDegistir.UseVisualStyleBackColor = true;
            this.btnDegistir.Click += new System.EventHandler(this.btnDegistir_Click);
            // 
            // btnYeni
            // 
            this.btnYeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeni.Location = new System.Drawing.Point(159, 111);
            this.btnYeni.Margin = new System.Windows.Forms.Padding(4);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(196, 38);
            this.btnYeni.TabIndex = 39;
            this.btnYeni.Text = "Yeni";
            this.btnYeni.UseVisualStyleBackColor = true;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(357, 160);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 24);
            this.label9.TabIndex = 43;
            this.label9.Text = "*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(357, 263);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 24);
            this.label10.TabIndex = 44;
            this.label10.Text = "*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(359, 205);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 24);
            this.label11.TabIndex = 45;
            this.label11.Text = "*";
            // 
            // frmFilmTanimlama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(1162, 641);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnDegistir);
            this.Controls.Add(this.btnYeni);
            this.Controls.Add(this.txtMiktar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtOzet);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtOyuncular);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtYonetmen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFilmNo);
            this.Controls.Add(this.txtTurNo);
            this.Controls.Add(this.cbFilmTuru);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFilmAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbAramaTuru);
            this.Controls.Add(this.txtAramaTuru);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvFilmGoruntuleme);
            this.Name = "frmFilmTanimlama";
            this.Text = "Film Tanımlama";
            this.Load += new System.EventHandler(this.frmFilmTanimlama_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvFilmGoruntuleme;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.TextBox txtAramaTuru;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbAramaTuru;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFilmAdi;
        private System.Windows.Forms.ComboBox cbFilmTuru;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTurNo;
        private System.Windows.Forms.TextBox txtFilmNo;
        private System.Windows.Forms.TextBox txtYonetmen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOyuncular;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOzet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnDegistir;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}