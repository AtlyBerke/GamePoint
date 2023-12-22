using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
   public interface IOyunlarBl:IGenericBl<Oyunlar>
    {
        List<Oyunlar> TGetListwithCategoryPlatform();
        List<Oyunlar> TGetSearchListByFilter(string p);
    }
}
