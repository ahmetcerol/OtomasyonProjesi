using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiparisOtomasyon
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminGiris admin = new AdminGiris();
            admin.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MusteriKaydol musteriKaydol = new MusteriKaydol();
            musteriKaydol.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            MusteriGiris musteriGiris = new MusteriGiris();
            musteriGiris.Show();
        }
    }
}
