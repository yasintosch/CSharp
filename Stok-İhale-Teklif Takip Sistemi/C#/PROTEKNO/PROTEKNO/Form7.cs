using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace PROTEKNO
{
    public partial class Form_stok_mail : Form
    {
        public Form_stok_mail()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog rs = new OpenFileDialog();
            rs.Filter = " Bütün Dosyalar|*.*";
            rs.Title = "Eklenecek Dosyayı seçin";
            rs.ShowDialog();
            textBox5.Text = rs.FileName.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           try {
               MailMessage mesaj = new MailMessage();
               mesaj.From = new MailAddress(textBox1.Text,"PROTEKNO",System.Text.Encoding.UTF8);
               SmtpClient smtp = new SmtpClient();
               mesaj.To.Add(textBox2.Text);
               mesaj.Subject = textBox4.Text;
               mesaj.IsBodyHtml=false; 
               mesaj.BodyEncoding = System.Text.Encoding.UTF8;
               mesaj.Body = richTextBox1.Text;
               mesaj.Priority = MailPriority.High;
               mesaj.Attachments.Add(new Attachment(textBox5.Text)); // Ek olarak dosya eklemek için kullanılabilir.

smtp.Credentials = new System.Net.NetworkCredential(textBox1.Text, textBox3.Text);
smtp.Port = 587;
smtp.Host = "smtp.gmail.com";
smtp.EnableSsl = true;
smtp.Send(mesaj);
MessageBox.Show("GÖNDERİLDİ...");
}
catch (Exception ex) { MessageBox.Show(ex.Message.ToString()); }
        }

        private void button_stok_mail_geri_Click(object sender, EventArgs e)
        {
            this.Close();
            Form stok = new Form_stok();
            stok.Show();
        }
    }
}
