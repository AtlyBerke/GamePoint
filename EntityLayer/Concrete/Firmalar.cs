using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
  public  class Firmalar
    {
        [Key]
        public int FirmaID { get; set; }
        public string FirmaAd { get; set; }

        public List<Hareketler> Hareketlers { get; set; }

    }
}
