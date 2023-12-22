using BisunessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DenemeGamePoint2.Controllers
{
    public class AnaSayfaController : Controller
    {

        OyunlarBl oyunbl = new OyunlarBl(new EfOyunlarDal());

        public IActionResult Index()
        {
            var values = oyunbl.TGetListLinq();
            return View(values);
        }
    }
}
