using BisunessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DenemeGamePoint2.Controllers
{
    public class HareketController : Controller
    {

        HareketBl hareketbl = new HareketBl(new EfHareketlerDal());
        Context c = new Context();
        public IActionResult Index(int id)
        {
            ViewBag.link = c.Oyunlars.Where(x=>x.OyunID==id).Select(x => x.OyunTanitim).FirstOrDefault();
            var values = hareketbl.TGetListByParameterHareket(id);
            return View(values);
        }



    }
}
