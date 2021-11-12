using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc.Models
{
    public class RoleOperasyonModel
    {
        public Role role { get; set; }
        public List<Operasyon> aktifOperasyon { get; set; }
        public List<Operasyon> pasifOperasyon { get; set; }
    }
}
