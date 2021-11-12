using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class RoleOperasyon:IEntity
    {
        public int Id { get; set; }
        public int RoleId { get; set; }
        public int OperasyonId { get; set; }
    }
}
