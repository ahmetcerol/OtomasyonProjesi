using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtomasyonProjesi
{
  
    public partial class PaymentPage : Form
    {
        public PaymentPage()
        {
            InitializeComponent();
        }
       
        public decimal OdecenekTutar;
        public int ToplamAğırlık;
        public string KullanıcıAdı;
        ProductsDal ProductsDAl = new ProductsDal();
        private void payment_Load(object sender, EventArgs e)
        {
            decimal kargo;
            lblCustomer.Text = KullanıcıAdı;
            kargo=Convert.ToDecimal(ToplamAğırlık)*75/100;
            lblCurrentCargoPrice.Text = kargo.ToString();
            lblCurrentTotalPayment.Text = (OdecenekTutar+kargo).ToString();
            lblCurrentTotalCargoWeight.Text = ToplamAğırlık.ToString();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            TasarımDahaKolayı();
        }
       
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (rtxtAddress.Text == "")
            {

                MessageBox.Show("Lütfen Gönderilecek Adresi Giriniz...");
            }
            else if (cbxPaymentMethod.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen Bir Ödeme Yöntemi Seçiniz...");
            }
            else if (cbxPaymentMethod.SelectedIndex == 1 && txtPayment1.Text == ""&& txtPayment2.Text=="" && txtPayment3.Text=="")
            {
                MessageBox.Show("Lütfen Kredi Kartı Bilgilerinizi Kontrol Ediniz...");
            }

            else if (cbxPaymentMethod.SelectedIndex==2 && txtPayment1.Text == "" && txtPayment2.Text == "")
            {
                MessageBox.Show("Lütfen Çek Bilgilerinizi Kontrol Ediniz...");
            }
            else
            {
                try
                {
                    if (txtPayment2.Text != "") Convert.ToInt32(txtPayment2.Text);
                    if (txtPayment3.Text!="") Convert.ToInt32(txtPayment3.Text);
                    this.Close();
                    ProductsDAl.Delete();

                    MessageBox.Show("Bizi Tercih Ettiğiniz İçin Teşekkür Ederiz..." + " \n" +
                        "Kargonuz En Kısa Sürede Elinizde Olacaktır");

                }
                catch
                {
                    MessageBox.Show("Lütfen Bilgilerinizi Doğru Giriniz...");
                }
              
              
            }
           
        }

        private void TasarımDahaKolayı()
        {
            if (cbxPaymentMethod.SelectedItem == cbxPaymentMethod.Items[0])
            {
                txtPayment1.Visible = false;
                txtPayment2.Visible = false;
                txtPayment3.Visible = false;
                label7.Visible = true;
                label9.Visible = true;
                label7.Text = "Kapıda Ödeme:";
                label9.Text = "------Sadece Nakit Kabul Edilir------";
                label10.Visible = false;


            }
            else if (cbxPaymentMethod.SelectedItem == cbxPaymentMethod.Items[1])
            {
                txtPayment1.Visible = true;
                txtPayment2.Visible = true;
                txtPayment3.Visible = true;
                label7.Visible = true;
                label7.Text = " Kart Sahibinin Adı:";
                label9.Text = "      Kart Numarası:";
                label10.Text = " Güvenlik Kodu(CVV):";
                label9.Visible = true;
                label10.Visible = true;
            }
            else
            {

                txtPayment1.Visible = true;
                txtPayment2.Visible = true;
                txtPayment3.Visible = false;
                label7.Visible = true;
                label9.Visible = true;
                label10.Visible = false;
                label7.Text = "Çek Sahibinin Adı:";
                label9.Text = "     Çek Numarası:";

            }
        }

        private void Tasarım()
        {
            if (cbxPaymentMethod.SelectedItem == cbxPaymentMethod.Items[0])
            {
                gbxPaymentMethod.Controls.Clear();
                PictureBox pictureBox18 = new PictureBox()
                {
                    Width = 45,
                    Height = 20,
                    Location = new Point(16, -1),
                    Image = Image.FromFile(@"C:\Users\hp\Desktop\OrderAutomation\OrderAutomationİmages\KapıdaÖdeme.png"),
                    Name = "görsel"
                };
                pictureBox18.SizeMode = PictureBoxSizeMode.StretchImage;
                gbxPaymentMethod.Controls.Add(pictureBox18);
                Label lbl5 = new Label();
                gbxPaymentMethod.Controls.Add(lbl5);
                lbl5.AutoSize = true;
                lbl5.Text = "Kapıda Ödeme:";
                lbl5.Font = new Font("Times New Roman", 10, FontStyle.Bold);
                lbl5.ForeColor = System.Drawing.Color.White;
                lbl5.Location = new Point(39, 38);

                Label lbl6 = new Label();
                gbxPaymentMethod.Controls.Add(lbl6);
                lbl6.AutoSize = true;
                lbl6.Text = "Kapıda Ödemeyi Sadece Nakit ile Yapabilirsiniz!!!";
                lbl6.Font = new Font("Times New Roman", 10, FontStyle.Bold);
                lbl6.ForeColor = System.Drawing.Color.White;
                lbl6.Location = new Point(39, 64);

            }

            else if (cbxPaymentMethod.SelectedItem == cbxPaymentMethod.Items[1])
            {
                gbxPaymentMethod.Controls.Clear();
                Label lbl1 = new Label();
                PictureBox pictureBox18 = new PictureBox()
                {
                    Width = 45,
                    Height = 20,
                    Location = new Point(16, -1),
                    Image = Image.FromFile(@"C:\Users\hp\Desktop\OrderAutomation\OrderAutomationİmages\KrediKartı.png"),
                    Name = "görsel"
                };
                pictureBox18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                gbxPaymentMethod.Controls.Add(pictureBox18);
                gbxPaymentMethod.Controls.Add(lbl1);
                lbl1.AutoSize = true;
                lbl1.Text = "Kart Sahibinin Adı:";
                lbl1.Font = new Font("Times New Roman", 10, FontStyle.Bold);
                lbl1.ForeColor = System.Drawing.Color.White;
                lbl1.Location = new Point(39, 38);


                Label lbl2 = new Label();
                gbxPaymentMethod.Controls.Add(lbl2);
                lbl2.AutoSize = true;
                lbl2.Font = new Font("Times New Roman", 10, FontStyle.Bold);
                lbl2.ForeColor = System.Drawing.Color.White;
                lbl2.Text = "Kart Numarası:";
                lbl2.Location = new Point(39, 69);

                Label lbl3 = new Label();
                gbxPaymentMethod.Controls.Add(lbl3);
                lbl3.AutoSize = true;
                lbl3.Font = new Font("Times New Roman", 10, FontStyle.Bold);
                lbl3.ForeColor = System.Drawing.Color.White;
                lbl3.Text = "Güvenlik Kodu:";
                lbl3.Location = new Point(39, 98);

                TextBox txt1 = new TextBox();
                gbxPaymentMethod.Controls.Add(txt1);
                txt1.Location = new Point(196, 35);


                TextBox txt2 = new TextBox();
                gbxPaymentMethod.Controls.Add(txt2);
                txt2.Location = new Point(196, 65);


                TextBox txt3 = new TextBox();
                gbxPaymentMethod.Controls.Add(txt3);
                txt3.Location = new Point(196, 95);


            }
            else
            {
                gbxPaymentMethod.Controls.Clear();
                Label lbl1 = new Label();
                PictureBox pictureBox18 = new PictureBox()
                {
                    Width = 45,
                    Height = 20,
                    Location = new Point(16, -1),
                    Image = Image.FromFile(@"C:\Users\hp\Desktop\OrderAutomation\OrderAutomationİmages\Çek.png"),
                    Name = "görsel"
                };
                pictureBox18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                gbxPaymentMethod.Controls.Add(pictureBox18);
                Label lbl5 = new Label();
                gbxPaymentMethod.Controls.Add(lbl5);
                lbl5.AutoSize = true;
                lbl5.Text = "Çek Sahibinin Adı:";
                lbl5.Font = new Font("Times New Roman", 10, FontStyle.Bold);
                lbl5.ForeColor = System.Drawing.Color.White;
                lbl5.Location = new Point(39, 38);


                Label lbl2 = new Label();
                gbxPaymentMethod.Controls.Add(lbl2);
                lbl2.AutoSize = true;
                lbl2.Font = new Font("Times New Roman", 10, FontStyle.Bold);
                lbl2.ForeColor = System.Drawing.Color.White;
                lbl2.Text = "Çek Numarası:";
                lbl2.Location = new Point(39, 69);

                TextBox txt1 = new TextBox();
                gbxPaymentMethod.Controls.Add(txt1);
                txt1.Location = new Point(196, 35);


                TextBox txt2 = new TextBox();
                gbxPaymentMethod.Controls.Add(txt2);
                txt2.Location = new Point(196, 65);


            }
        }
    }
}
