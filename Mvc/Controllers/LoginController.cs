using Business.Abstract;
using Business.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Mvc.Controllers
{
    public class LoginController : Controller
    {
        IKullaniciService _kullaniciManager;

        public LoginController( IKullaniciService kullaniciManager)
        {
            _kullaniciManager = kullaniciManager;
        }

        public async Task<IActionResult> Index( string KullaniciAdi, string Sifre)
        {
            var kullanici = _kullaniciManager.KullaniciGetir(KullaniciAdi, Sifre);

            if(kullanici!=null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,kullanici.KullaniciAdi),
                    new Claim(ClaimTypes.Sid,kullanici.KullaniciId.ToString())
                };
                foreach (var item in _kullaniciManager.KullaniciRoleOperastyonlariniGetir(kullanici.KullaniciId))
                {
                    claims.Add(new Claim(ClaimTypes.Role, item));
                }
                var userIdentity = new ClaimsIdentity(claims, "Login");
                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Index", "Default");
            }

            return View();
        }
        public async Task<IActionResult> Out()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Login");
        }
        public ActionResult Yetki()
        {
            return View();
        }
    }
}
