using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IRoleService
    {
        public Role RoleGetir(int roleId);
        public List<Role> TumRolleriGetir();
        public string RoleEkle(Role role);
        public List<Operasyon> AktifOperasyonGetir(int roleId);
        public List<Operasyon> PasifOperasyonGetir(int roleId);
        public void RoleOprasyonEkle(RoleOperasyon roleOperasyon);
        public void RoleOprasyonSil(int roleOperasyonId);
        public void RoleOprasyonSil(int operasyonId,int roleId);
    }
}
