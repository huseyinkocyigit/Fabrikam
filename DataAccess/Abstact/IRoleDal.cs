using Core.DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstact
{
    public interface IRoleDal : IEntityRepository<Role>
    {
        public List<Operasyon> GetAktifOperasyon(int roleId);
        public List<Operasyon> GetPasifOperasyon(int roleId);
    }
}
