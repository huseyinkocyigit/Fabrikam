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
    public class EfAracRezervasyonDal:EntityRepositoryBase<AracRezervasyon, PgFabrikaContext>,IAracRezervasyonDal
    {
    }
}
