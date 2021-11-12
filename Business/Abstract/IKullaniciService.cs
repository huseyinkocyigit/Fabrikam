using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
namespace Business.Abstract
{
    public interface IKullaniciService
    {
        Kullanici KullaniciGetir(string KullaniciAdi, string Sifre);
        List<string> KullaniciRoleOperastyonlariniGetir(int KullaniciId);
        public List<Kullanici> TumKullanicilarıGetir();
        public string KullaniciEkle(Kullanici kullanici);
    }
}
