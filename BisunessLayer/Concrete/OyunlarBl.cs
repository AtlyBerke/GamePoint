using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BisunessLayer.Concrete
{

    public class OyunlarBl : IOyunlarBl
    {


        IOyunlarDal _oyundal;

        public OyunlarBl(IOyunlarDal oyundal)
        {
            _oyundal = oyundal;
        }

        public void TAdd(Oyunlar t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Oyunlar t)
        {
            throw new NotImplementedException();
        }

        public Oyunlar TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Oyunlar> TGetList()
        {
          return _oyundal.GetList();
        }

        public List<Oyunlar> TGetListByFilter(int id)
        {
            throw new NotImplementedException();
        }

        public List<Oyunlar> TGetListLinq()
        {
            return _oyundal.GetListLinq();
        }

        public List<Oyunlar> TGetListwithCategoryPlatform()
        {
            return _oyundal.GetListWithCategoryPlatform();
        }

        public List<Oyunlar> TGetSearchListByFilter(string p)
        {
            return _oyundal.GetSearchListByFilter(p);
        }
    }
}
