using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IRoleOperasyonService
    {
        public List<RoleOperasyon> RoleOperasyonsGetir(int roleId);
        public void RoleOperasyonEkle(RoleOperasyon roleOperasyon);
        public void RoleOperasyonSil(int roleOperasyonId);
        public void RoleOperasyonSil(int OperasyonId,int roleId);
    }
}
