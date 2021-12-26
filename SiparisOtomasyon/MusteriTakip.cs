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
    public partial class MusteriTakip : System.Windows.Forms.Form
    {
        public MusteriTakip()
        {
            InitializeComponent();
        }

        private void MusteriTakip_Load(object sender, EventArgs e)
        {
            using (SiparisContext context = new SiparisContext())
            {
                dataGridView1.DataSource = context.Musteris.ToList();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
