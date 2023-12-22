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
    public class EfHareketlerDal : GenericRepository<Hareketler>, IHareketlerDal
    {

        //List<Hareketler> GetListParameterHareketler(int id)
        //{
        //    using (var c = new Context())
        //    {
        //        return c.Hareketlers.Include(x => x.Platform).Include(y => y.Oyunlar).Include(z => z.Firmalar).Where(x => x.Oyunlar.OyunID == id).ToList();
        //    }
        //}
        public List<Hareketler> GetListByParameterHareket(int id)
        {
            using(var c=new Context())
            {
                return c.Hareketlers.Include(x => x.Platform).Include(y => y.Oyunlar).Include(z => z.Firmalar).Where(x => x.Oyunlar.OyunID == id).ToList();
            }
           
        }
    }
}
