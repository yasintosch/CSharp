namespace PROTEKNO
{
    partial class Form_stok_sil
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
            this.textBox_stok_sil = new System.Windows.Forms.TextBox();
            this.button_stok_sil_geri = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button_stok_sil_onay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Kodu";
            // 
            // textBox_stok_sil
            // 
            this.textBox_stok_sil.Location = new System.Drawing.Point(112, 50);
            this.textBox_stok_sil.Name = "textBox_stok_sil";
            this.textBox_stok_sil.Size = new System.Drawing.Size(100, 20);
            this.textBox_stok_sil.TabIndex = 1;
            // 
            // button_stok_sil_geri
            // 
            this.button_stok_sil_geri.Location = new System.Drawing.Point(1, 237);
            this.button_stok_sil_geri.Name = "button_stok_sil_geri";
            this.button_stok_sil_geri.Size = new System.Drawing.Size(55, 23);
            this.button_stok_sil_geri.TabIndex = 2;
            this.button_stok_sil_geri.Text = "GERİ";
            this.button_stok_sil_geri.UseVisualStyleBackColor = true;
            this.button_stok_sil_geri.Click += new System.EventHandler(this.button_stok_sil_geri_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(162, 156);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "İPTAL";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button_stok_sil_onay
            // 
            this.button_stok_sil_onay.Location = new System.Drawing.Point(40, 156);
            this.button_stok_sil_onay.Name = "button_stok_sil_onay";
            this.button_stok_sil_onay.Size = new System.Drawing.Size(75, 23);
            this.button_stok_sil_onay.TabIndex = 4;
            this.button_stok_sil_onay.Text = "ONAY";
            this.button_stok_sil_onay.UseVisualStyleBackColor = true;
            this.button_stok_sil_onay.Click += new System.EventHandler(this.button_stok_sil_onay_Click);
            // 
            // Form_stok_sil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button_stok_sil_onay);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button_stok_sil_geri);
            this.Controls.Add(this.textBox_stok_sil);
            this.Controls.Add(this.label1);
            this.Name = "Form_stok_sil";
            this.Text = "STOK TAKİP/SİL";
            this.Load += new System.EventHandler(this.Form_stok_sil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_stok_sil;
        private System.Windows.Forms.Button button_stok_sil_geri;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button_stok_sil_onay;
    }
}