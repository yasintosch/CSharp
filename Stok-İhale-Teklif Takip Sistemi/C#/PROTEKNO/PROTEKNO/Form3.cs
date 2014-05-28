using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PROTEKNO
{
    public partial class Form_stok_ekle : Form
    {
        public Form_stok_ekle()
        {
            InitializeComponent();
        }

        private void button_stok_ekle_geri_Click(object sender, EventArgs e)
        {
            this.Close();
            Form stok = new Form_stok();
            stok.Show();
        }

        SqlConnection conprotekno = new SqlConnection("initial catalog=PROTEKNO;data source=localhost;integrated security=sspi;packet size=4096");

        private void button_stok_ekle_onay_Click(object sender, EventArgs e)
        {

            conprotekno.Open();
            try
            {
                SqlCommand cmdinsert = new SqlCommand("URUN_EKLE", conprotekno);

                cmdinsert.CommandType = CommandType.StoredProcedure;

                SqlParameter paramkod = cmdinsert.Parameters.Add("@u_kodu", SqlDbType.Int);
                SqlParameter paramad = cmdinsert.Parameters.Add("@u_ad", SqlDbType.NVarChar, 100);
                SqlParameter parammarka = cmdinsert.Parameters.Add("@u_marka", SqlDbType.NVarChar, 100);
                SqlParameter paramkategori = cmdinsert.Parameters.Add("@u_kategori", SqlDbType.NVarChar, 100);
                SqlParameter paraaciklama = cmdinsert.Parameters.Add("@u_aciklama", SqlDbType.NVarChar, 100);
                SqlParameter paramadet = cmdinsert.Parameters.Add("@u_adet", SqlDbType.Int);
                SqlParameter paramtarih = cmdinsert.Parameters.Add("@u_alindigi_tarih", SqlDbType.DateTime);
                SqlParameter paramfirma = cmdinsert.Parameters.Add("@u_alindigi_firma", SqlDbType.NVarChar, 100);
                SqlParameter paramadres = cmdinsert.Parameters.Add("@u_alindigi_firma_adres", SqlDbType.NVarChar, 100);
                SqlParameter paramtelefon = cmdinsert.Parameters.Add("@u_alindigi_firma_tel", SqlDbType.NVarChar, 100);
                SqlParameter paramfiyat = cmdinsert.Parameters.Add("@u_fiyat", SqlDbType.Int);



                paramkod.Value = textBox_stok_ekle_urunkodu.Text;
                paramad.Value = textBox_stok_ekle_urunadi.Text;
                parammarka.Value = textBox_stok_ekle_marka.Text;
                paramkategori.Value = textBox_stok_ekle_kategori.Text;
                paraaciklama.Value = textBox_stok_ekle_aciklama.Text;
                paramadet.Value = textBox_stok_ekle_adet.Text;
                paramtarih.Value = dateTimePicker1.Value;
                paramfirma.Value = textBox_stok_ekle_firma.Text;
                paramadres.Value = textBox_stok_ekle_adres.Text;
                paramtelefon.Value = textBox_stok_ekle_tel.Text;
                paramfiyat.Value = textBox_stok_ekle_fiyat.Text;


                cmdinsert.ExecuteNonQuery();
                conprotekno.Close();
                MessageBox.Show("Basarili");
            }
            catch
            {
                MessageBox.Show("Hata", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conprotekno.Close();
            }
            
        }

        private void Form_stok_ekle_Load(object sender, EventArgs e)
        {

        }
    }
}
