using Core.DataAccess.EntityFramework;
using DataAccess.Abstact;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRoleDal:EntityRepositoryBase<Role, PgFabrikaContext>,IRoleDal
    {
        public List<Operasyon> GetAktifOperasyon(int roleId)
        {
            using (var context = new PgFabrikaContext())
            {
                var result = from role in context.Role
                             join roleOperasyon in context.RoleOperasyon on role.RoleId equals roleOperasyon.RoleId
                             join operasyon in context.Operasyon on roleOperasyon.OperasyonId equals operasyon.OperasyonId
                             where role.RoleId==roleId
                             select new Operasyon { OperasyonAdi = operasyon.OperasyonAdi, OperasyonId = operasyon.OperasyonId, OperasyonVeri = operasyon.OperasyonVeri };
                return result.ToList();

            }
        }
        public List<Operasyon> GetPasifOperasyon(int roleId)
        {
            using (var context = new PgFabrikaContext())
            {
                var aktifList = from roleOperasyon in context.RoleOperasyon where roleOperasyon.RoleId == roleId select roleOperasyon.OperasyonId;
                var result = from operasyon in context.Operasyon where !aktifList.Any(x => x == operasyon.OperasyonId) select operasyon;
                return result.ToList();
                //var result = from operasyon in context.Operasyon
                //             join roleOperasyon in context.RoleOperasyon on operasyon.OperasyonId equals roleOperasyon.OperasyonId
                //             where roleOperasyon.RoleId!=roleId
                //             select new Operasyon { OperasyonAdi = operasyon.OperasyonAdi, OperasyonId = operasyon.OperasyonId, OperasyonVeri = operasyon.OperasyonVeri };
                //return result.ToList();

            }
        }
    }
}
