using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
   public interface IHareketlerDal: IGenericDal<Hareketler>
    {
        List<Hareketler> GetListByParameterHareket(int id);
        //Hareketler GetByParameterHareketler(int id);
    }
}
