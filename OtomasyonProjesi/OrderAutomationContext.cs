﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtomasyonProjesi
{
   
    public class OrderAutomationContext:DbContext
    {  
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
     
    }
}
