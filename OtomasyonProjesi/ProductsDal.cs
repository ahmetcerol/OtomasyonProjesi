using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtomasyonProjesi
{
    public class ProductsDal
    {
        SqlConnection aconnection = new SqlConnection
           (@"server=(localdb)\mssqllocaldb; initial catalog=OrderAutomation; integrated security=true");
        private void ConnectionControl()
        {
            if (aconnection.State == ConnectionState.Closed)
            {
                aconnection.Open();
            }
        }
     
        public List<Orders> GetAll()
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Select ProductsName,ProductsWeight,ProductsTotal from Orders ", aconnection);
            SqlDataReader reader = command.ExecuteReader();
            List<Orders> products = new List<Orders>();
            while (reader.Read())
            {
                Orders product = new Orders
                {
                    ProductsName = reader["ProductsName"].ToString(),
                    ProducstWeight = Convert.ToInt32(reader["ProductsWeight"]),
                    ProductsTotal = Convert.ToDecimal(reader["ProductsTotal"]),
                };
                products.Add(product);

            }
            reader.Close();
            aconnection.Close();

            return products;

        }
     
        public void Add(Orders product)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand(
                "Insert into Orders values(@ProductsName,@ProductsWeight,@ProductsTotal)", aconnection);
            command.Parameters.AddWithValue("@ProductsName", product.ProductsName);
            command.Parameters.AddWithValue("@ProductsWeight", product.ProducstWeight);
            command.Parameters.AddWithValue("@ProductsTotal", product.ProductsTotal);
            command.ExecuteNonQuery();
          
            aconnection.Close();
        }

        public void Delete()
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand(
                "Delete from Orders", aconnection);
            command.ExecuteNonQuery();
            aconnection.Close();
        }

        public void ProductAdd(Product urun)
        {
            using (OrderAutomationContext context = new OrderAutomationContext())
            {
                var entity = context.Entry(urun);
                entity.State = System.Data.Entity.EntityState.Added;
                context.SaveChanges();
            }
        }
        public void ProductUpdate(Product product)
        {
            using (OrderAutomationContext context = new OrderAutomationContext())
            {
                var entity = context.Entry(product);
                entity.State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void WeightUpdate(Product product)
        {
            using (OrderAutomationContext context = new OrderAutomationContext())
            {
                var entity = context.Entry(product);
                entity.State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void ProductDelete(Product urun)
        {
            using (OrderAutomationContext context = new OrderAutomationContext())
            {
                var entity = context.Entry(urun);
                entity.State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }

}

