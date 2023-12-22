using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Oyunlar
    {
        [Key]
        public int OyunID { get; set; }
        public string OyunAd { get; set; }

        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }


        public int OyunGenelPuan { get; set; }
        public DateTime OyunCikisTarih { get; set; }
        public decimal OyunFiyat { get; set; }

        public virtual Platform Platform { get; set; }
        public int Platformid { get; set; }


        public string GelisticiFirma { get; set; }
        public string OyunTanitim { get; set; }
        public string OyunAciklama { get; set; }
        public string OyunResim { get; set; }


        public List<Hareketler> Hareketlers { get; set; }
    }
}
