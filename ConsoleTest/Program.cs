using System;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System.Linq;
namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            KullaniciManager kullaniciManager = new KullaniciManager(new EfKullaniciDal());
            foreach (var item in kullaniciManager.KullaniciRoleOperastyonlariniGetir(1))
            {
                Console.WriteLine(item);
            }
            
        }
    }
}
