using OtomasyonProjesi;
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
    public partial class UrunIslem : System.Windows.Forms.Form
    {
        public UrunIslem()
        {
            InitializeComponent();
        }
        ProductsDal productsDAl = new ProductsDal();
        private void UrunIslem_Load(object sender, EventArgs e)
        {
            LoadUrun();
        }

        private void LoadUrun()
        {
            using (OrderAutomationContext context = new OrderAutomationContext())
            {
                dataGridView1.DataSource = context.Products.ToList();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            productsDAl.ProductAdd(new Product()
            {
               ProductName=textBox1.Text,
               UnitPrice=Convert.ToDecimal(textBox2.Text),
               CategoryId=Convert.ToInt32(textBox7.Text),
               StockAmount=Convert.ToInt32(textBox3.Text)
            });
            LoadUrun();
            MessageBox.Show("Eklendi!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            productsDAl.ProductUpdate(new Product() 
            { 
               ProductId=Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value),
               ProductName=textBox4.Text,
               CategoryId=Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value),
               UnitPrice=Convert.ToDecimal(textBox5.Text),
               StockAmount=Convert.ToInt32(textBox6.Text)
           });
            LoadUrun();
            MessageBox.Show("Güncellendi!");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox4.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            productsDAl.ProductDelete(new Product { 
             ProductId=Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value)
            });
            LoadUrun();
            MessageBox.Show("Silindi!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
