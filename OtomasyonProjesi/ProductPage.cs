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

namespace OtomasyonProjesi
{
    public partial class ProductPage : Form
    {
        public ProductPage()
        {
            InitializeComponent();
        }
        
        ProductsDal productsDAl = new ProductsDal();
        decimal Ttop;
        int abc;
        int Kilo;
        private void ListProducts()
        {
            using (OrderAutomationContext context = new OrderAutomationContext())
            {
               
                dgwProducts.DataSource = context.Products.ToList();
            }
        }
        private void ListProductsBySearch(string key)
        {
            using (OrderAutomationContext context = new OrderAutomationContext())
            {
                dgwProducts.DataSource = context.Products.Where(p => p.ProductName.ToLower().Contains(key.ToLower())).ToList();
            }
        }

        private void ListProductsByCategory(int categoryId)
        {
            using (OrderAutomationContext context = new OrderAutomationContext())
 
                dgwProducts.DataSource = context.Products.Where(p => p.CategoryId == categoryId).ToList();
            
        }
        private void ListCategories()
        {
            using (OrderAutomationContext context = new OrderAutomationContext())
            {
                cbxCategory.DataSource = context.Categories.ToList();
                cbxCategory.DisplayMember = "CategoryName";
                cbxCategory.ValueMember = "CategoryId";
            }
        }

        public string ko;
        private void Form1_Load(object sender, EventArgs e)
        {
            lblCustomer.Text=ko;
            ListProducts();
            productsDAl.Delete();
            ListCategories();

        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            if (lblOrderName.Items.Count == 0)
            {
                MessageBox.Show("Lütfen Bir Ürün Seçiniz...");
            }
            else
            {
                OrderPage form2 = new OrderPage();
                form2.Ttops =Convert.ToDouble( Ttop);
                form2.ToplamAğırlık = abc;
                form2.kullanıcı = ko;
                Ttop = 0;
                abc = 0;
                form2.Show();
                lblOrderWeight.Items.Clear();
                lblOrderName.Items.Clear();
            }

        }
      
        private void button1_Click(object sender, EventArgs e)
        {
            OrderDetail orderDetail = new OrderDetail();

            
            try
            {
                if (Convert.ToInt32(txtStockAmount.Text) == 0)
                {
                    MessageBox.Show("Lütfen Kilo Giriniz...");
                }
                else if ( Convert.ToInt32(txtStockAmount.Text) > Kilo)
                {
                    MessageBox.Show("Maalesef... Elimizde Bu Kadar Ürün Yok");
                }
               
                else { productsDAl.Add(new Orders
                {
                    ProductsName = txtProductName.Text,
                    ProducstWeight = Convert.ToInt32(txtStockAmount.Text),
                    ProductsTotal = Convert.ToDecimal(txtUnitPrice.Text) * Convert.ToInt32(txtStockAmount.Text),

                } ) ;

                    
                    productsDAl.WeightUpdate(new Product()
                        {
                            ProductId = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
                            ProductName = dgwProducts.CurrentRow.Cells[1].Value.ToString(),
                            CategoryId = Convert.ToInt32(dgwProducts.CurrentRow.Cells[2].Value),
                            UnitPrice = Convert.ToDecimal(dgwProducts.CurrentRow.Cells[3].Value),
                            StockAmount = Convert.ToInt32(dgwProducts.CurrentRow.Cells[4].Value) - Convert.ToInt32(txtStockAmount.Text),
                        });
                    
                    ListProducts();
                    abc += Convert.ToInt32(txtStockAmount.Text);
                    lblOrderName.Items.Add(txtProductName.Text );
                    lblOrderWeight.Items.Add(txtStockAmount.Text + "kg");
                    Ttop += Convert.ToDecimal(txtUnitPrice.Text) * Convert.ToDecimal(txtStockAmount.Text);
                    orderDetail.ToplamTutar(Ttop);
                    txtProductName.Clear();
                    txtUnitPrice.Clear();
                    txtStockAmount.Clear(); }
            }
            catch
            {
                MessageBox.Show("Lütfen Tüm Kutuların Dolu Olduğuna Emin Olun...");
            }
            
           

        }
       
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            txtProductName.Text = dgwProducts.CurrentRow.Cells[1].Value.ToString();
            txtUnitPrice.Text = dgwProducts.CurrentRow.Cells[3].Value.ToString();
            Kilo = Convert.ToInt32(dgwProducts.CurrentRow.Cells[4].Value);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ListProductsByCategory(Convert.ToInt32(cbxCategory.SelectedValue));
            }
            catch
            {

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string key = txtSearch.Text;
            if (string.IsNullOrEmpty(key))
            {
                ListProducts();
            }
            else { ListProductsBySearch(txtSearch.Text); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
