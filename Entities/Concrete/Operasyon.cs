using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Operasyon:IEntity
    {
        public int OperasyonId { get; set; }
        public string OperasyonAdi { get; set; }
        public string OperasyonVeri { get; set; }

    }
}
