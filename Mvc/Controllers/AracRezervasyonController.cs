using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mvc.Models;
namespace Mvc.Controllers
{
    public class AracRezervasyonController : Controller
    {
        IAracRezervasyonService _aracRezervasyonService;
        public AracRezervasyonController(IAracRezervasyonService aracRezervasyonService)
        {
            _aracRezervasyonService = aracRezervasyonService;
        }
        public IActionResult Index()
        {
            AracRezervasyonModel myModel = new AracRezervasyonModel();
            myModel.Tarih = DateTime.Now;
            myModel.Data = _aracRezervasyonService.AracRezervasyonDataGetir(myModel.Tarih);
            return View(myModel) ;
        }
    }
}
