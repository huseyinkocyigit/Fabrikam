using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc.Models
{
    public class KullaniciModel
    {
        public Kullanici kullanici { get; set; }
        public List<Role> roleListesi { get; set; }
    }
}
