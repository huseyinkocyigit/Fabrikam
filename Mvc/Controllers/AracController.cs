using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc.Controllers
{
    public class AracController : Controller
    {
        IAracService _aracService;
        public AracController(IAracService aracService)
        {
            _aracService = aracService;
        }
        public IActionResult Index()
        {

            return View(_aracService.TumAraclariGetir());
        }
    }
}
