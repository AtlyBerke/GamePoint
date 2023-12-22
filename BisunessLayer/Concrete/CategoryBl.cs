using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryBl : ICategoryBl
    {

        ICategoryDal _categorydal;

        public CategoryBl(ICategoryDal categorydal)
        {
            _categorydal = categorydal;
        }

        public void TAdd(Category t)
        {
            _categorydal.Insert(t);
        }

        public void TDelete(Category t)
        {
            throw new NotImplementedException();
        }

        public Category TGetByID(int id)
        {
            return _categorydal.GetById(id);
        }

        public List<Category> TGetList()
        {
           return _categorydal.GetList();
        }

        public List<Category> TGetListByFilter(int id)
        {
            return _categorydal.GetListByFilter(x => x.CategoryID == id);
        }

        public List<Category> TGetListLinq()
        {
            throw new NotImplementedException();
        }


        //public List<Category> TGetSearchListByFilter(string p)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
