using Business.Abstract;
using DataAccess.Abstact;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AracManager : IAracService
    {
        IAracDal _aracDal;
        public AracManager(IAracDal aracDal)
        {
            _aracDal = aracDal;
        }

        public Arac AracGetir(int AracId)
        {
            return _aracDal.Get(i => i.AracId == AracId);
        }

        public List<Arac> TumAraclariGetir()
        {
            return _aracDal.GetAll();
        }
    }
}
