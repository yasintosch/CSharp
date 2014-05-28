namespace PROTEKNO
{
    partial class Form_stok
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
            this.button_stok_ekle = new System.Windows.Forms.Button();
            this.button_stok_sil = new System.Windows.Forms.Button();
            this.button_stok_duzenle = new System.Windows.Forms.Button();
            this.button_stok_geri = new System.Windows.Forms.Button();
            this.button_stok_yenile = new System.Windows.Forms.Button();
            this.button_stok_mail = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_stok_ekle
            // 
            this.button_stok_ekle.Location = new System.Drawing.Point(452, 32);
            this.button_stok_ekle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_stok_ekle.Name = "button_stok_ekle";
            this.button_stok_ekle.Size = new System.Drawing.Size(108, 70);
            this.button_stok_ekle.TabIndex = 0;
            this.button_stok_ekle.Text = "EKLE";
            this.button_stok_ekle.UseVisualStyleBackColor = true;
            this.button_stok_ekle.Click += new System.EventHandler(this.button_stok_ekle_Click);
            // 
            // button_stok_sil
            // 
            this.button_stok_sil.Location = new System.Drawing.Point(180, 32);
            this.button_stok_sil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_stok_sil.Name = "button_stok_sil";
            this.button_stok_sil.Size = new System.Drawing.Size(108, 70);
            this.button_stok_sil.TabIndex = 1;
            this.button_stok_sil.Text = "SİL";
            this.button_stok_sil.UseVisualStyleBackColor = true;
            this.button_stok_sil.Click += new System.EventHandler(this.button_stok_sil_Click);
            // 
            // button_stok_duzenle
            // 
            this.button_stok_duzenle.Location = new System.Drawing.Point(319, 32);
            this.button_stok_duzenle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_stok_duzenle.Name = "button_stok_duzenle";
            this.button_stok_duzenle.Size = new System.Drawing.Size(108, 70);
            this.button_stok_duzenle.TabIndex = 2;
            this.button_stok_duzenle.Text = "DÜZENLE";
            this.button_stok_duzenle.UseVisualStyleBackColor = true;
            this.button_stok_duzenle.Click += new System.EventHandler(this.button_stok_duzenle_Click);
            // 
            // button_stok_geri
            // 
            this.button_stok_geri.Location = new System.Drawing.Point(1, 395);
            this.button_stok_geri.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_stok_geri.Name = "button_stok_geri";
            this.button_stok_geri.Size = new System.Drawing.Size(84, 28);
            this.button_stok_geri.TabIndex = 5;
            this.button_stok_geri.Text = "GERİ";
            this.button_stok_geri.UseVisualStyleBackColor = true;
            this.button_stok_geri.Click += new System.EventHandler(this.button_stok_geri_Click);
            // 
            // button_stok_yenile
            // 
            this.button_stok_yenile.Location = new System.Drawing.Point(583, 32);
            this.button_stok_yenile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_stok_yenile.Name = "button_stok_yenile";
            this.button_stok_yenile.Size = new System.Drawing.Size(108, 70);
            this.button_stok_yenile.TabIndex = 6;
            this.button_stok_yenile.Text = "YENİLE";
            this.button_stok_yenile.UseVisualStyleBackColor = true;
            this.button_stok_yenile.Click += new System.EventHandler(this.button_stok_yenile_Click);
            // 
            // button_stok_mail
            // 
            this.button_stok_mail.Location = new System.Drawing.Point(715, 32);
            this.button_stok_mail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_stok_mail.Name = "button_stok_mail";
            this.button_stok_mail.Size = new System.Drawing.Size(108, 70);
            this.button_stok_mail.TabIndex = 7;
            this.button_stok_mail.Text = "MAİL GÖNDER";
            this.button_stok_mail.UseVisualStyleBackColor = true;
            this.button_stok_mail.Click += new System.EventHandler(this.button_stok_mail_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(105, 138);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(783, 219);
            this.dataGridView1.TabIndex = 8;
            // 
            // Form_stok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 423);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_stok_mail);
            this.Controls.Add(this.button_stok_yenile);
            this.Controls.Add(this.button_stok_geri);
            this.Controls.Add(this.button_stok_duzenle);
            this.Controls.Add(this.button_stok_sil);
            this.Controls.Add(this.button_stok_ekle);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form_stok";
            this.Text = "STOK TAKİP";
            this.Load += new System.EventHandler(this.Form_stok_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_stok_ekle;
        private System.Windows.Forms.Button button_stok_sil;
        private System.Windows.Forms.Button button_stok_duzenle;
        private System.Windows.Forms.Button button_stok_geri;
        private System.Windows.Forms.Button button_stok_yenile;
        private System.Windows.Forms.Button button_stok_mail;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}