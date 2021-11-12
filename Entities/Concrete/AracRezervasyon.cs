using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
     public class AracRezervasyon:IEntity
    {
        public int AracRezervasyonId { get; set; }
        public int AracId { get; set; }
        public int KullaniciId { get; set; }
        public DateTime Tarih { get; set; }
        public DateTime RezBasTarih { get; set; }
        public DateTime RezBitTarih { get; set; }
        public bool Onay { get; set; }
    }
}
