namespace PROTEKNO
{
    partial class Form_giris
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
            this.button_stok = new System.Windows.Forms.Button();
            this.button_ihale = new System.Windows.Forms.Button();
            this.button_yardim = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_stok
            // 
            this.button_stok.Location = new System.Drawing.Point(193, 120);
            this.button_stok.Name = "button_stok";
            this.button_stok.Size = new System.Drawing.Size(118, 75);
            this.button_stok.TabIndex = 0;
            this.button_stok.Text = "STOK";
            this.button_stok.UseVisualStyleBackColor = true;
            this.button_stok.Click += new System.EventHandler(this.button_stok_Click);
            // 
            // button_ihale
            // 
            this.button_ihale.Location = new System.Drawing.Point(382, 120);
            this.button_ihale.Name = "button_ihale";
            this.button_ihale.Size = new System.Drawing.Size(116, 75);
            this.button_ihale.TabIndex = 1;
            this.button_ihale.Text = "İHALELER";
            this.button_ihale.UseVisualStyleBackColor = true;
            // 
            // button_yardim
            // 
            this.button_yardim.Location = new System.Drawing.Point(1, 319);
            this.button_yardim.Name = "button_yardim";
            this.button_yardim.Size = new System.Drawing.Size(63, 23);
            this.button_yardim.TabIndex = 3;
            this.button_yardim.Text = "YARDIM";
            this.button_yardim.UseVisualStyleBackColor = true;
            // 
            // Form_giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 342);
            this.Controls.Add(this.button_yardim);
            this.Controls.Add(this.button_ihale);
            this.Controls.Add(this.button_stok);
            this.Name = "Form_giris";
            this.Text = "STOK VE İHALE TAKİP";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_stok;
        private System.Windows.Forms.Button button_ihale;
        private System.Windows.Forms.Button button_yardim;
    }
}

