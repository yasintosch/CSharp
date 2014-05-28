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
    public partial class Form_stok : Form
    {
        public Form_stok_duzenle frm_stk;

        public Form_stok()
        {
            InitializeComponent();
            frm_stk = new Form_stok_duzenle();
           

            frm_stk.frm_dzn = this;

        }
        SqlConnection conprotekno = new SqlConnection("initial catalog=PROTEKNO;data source=localhost;integrated security=sspi;packet size=4096");

        void refresh_table()
        {
            if (conprotekno.State == ConnectionState.Closed)
                conprotekno.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM URUNLER", conprotekno);


            SqlDataAdapter adp = new SqlDataAdapter(cmd);

            DataTable dtable = new DataTable();

            adp.Fill(dtable);

            dataGridView1.DataSource = dtable;
        }

        private void button_stok_geri_Click(object sender, EventArgs e)
        {
            this.Close();
            Form giris = new Form_giris();
            giris.Show();
        }

        private void button_stok_ekle_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form stok_ekle = new Form_stok_ekle();
            stok_ekle.Show();
        }

        private void Form_stok_Load(object sender, EventArgs e)
        {
            refresh_table();

            dataGridView1.Columns[0].Visible = false;

            dataGridView1.Columns[1].HeaderText = "Ürün Kodu";

            dataGridView1.Columns[2].HeaderText = "Ürün Adı";

            dataGridView1.Columns[3].HeaderText = "Marka";

            dataGridView1.Columns[4].HeaderText = "Kategori";

            dataGridView1.Columns[5].HeaderText = "Açıklama";

            dataGridView1.Columns[6].HeaderText = "Adet";

            dataGridView1.Columns[7].HeaderText = "Alındığı Tarih";

            dataGridView1.Columns[8].HeaderText = "Alındığı Firma";

            dataGridView1.Columns[9].HeaderText = "Firma Adresi";

            dataGridView1.Columns[10].HeaderText = "Firma Telefon";

            dataGridView1.Columns[11].HeaderText = "Fiyat";

        }

        private void button_stok_duzenle_Click(object sender, EventArgs e)
        {
            
           // frm_stk.Show();
           // this.Hide();

            this.Hide();
            Form_stok_duzenle stok_duzenle = new Form_stok_duzenle();
            stok_duzenle.Show();
            
        }

        private void button_stok_sil_Click(object sender, EventArgs e)
        {
            
                try
                {

                    DialogResult cevap;

                    cevap = MessageBox.Show("Kaydı silmek istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (cevap == DialogResult.Yes)
                    {
                        if (conprotekno.State == ConnectionState.Closed)
                            conprotekno.Open();
                        SqlCommand cmdsil = new SqlCommand("URUN_SIL", conprotekno);
                        cmdsil.CommandType = CommandType.StoredProcedure;
                        SqlParameter paramkod = cmdsil.Parameters.Add("@u_kodu", SqlDbType.Int);
                        paramkod.Value = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                        cmdsil.ExecuteNonQuery();
                        MessageBox.Show("Basarili");
                        refresh_table(); 

                    }

                }

                catch (Exception hata)
                {
                    MessageBox.Show(hata.Message);
                }

            }

        private void button_stok_mail_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frmgon = new Form_stok_mail();
            frmgon.Show();
        }

        private void button_stok_yenile_Click(object sender, EventArgs e)
        {
            refresh_table();
        }
        }
    }

