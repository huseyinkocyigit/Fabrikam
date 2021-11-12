using Core.Utilities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos
{
    public class AracRezervasyonDto
    {
        public Arac Arac { get; set; }
        public List<CheckboxItem> SaatlikDurumListesi { get; set; }
    }
}
