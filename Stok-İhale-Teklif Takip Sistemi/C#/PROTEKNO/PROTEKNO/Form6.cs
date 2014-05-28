using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Timers;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace PROTEKNO
{
    public partial class Form_stok_duzenle : Form
    {

        public Form_stok frm_dzn;
        public Form_stok_duzenle()

        {
            InitializeComponent();
            
        }
        


        private void Form_stok_duzenle_Load(object sender, EventArgs e)
        {
            +textBox_stok_duzenle_urunkodu.Text = frm_dzn.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox_stok_duzenle_urunadi.Text = frm_dzn.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox_stok_duzenle_marka.Text = frm_dzn.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox_stok_duzenle_kategori.Text = frm_dzn.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox_stok_duzenle_aciklama.Text = frm_dzn.dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox_stok_duzenle_adet.Text = frm_dzn.dataGridView1.CurrentRow.Cells[6].Value.ToString();
           
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = frm_dzn.dataGridView1.CurrentRow.Cells[7].Value.ToString();
            textBox_stok_duzenle_firma.Text = frm_dzn.dataGridView1.CurrentRow.Cells[8].Value.ToString();
            textBox_stok_duzenle_adres.Text = frm_dzn.dataGridView1.CurrentRow.Cells[9].Value.ToString();
            textBox_stok_duzenle_tel.Text = frm_dzn.dataGridView1.CurrentRow.Cells[10].Value.ToString();
            textBox_stok_duzenle_fiyat.Text = frm_dzn.dataGridView1.CurrentRow.Cells[11].Value.ToString();
            
            
            //datagridview'de seçili satırı gerekli textboxlara yazdırıyoruz.Form3 açıldğında bilgiler otomatik textboxlara yazılmış oluyor.

            
        }
        SqlConnection conprotekno = new SqlConnection("initial catalog=PROTEKNO;data source=localhost;integrated security=sspi;packet size=4096");
        private void button_stok_duzenle_onay_Click(object sender, EventArgs e)
        {  
            if(conprotekno.State==ConnectionState.Closed)
            conprotekno.Open();
            try
            {
                SqlCommand cmdinsert = new SqlCommand("URUN_DUZENLE", conprotekno);

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



                paramkod.Value = textBox_stok_duzenle_urunkodu.Text;
                paramad.Value = textBox_stok_duzenle_urunadi.Text;
                parammarka.Value = textBox_stok_duzenle_marka.Text;
                paramkategori.Value = textBox_stok_duzenle_kategori.Text;
                paraaciklama.Value = textBox_stok_duzenle_aciklama.Text;
                paramadet.Value = textBox_stok_duzenle_adet.Text;
                paramtarih.Value = dateTimePicker1.Value;
                paramfirma.Value = textBox_stok_duzenle_firma.Text;
                paramadres.Value = textBox_stok_duzenle_adres.Text;
                paramtelefon.Value = textBox_stok_duzenle_tel.Text;
                paramfiyat.Value = textBox_stok_duzenle_fiyat.Text;


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

        private void button_stok_duzenle_geri_Click(object sender, EventArgs e)
        {


            this.Close();
            Form stok = new Form_stok();
            stok.Show();
           

          //  frm_dzn.Show();
          //  this.Hide();
            

         
        }
    }
}
