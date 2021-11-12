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
    public class RoleOperasyonManager : IRoleOperasyonService
    {
        IRoleOperasyonDal _roleOperasyonDal;
        public RoleOperasyonManager(IRoleOperasyonDal roleOperasyonDal)
        {
            _roleOperasyonDal = roleOperasyonDal;
        }

        public void RoleOperasyonEkle(RoleOperasyon roleOperasyon)
        {
            _roleOperasyonDal.Add(roleOperasyon);
        }

        public List<RoleOperasyon> RoleOperasyonsGetir(int roleId)
        {
            return _roleOperasyonDal.GetAll(x => x.RoleId == roleId);
        }

        public void RoleOperasyonSil(int roleOperasyonId)
        {
            var silinecek = _roleOperasyonDal.Get(i => i.Id == roleOperasyonId);
            if (silinecek != null)
            {
                _roleOperasyonDal.Delete(silinecek);
            }
        }

        public void RoleOperasyonSil(int operasyonId, int roleId)
        {
            var silinecek = _roleOperasyonDal.Get(i =>i.OperasyonId==operasyonId && i.RoleId==roleId);
            if (silinecek != null)
            {
                _roleOperasyonDal.Delete(silinecek);
            }
        }
    }
}
