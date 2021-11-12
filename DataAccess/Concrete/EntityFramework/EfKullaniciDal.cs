using Core.DataAccess.EntityFramework;
using DataAccess.Abstact;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfKullaniciDal: EntityRepositoryBase<Kullanici,PgFabrikaContext>,IKullaniciDal
    {
        public List<string> GetKullaniciRoleOperasyon(int kullaniciId)
        {
            using (var context= new PgFabrikaContext())
            {
                var result = from kullanici in context.Kullanici
                             join role in context.Role on kullanici.RoleId equals role.RoleId
                             join roleOperasyon in context.RoleOperasyon on role.RoleId equals roleOperasyon.RoleId
                             join operasyon in context.Operasyon on roleOperasyon.OperasyonId equals operasyon.OperasyonId
                             where kullanici.KullaniciId == kullaniciId
                             select operasyon.OperasyonVeri;
                return result.ToList();
                
            }
        }
    }
}
