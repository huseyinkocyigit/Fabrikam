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
    public class RoleManager : IRoleService
    {
        IRoleDal _roleDal;
        IRoleOperasyonService _roleOperasyonService;
        public RoleManager(IRoleDal roleDal, IRoleOperasyonService roleOperasyonService)
        {
            _roleDal = roleDal;
            _roleOperasyonService = roleOperasyonService;
        }

        public List<Operasyon> AktifOperasyonGetir(int roleId)
        {
            return _roleDal.GetAktifOperasyon(roleId);
        }

        public List<Operasyon> PasifOperasyonGetir(int roleId)
        {
            return _roleDal.GetPasifOperasyon(roleId);
        }

        public string RoleEkle(Role role)
        {
            try
            {
                _roleDal.Add(role);
                return null;
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public Role RoleGetir(int roleId)
        {
            return _roleDal.Get(x=>x.RoleId==roleId);
        }

        public void RoleOprasyonEkle(RoleOperasyon roleOperasyon)
        {
            _roleOperasyonService.RoleOperasyonEkle(roleOperasyon);
        }

        public void RoleOprasyonSil(int roleOperasyonId)
        {
            _roleOperasyonService.RoleOperasyonSil(roleOperasyonId);
        }

        public void RoleOprasyonSil(int operasyonId, int roleId)
        {
            _roleOperasyonService.RoleOperasyonSil(operasyonId, roleId);
        }

        public List<Role> TumRolleriGetir()
        {
            return _roleDal.GetAll();
        }
    }
}
