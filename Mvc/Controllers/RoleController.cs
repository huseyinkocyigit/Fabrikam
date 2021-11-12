using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mvc.Models;

namespace Mvc.Controllers
{
    public class RoleController : Controller
    {
        IRoleService _roleManager;
        public RoleController(IRoleService roleManager)
        {
            _roleManager = roleManager;
        }
        public IActionResult Index()
        {
            return View(_roleManager.TumRolleriGetir());
        }
        public IActionResult Yeni()
        {
            return View(new Role());
        }
        [HttpPost]
        public IActionResult Yeni(Role role)
        {
            var result = _roleManager.RoleEkle(role);
            if (result == null)
            {
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.Hata = result;
                return View(role);
            }
        }
        public ActionResult Operasyon(int Id)
        {
            RoleOperasyonModel myModel = new RoleOperasyonModel()
            {
                role = _roleManager.RoleGetir(Id),
                aktifOperasyon = _roleManager.AktifOperasyonGetir(Id),
                pasifOperasyon = _roleManager.PasifOperasyonGetir(Id)
            };
            return View(myModel);
        }
        [HttpPost]
        public ActionResult OperasyonEkle(RoleOperasyon roleOperasyon)
        {
            _roleManager.RoleOprasyonEkle(roleOperasyon);
            return RedirectToAction("Operasyon",new { id=roleOperasyon.RoleId});
        }
        [HttpGet]
        public ActionResult OperasyonSil(int operasyonId,int roleId)
        {
            _roleManager.RoleOprasyonSil(operasyonId, roleId);
            return RedirectToAction("Operasyon", new { id = roleId });
        }
    }
}
