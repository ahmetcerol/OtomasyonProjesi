using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisOtomasyon
{
    public class MusteriDal
    {
        public List<Musteri> GetAll()
        {
            using (SiparisContext context = new SiparisContext())
            {
                return context.Musteris.ToList();
            }
        }
        public void Add(Musteri musteri)
        {
            using (SiparisContext context = new SiparisContext())
            {
                var entity = context.Entry(musteri);
                entity.State = System.Data.Entity.EntityState.Added;
                context.SaveChanges();
            }
        }

    }
}
