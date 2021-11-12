using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAracService
    {
        public Arac AracGetir(int AracId);
        public List<Arac> TumAraclariGetir();
    }
}
