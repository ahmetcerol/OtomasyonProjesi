using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtomasyonProjesi
{
    public partial class OrderPage : Form
    {
        public OrderPage()
        {
            InitializeComponent();
        }
        ProductsDal productsDAl = new ProductsDal();
        public double Ttops;
        public decimal toplamTutar;
        public int ToplamAğırlık;
        public string kullanıcı;
        private void Form2_Load(object sender, EventArgs e)
        {
            lblCustomer.Text = kullanıcı;
            lblCurrentTotal.Text = Ttops.ToString();
            lblCurrentTax.Text = (Ttops * 0.05).ToString();
            toplamTutar = Convert.ToDecimal(lblCurrentTotal.Text) + Convert.ToDecimal(lblCurrentTax.Text);
            lblCurrentOrderTotal.Text = toplamTutar.ToString();
            dgwOrders.DataSource = productsDAl.GetAll();
        }
        private void ListProducts()
        {
            using (OrderAutomationContext context = new OrderAutomationContext())
            {
                dgwOrders.DataSource = context.Products.ToList();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            PaymentPage payment= new PaymentPage();
            payment.OdecenekTutar = toplamTutar;
            payment.KullanıcıAdı = kullanıcı;
            payment.ToplamAğırlık = ToplamAğırlık;
            payment.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            productsDAl.Delete();
            Ttops = 0;
            this.Close();
            MessageBox.Show("Sepetiniz Sıfırlanmıştır....");
            
        }
    }
}
