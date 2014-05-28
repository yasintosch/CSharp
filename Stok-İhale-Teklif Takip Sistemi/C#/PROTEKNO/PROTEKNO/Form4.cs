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
    public partial class Form_stok_sil : Form
    {

      
        public Form_stok frm_sil;
        public Form_stok_sil()
        {
            InitializeComponent();
        }

        Form_stok frm_stok = new Form_stok();
        SqlConnection conprotekno = new SqlConnection("initial catalog=PROTEKNO;data source=localhost;integrated security=sspi;packet size=4096");
        private void button_stok_sil_onay_Click(object sender, EventArgs e)
        { 

           

            
            try
          {


             
                
              if (textBox_stok_sil.Text != null)
              {
                  if (conprotekno.State == ConnectionState.Closed)
                  {
                      conprotekno.Open();

                  SqlCommand cmdsil = new SqlCommand("URUN_SIL", conprotekno);

                  cmdsil.CommandType = CommandType.StoredProcedure;
                  SqlParameter paramkod = cmdsil.Parameters.Add("@u_kodu", SqlDbType.Int);

                  paramkod.Value = textBox_stok_sil.Text;
                  cmdsil.ExecuteNonQuery();
                  conprotekno.Close();
                  MessageBox.Show("Basarili");
                  }
                 
              }
            
           }
                catch
            {
                MessageBox.Show("Hata", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conprotekno.Close();
            }
            
            
        }

        private void button_stok_sil_geri_Click(object sender, EventArgs e)
        {

           
            frm_stok.Show();
            this.Close();

        }

        private void Form_stok_sil_Load(object sender, EventArgs e)
        {
            textBox_stok_sil.Text = frm_sil.dataGridView1.CurrentRow.Cells[1].Value.ToString();

        }
     }
  }

