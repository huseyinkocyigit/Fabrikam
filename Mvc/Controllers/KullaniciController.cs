using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mvc.Models;

namespace Mvc.Controllers
{
    public class KullaniciController : Controller
    {
        IKullaniciService _kullaniciManager;
        IRoleService _roleManager;
        
        public KullaniciController(IKullaniciService kullaniciManager,IRoleService roleManager)
        {
            _kullaniciManager = kullaniciManager;
            _roleManager = roleManager;
        }

        [Authorize(Roles="Kullanici/Index")]
        public IActionResult Index()
        {
            return View(_kullaniciManager.TumKullanicilarıGetir());
        }
        [Authorize(Roles = "Kullanici/Yeni")]
        public IActionResult Yeni()
        {
            KullaniciModel myModel = new KullaniciModel()
            {
                kullanici = new Kullanici(),
                roleListesi = _roleManager.TumRolleriGetir()
            };
            return View(myModel);
        }
        [HttpPost]
        [Authorize(Roles = "Kullanici/Yeni")]
        public IActionResult Yeni(Kullanici kullanici)
        {
            var result = _kullaniciManager.KullaniciEkle(kullanici);
            if (result==null)
            {
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.Hata = result;
            }
            KullaniciModel myModel = new KullaniciModel()
            {
                kullanici = kullanici,
                roleListesi = _roleManager.TumRolleriGetir()
            };
            return View(myModel);
        }
    }
}
