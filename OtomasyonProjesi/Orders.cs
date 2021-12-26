using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtomasyonProjesi
{
   public class Orders
    {

        public string ProductsName { get; set; }
        public int ProducstWeight { get; set; }
        public decimal ProductsTotal { get; set; }
        
    }

    public class OrderDetail:Orders
    {
        public decimal ToplamTutarr { get; set; }
        public decimal ToplamTutar(decimal toplamTutarr)
        {
            decimal toplamTutar = 0;
            toplamTutar += ProductsTotal;
            return toplamTutar;
        }
    }
}
