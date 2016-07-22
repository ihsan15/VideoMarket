namespace VideoMarket1
{
    partial class frmSatisSorgulama
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
            this.dgvDetayliSatis = new System.Windows.Forms.DataGridView();
            this.dtpTarih1 = new System.Windows.Forms.DateTimePicker();
            this.dtpTarih2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGetir = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtToplamTutar = new System.Windows.Forms.TextBox();
            this.txtToplamAdet = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetayliSatis)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDetayliSatis
            // 
            this.dgvDetayliSatis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetayliSatis.Location = new System.Drawing.Point(12, 181);
            this.dgvDetayliSatis.Name = "dgvDetayliSatis";
            this.dgvDetayliSatis.RowTemplate.Height = 24;
            this.dgvDetayliSatis.Size = new System.Drawing.Size(982, 468);
            this.dgvDetayliSatis.TabIndex = 0;
            // 
            // dtpTarih1
            // 
            this.dtpTarih1.Location = new System.Drawing.Point(170, 80);
            this.dtpTarih1.Name = "dtpTarih1";
            this.dtpTarih1.Size = new System.Drawing.Size(136, 22);
            this.dtpTarih1.TabIndex = 1;
            // 
            // dtpTarih2
            // 
            this.dtpTarih2.Location = new System.Drawing.Point(579, 80);
            this.dtpTarih2.Name = "dtpTarih2";
            this.dtpTarih2.Size = new System.Drawing.Size(137, 22);
            this.dtpTarih2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(195, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "ilk Tarih";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(603, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Son Tarih";
            // 
            // btnGetir
            // 
            this.btnGetir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGetir.Location = new System.Drawing.Point(376, 126);
            this.btnGetir.Name = "btnGetir";
            this.btnGetir.Size = new System.Drawing.Size(134, 31);
            this.btnGetir.TabIndex = 5;
            this.btnGetir.Text = "Satışları Getir";
            this.btnGetir.UseVisualStyleBackColor = true;
            this.btnGetir.Click += new System.EventHandler(this.btnGetir_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(779, 669);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 20);
            this.label9.TabIndex = 65;
            this.label9.Text = "Toplam Tutar :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(552, 669);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 20);
            this.label8.TabIndex = 64;
            this.label8.Text = "Toplam Adet :";
            // 
            // txtToplamTutar
            // 
            this.txtToplamTutar.Enabled = false;
            this.txtToplamTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtToplamTutar.Location = new System.Drawing.Point(923, 666);
            this.txtToplamTutar.Name = "txtToplamTutar";
            this.txtToplamTutar.Size = new System.Drawing.Size(69, 26);
            this.txtToplamTutar.TabIndex = 63;
            this.txtToplamTutar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtToplamAdet
            // 
            this.txtToplamAdet.Enabled = false;
            this.txtToplamAdet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtToplamAdet.Location = new System.Drawing.Point(688, 666);
            this.txtToplamAdet.Name = "txtToplamAdet";
            this.txtToplamAdet.Size = new System.Drawing.Size(69, 26);
            this.txtToplamAdet.TabIndex = 62;
            this.txtToplamAdet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmSatisSorgulama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1006, 709);
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
            this.Name = "frmSatisSorgulama";
            this.Text = "Satış Sorgulama";
            this.Load += new System.EventHandler(this.frmSatisSorgulama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetayliSatis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDetayliSatis;
        private System.Windows.Forms.DateTimePicker dtpTarih1;
        private System.Windows.Forms.DateTimePicker dtpTarih2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGetir;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtToplamTutar;
        private System.Windows.Forms.TextBox txtToplamAdet;
    }
}