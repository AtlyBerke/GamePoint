using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public class Hareketler
    {
        [Key]
        public int HareketID { get; set; }

        public virtual Oyunlar Oyunlar { get; set; }
        public int OyunID { get; set; }


        public virtual Platform Platform { get; set; }
        public int Platformid { get; set; }


        public virtual Firmalar Firmalar { get; set; }
        public int FirmaID { get; set; }
       
       

        public int FirmaPuan { get; set; }
        public string FirmaYorum { get; set; }
    }
}
