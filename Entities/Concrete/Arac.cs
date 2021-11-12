using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Arac:IEntity
    {
        public int AracId { get; set; }
        public string Plaka { get; set; }
        public string Aciklama { get; set; }
    }
}
