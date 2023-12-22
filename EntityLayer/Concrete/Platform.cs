using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public class Platform
    {
        [Key]
        public int Platformid { get; set; }
        public string PlatformAd { get; set; }

        public List<Hareketler> Hareketlers { get; set; }
        public List<Oyunlar> Oyunlars { get; set; }
    }
}
