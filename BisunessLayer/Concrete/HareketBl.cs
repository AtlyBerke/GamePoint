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
    public class HareketBl : IHareketlerBl
    {

        IHareketlerDal _hareketdal;

        public HareketBl(IHareketlerDal hareketdal)
        {
            _hareketdal = hareketdal;
        }

        public void TAdd(Hareketler t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Hareketler t)
        {
            throw new NotImplementedException();
        }

        public Hareketler TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        //List<Hareketler> TListByParameterHareket(int id)
        //{
        //    return _hareketdal.GetListByParameterHareket(id);
        //}

        public List<Hareketler> TGetList()
        {
            throw new NotImplementedException();
        }

        public List<Hareketler> TGetListByFilter(int id)
        {
            throw new NotImplementedException();
        }

        public List<Hareketler> TGetListByParameterHareket(int id)
        {
            return _hareketdal.GetListByParameterHareket(id);
        }

        public List<Hareketler> TGetListLinq()
        {
            throw new NotImplementedException();
        }
    }
}
