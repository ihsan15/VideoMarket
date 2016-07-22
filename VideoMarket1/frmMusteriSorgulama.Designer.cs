namespace VideoMarket1
{
    partial class frmMusteriSorgulama
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
            this.lvMusteriGoruntuleme = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTelefonaGore = new System.Windows.Forms.TextBox();
            this.txtAdaGore = new System.Windows.Forms.TextBox();
            this.txtSoyadaGore = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lvMusteriGoruntuleme
            // 
            this.lvMusteriGoruntuleme.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvMusteriGoruntuleme.FullRowSelect = true;
            this.lvMusteriGoruntuleme.GridLines = true;
            this.lvMusteriGoruntuleme.Location = new System.Drawing.Point(13, 89);
            this.lvMusteriGoruntuleme.Margin = new System.Windows.Forms.Padding(4);
            this.lvMusteriGoruntuleme.Name = "lvMusteriGoruntuleme";
            this.lvMusteriGoruntuleme.Size = new System.Drawing.Size(984, 488);
            this.lvMusteriGoruntuleme.TabIndex = 82;
            this.lvMusteriGoruntuleme.UseCompatibleStateImageBehavior = false;
            this.lvMusteriGoruntuleme.View = System.Windows.Forms.View.Details;
            this.lvMusteriGoruntuleme.DoubleClick += new System.EventHandler(this.lvMusteriGoruntuleme_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "MusteriNo";
            this.columnHeader1.Width = 0;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Musteri Adı";
            this.columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Soyadı";
            this.columnHeader3.Width = 90;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Telefon";
            this.columnHeader4.Width = 90;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Adres";
            this.columnHeader5.Width = 130;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(451, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 25);
            this.label4.TabIndex = 90;
            this.label4.Text = "Telefona Göre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(264, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 25);
            this.label3.TabIndex = 89;
            this.label3.Text = "Soyada Göre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(75, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 25);
            this.label1.TabIndex = 87;
            this.label1.Text = "Ada Göre";
            // 
            // txtTelefonaGore
            // 
            this.txtTelefonaGore.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefonaGore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTelefonaGore.Location = new System.Drawing.Point(438, 46);
            this.txtTelefonaGore.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefonaGore.Name = "txtTelefonaGore";
            this.txtTelefonaGore.Size = new System.Drawing.Size(169, 19);
            this.txtTelefonaGore.TabIndex = 2;
            this.txtTelefonaGore.TextChanged += new System.EventHandler(this.txtTelefonaGore_TextChanged);
            // 
            // txtAdaGore
            // 
            this.txtAdaGore.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAdaGore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdaGore.Location = new System.Drawing.Point(48, 46);
            this.txtAdaGore.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdaGore.Name = "txtAdaGore";
            this.txtAdaGore.Size = new System.Drawing.Size(165, 19);
            this.txtAdaGore.TabIndex = 0;
            this.txtAdaGore.TextChanged += new System.EventHandler(this.txtAdaGore_TextChanged);
            // 
            // txtSoyadaGore
            // 
            this.txtSoyadaGore.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSoyadaGore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSoyadaGore.Location = new System.Drawing.Point(249, 46);
            this.txtSoyadaGore.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoyadaGore.Name = "txtSoyadaGore";
            this.txtSoyadaGore.Size = new System.Drawing.Size(165, 19);
            this.txtSoyadaGore.TabIndex = 1;
            this.txtSoyadaGore.TextChanged += new System.EventHandler(this.txtSoyadaGore_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(654, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 25);
            this.label2.TabIndex = 93;
            this.label2.Text = "Adrese Göre";
            // 
            // txtAdres
            // 
            this.txtAdres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdres.Location = new System.Drawing.Point(641, 46);
            this.txtAdres.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(169, 19);
            this.txtAdres.TabIndex = 3;
            this.txtAdres.TextChanged += new System.EventHandler(this.txtAdres_TextChanged);
            // 
            // frmMusteriSorgulama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(1010, 605);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.txtSoyadaGore);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTelefonaGore);
            this.Controls.Add(this.txtAdaGore);
            this.Controls.Add(this.lvMusteriGoruntuleme);
            this.Name = "frmMusteriSorgulama";
            this.Text = "Müşteri Sorgulama";
            this.Load += new System.EventHandler(this.frmMusteriSorgulama_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvMusteriGoruntuleme;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTelefonaGore;
        private System.Windows.Forms.TextBox txtAdaGore;
        private System.Windows.Forms.TextBox txtSoyadaGore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAdres;
    }
}