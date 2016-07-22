namespace VideoMarket1
{
    partial class frmFilmSorgulama
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
            this.txtFilmAdi = new System.Windows.Forms.TextBox();
            this.cbFilmTuru = new System.Windows.Forms.ComboBox();
            this.txtYonetmen = new System.Windows.Forms.TextBox();
            this.txtOyuncular = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
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
            this.lvFilmGoruntuleme.Location = new System.Drawing.Point(13, 90);
            this.lvFilmGoruntuleme.Margin = new System.Windows.Forms.Padding(4);
            this.lvFilmGoruntuleme.Name = "lvFilmGoruntuleme";
            this.lvFilmGoruntuleme.Size = new System.Drawing.Size(792, 459);
            this.lvFilmGoruntuleme.TabIndex = 20;
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
            this.columnHeader5.Width = 130;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Özet";
            this.columnHeader6.Width = 200;
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
            // txtFilmAdi
            // 
            this.txtFilmAdi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFilmAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFilmAdi.Location = new System.Drawing.Point(13, 50);
            this.txtFilmAdi.Margin = new System.Windows.Forms.Padding(4);
            this.txtFilmAdi.Name = "txtFilmAdi";
            this.txtFilmAdi.Size = new System.Drawing.Size(165, 19);
            this.txtFilmAdi.TabIndex = 21;
            this.txtFilmAdi.TextChanged += new System.EventHandler(this.txtFilmAdi_TextChanged);
            // 
            // cbFilmTuru
            // 
            this.cbFilmTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilmTuru.DropDownWidth = 100;
            this.cbFilmTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbFilmTuru.FormattingEnabled = true;
            this.cbFilmTuru.Location = new System.Drawing.Point(238, 41);
            this.cbFilmTuru.Name = "cbFilmTuru";
            this.cbFilmTuru.Size = new System.Drawing.Size(119, 28);
            this.cbFilmTuru.TabIndex = 27;
            this.cbFilmTuru.SelectedIndexChanged += new System.EventHandler(this.cbFilmTuru_SelectedIndexChanged);
            // 
            // txtYonetmen
            // 
            this.txtYonetmen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtYonetmen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYonetmen.Location = new System.Drawing.Point(415, 50);
            this.txtYonetmen.Margin = new System.Windows.Forms.Padding(4);
            this.txtYonetmen.Name = "txtYonetmen";
            this.txtYonetmen.Size = new System.Drawing.Size(129, 19);
            this.txtYonetmen.TabIndex = 28;
            this.txtYonetmen.TextChanged += new System.EventHandler(this.txtYonetmen_TextChanged);
            // 
            // txtOyuncular
            // 
            this.txtOyuncular.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOyuncular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOyuncular.Location = new System.Drawing.Point(595, 50);
            this.txtOyuncular.Margin = new System.Windows.Forms.Padding(4);
            this.txtOyuncular.Name = "txtOyuncular";
            this.txtOyuncular.Size = new System.Drawing.Size(169, 19);
            this.txtOyuncular.TabIndex = 29;
            this.txtOyuncular.TextChanged += new System.EventHandler(this.txtOyuncular_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(35, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 25);
            this.label1.TabIndex = 30;
            this.label1.Text = "Ada Göre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(237, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 25);
            this.label2.TabIndex = 31;
            this.label2.Text = "Türe Göre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(401, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 25);
            this.label3.TabIndex = 32;
            this.label3.Text = "Yönetmene Göre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(593, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 25);
            this.label4.TabIndex = 33;
            this.label4.Text = "Oyunculara Göre";
            // 
            // frmFilmSorgulama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(841, 571);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOyuncular);
            this.Controls.Add(this.txtYonetmen);
            this.Controls.Add(this.cbFilmTuru);
            this.Controls.Add(this.txtFilmAdi);
            this.Controls.Add(this.lvFilmGoruntuleme);
            this.Name = "frmFilmSorgulama";
            this.Text = "Film Sorgulama";
            this.Load += new System.EventHandler(this.frmFilmSorgulama_Load);
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
        private System.Windows.Forms.TextBox txtFilmAdi;
        private System.Windows.Forms.ComboBox cbFilmTuru;
        private System.Windows.Forms.TextBox txtYonetmen;
        private System.Windows.Forms.TextBox txtOyuncular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}