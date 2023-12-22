using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfOyunlarDal : GenericRepository<Oyunlar>, IOyunlarDal
    {
        public List<Oyunlar> GetListWithCategoryPlatform()
        {

            using (var c = new Context())
            {
                return c.Oyunlars.Include(x => x.Category).Include(y=>y.Platform).ToList();
            }
  
        }

        public List<Oyunlar> GetSearchListByFilter(string p)
        {
            using (var c = new Context())
            {
                return c.Oyunlars.Include(x => x.Category).Include(y => y.Platform).Where(x => x.OyunAd.Contains(p)).ToList();
            }
        }
    }
}
