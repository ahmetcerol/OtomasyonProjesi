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
    public partial class MusteriKaydol : System.Windows.Forms.Form
    {
        public MusteriKaydol()
        {
            InitializeComponent();
        }
        MusteriDal _musteriDal = new MusteriDal();
        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == ""
                || textBox5.Text == "") { MessageBox.Show("Lütfen Tüm Kutuları Doldurunuz..."); }
            else
            {
                _musteriDal.Add(new Musteri()
                {
                    Ad = textBox1.Text,
                    Soyad = textBox2.Text,
                    Adres = textBox3.Text,
                    KullaniciAdi = textBox4.Text,
                    Sifre = textBox5.Text

                });
                this.Close();
                MessageBox.Show("Kayıt başarılı!");
            }
        }
    }
}
