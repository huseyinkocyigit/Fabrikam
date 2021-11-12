using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Kullanici:IEntity
    {
        public int KullaniciId { get; set; }
        public int RoleId { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public string Eposta { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
    }
}
