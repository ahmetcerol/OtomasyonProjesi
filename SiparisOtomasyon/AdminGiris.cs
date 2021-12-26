using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiparisOtomasyon
{
    public partial class AdminGiris : System.Windows.Forms.Form
    {
        public AdminGiris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"server=(localdb)\MSSQLLocalDB;initial catalog=OrderAutomation;integrated security=true");

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                string sql = "Select * From Admins where KullaniciAdi=@adi AND Sifre=@sifresi";
                SqlParameter prm1 = new SqlParameter("adi", textBox1.Text);
                SqlParameter prm2 = new SqlParameter("sifresi", textBox2.Text);
                SqlCommand komut = new SqlCommand(sql, baglanti);
                komut.Parameters.Add(prm1);
                komut.Parameters.Add(prm2);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    AdminIslem adminIslem = new AdminIslem();
                    adminIslem.Show();
                    this.Hide();
                    baglanti.Close();
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Hatalı");
                baglanti.Close();
            }
        }
    }
}
