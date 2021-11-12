using Business.Abstract;
using DataAccess.Abstact;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class KullaniciManager:IKullaniciService
    {
        private readonly IKullaniciDal _kullaniciDal;

        public KullaniciManager( IKullaniciDal kullaniciDal)
        {
            _kullaniciDal=kullaniciDal;

        }

        public string KullaniciEkle(Kullanici kullanici)
        {
            try
            {
                _kullaniciDal.Add(kullanici);
                return null;
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public Kullanici KullaniciGetir(string KullaniciAdi, string Sifre)
        {
            return _kullaniciDal.Get(i => i.KullaniciAdi == KullaniciAdi && i.Sifre == Sifre);
        }

        public List<string> KullaniciRoleOperastyonlariniGetir(int KullaniciId)
        {
            return _kullaniciDal.GetKullaniciRoleOperasyon(KullaniciId);
        }

        public List<Kullanici> TumKullanicilarıGetir()
        {
            return _kullaniciDal.GetAll();
        }
    }
}
