using Core.Utilities;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc.Models
{
    public class AracRezervasyonModel
    {
        public DateTime Tarih { get; set; }
        public List<AracRezervasyonDto> Data { get; set; }
    }
}
