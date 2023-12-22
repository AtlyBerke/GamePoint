using BisunessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;
namespace DenemeGamePoint2.Controllers
{
    public class TumOyunlarController : Controller
    {

        OyunlarBl oyunbl = new OyunlarBl(new EfOyunlarDal());

        public IActionResult Index(string p)
        {
            if (p == null)
            {
                var values2 = oyunbl.TGetListwithCategoryPlatform();
                return View(values2);
            }
            var values = oyunbl.TGetSearchListByFilter(p);
            return View(values);
        }



    }
}
