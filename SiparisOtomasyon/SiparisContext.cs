using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisOtomasyon
{
    public class SiparisContext:DbContext
    {
        public DbSet<Musteri> Musteris { get; set; }
        public DbSet<Admin> Admins { get; set; }
    }
}
