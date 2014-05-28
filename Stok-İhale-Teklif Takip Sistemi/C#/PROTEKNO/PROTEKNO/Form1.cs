using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROTEKNO
{
    public partial class Form_giris : Form
    {
        public Form_giris()
        {
            InitializeComponent();
        }

        private void button_stok_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form stok = new Form_stok();
            stok.Show();
            
        }
    }
}
