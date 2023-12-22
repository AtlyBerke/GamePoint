using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
   public interface IGenericBl<T> where T:class
    {

        void TAdd(T t);
        
        void TDelete(T t);
        
        List<T> TGetList();

        List<T> TGetListByFilter(int id);

        public List<T> TGetListLinq();

        T TGetByID(int id);
        
         
        


    }
}
