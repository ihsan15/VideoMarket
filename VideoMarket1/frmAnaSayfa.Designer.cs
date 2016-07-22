namespace VideoMarket1
{
    partial class frmAnaSayfa
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.filmBilgileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miFilmTanimlama = new System.Windows.Forms.ToolStripMenuItem();
            this.miFilmTuruTanimlama = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.miFilmSorgulama = new System.Windows.Forms.ToolStripMenuItem();
            this.miMusteriTanimlama = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriTanımlamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.miMusteriSorgulama = new System.Windows.Forms.ToolStripMenuItem();
            this.miFilmSatis = new System.Windows.Forms.ToolStripMenuItem();
            this.filmSatışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.miSatisSorgulama = new System.Windows.Forms.ToolStripMenuItem();
            this.miDetayliSatisRaporu = new System.Windows.Forms.ToolStripMenuItem();
            this.detaylıSatışRaporuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filmBilgileriToolStripMenuItem,
            this.miMusteriTanimlama,
            this.miFilmSatis,
            this.miDetayliSatisRaporu,
            this.çıkışToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1228, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // filmBilgileriToolStripMenuItem
            // 
            this.filmBilgileriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miFilmTanimlama,
            this.miFilmTuruTanimlama,
            this.toolStripSeparator1,
            this.miFilmSorgulama});
            this.filmBilgileriToolStripMenuItem.Name = "filmBilgileriToolStripMenuItem";
            this.filmBilgileriToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.filmBilgileriToolStripMenuItem.Text = "Film Bilgileri";
            // 
            // miFilmTanimlama
            // 
            this.miFilmTanimlama.Name = "miFilmTanimlama";
            this.miFilmTanimlama.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.miFilmTanimlama.Size = new System.Drawing.Size(272, 26);
            this.miFilmTanimlama.Text = "Film Tanımlama";
            this.miFilmTanimlama.Click += new System.EventHandler(this.filmTanımlamaToolStripMenuItem_Click);
            // 
            // miFilmTuruTanimlama
            // 
            this.miFilmTuruTanimlama.Name = "miFilmTuruTanimlama";
            this.miFilmTuruTanimlama.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.miFilmTuruTanimlama.Size = new System.Drawing.Size(272, 26);
            this.miFilmTuruTanimlama.Text = "Film Türü Tanımlama";
            this.miFilmTuruTanimlama.Click += new System.EventHandler(this.miFilmTuruTanimlama_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(269, 6);
            // 
            // miFilmSorgulama
            // 
            this.miFilmSorgulama.Name = "miFilmSorgulama";
            this.miFilmSorgulama.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.miFilmSorgulama.Size = new System.Drawing.Size(272, 26);
            this.miFilmSorgulama.Text = "Film Sorgulama";
            this.miFilmSorgulama.Click += new System.EventHandler(this.miFilmSorgulama_Click);
            // 
            // miMusteriTanimlama
            // 
            this.miMusteriTanimlama.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.müşteriTanımlamaToolStripMenuItem,
            this.toolStripSeparator2,
            this.miMusteriSorgulama});
            this.miMusteriTanimlama.Name = "miMusteriTanimlama";
            this.miMusteriTanimlama.Size = new System.Drawing.Size(87, 24);
            this.miMusteriTanimlama.Text = "Müşteriler";
            // 
            // müşteriTanımlamaToolStripMenuItem
            // 
            this.müşteriTanımlamaToolStripMenuItem.Name = "müşteriTanımlamaToolStripMenuItem";
            this.müşteriTanımlamaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.müşteriTanımlamaToolStripMenuItem.Size = new System.Drawing.Size(262, 26);
            this.müşteriTanımlamaToolStripMenuItem.Text = "Müşteri Tanımlama";
            this.müşteriTanımlamaToolStripMenuItem.Click += new System.EventHandler(this.müşteriTanımlamaToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(259, 6);
            // 
            // miMusteriSorgulama
            // 
            this.miMusteriSorgulama.Name = "miMusteriSorgulama";
            this.miMusteriSorgulama.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.miMusteriSorgulama.Size = new System.Drawing.Size(262, 26);
            this.miMusteriSorgulama.Text = "Müşteri Sorgulama";
            this.miMusteriSorgulama.Click += new System.EventHandler(this.miMusteriSorgulama_Click);
            // 
            // miFilmSatis
            // 
            this.miFilmSatis.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filmSatışToolStripMenuItem,
            this.toolStripSeparator3,
            this.miSatisSorgulama});
            this.miFilmSatis.Name = "miFilmSatis";
            this.miFilmSatis.Size = new System.Drawing.Size(112, 24);
            this.miFilmSatis.Text = "Satış İşlemleri";
            // 
            // filmSatışToolStripMenuItem
            // 
            this.filmSatışToolStripMenuItem.Name = "filmSatışToolStripMenuItem";
            this.filmSatışToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.filmSatışToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.filmSatışToolStripMenuItem.Text = "Film Satış";
            this.filmSatışToolStripMenuItem.Click += new System.EventHandler(this.filmSatışToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(240, 6);
            // 
            // miSatisSorgulama
            // 
            this.miSatisSorgulama.Name = "miSatisSorgulama";
            this.miSatisSorgulama.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.miSatisSorgulama.Size = new System.Drawing.Size(243, 26);
            this.miSatisSorgulama.Text = "Satış Sorgulama";
            this.miSatisSorgulama.Click += new System.EventHandler(this.miSatisSorgulama_Click);
            // 
            // miDetayliSatisRaporu
            // 
            this.miDetayliSatisRaporu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.detaylıSatışRaporuToolStripMenuItem});
            this.miDetayliSatisRaporu.Name = "miDetayliSatisRaporu";
            this.miDetayliSatisRaporu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.miDetayliSatisRaporu.Size = new System.Drawing.Size(94, 24);
            this.miDetayliSatisRaporu.Text = "Raporlama";
            // 
            // detaylıSatışRaporuToolStripMenuItem
            // 
            this.detaylıSatışRaporuToolStripMenuItem.Name = "detaylıSatışRaporuToolStripMenuItem";
            this.detaylıSatışRaporuToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.detaylıSatışRaporuToolStripMenuItem.Text = "Detaylı Satış Raporu";
            this.detaylıSatışRaporuToolStripMenuItem.Click += new System.EventHandler(this.detaylıSatışRaporuToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click_1);
            // 
            // frmAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 674);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmAnaSayfa";
            this.Text = "frmAnaSayfa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem filmBilgileriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miFilmTanimlama;
        private System.Windows.Forms.ToolStripMenuItem miFilmTuruTanimlama;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem miFilmSorgulama;
        private System.Windows.Forms.ToolStripMenuItem miMusteriTanimlama;
        private System.Windows.Forms.ToolStripMenuItem müşteriTanımlamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem miMusteriSorgulama;
        private System.Windows.Forms.ToolStripMenuItem miFilmSatis;
        private System.Windows.Forms.ToolStripMenuItem filmSatışToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem miSatisSorgulama;
        private System.Windows.Forms.ToolStripMenuItem miDetayliSatisRaporu;
        private System.Windows.Forms.ToolStripMenuItem detaylıSatışRaporuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
    }
}