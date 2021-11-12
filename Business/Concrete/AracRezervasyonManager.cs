using Business.Abstract;
using Core.Utilities;
using DataAccess.Abstact;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AracRezervasyonManager : IAracRezervasyonService
    {
        IAracRezervasyonDal _aracRezervasyonDal;
        IAracService _aracService;
        public AracRezervasyonManager(IAracRezervasyonDal aracRezervasyonDal,IAracService aracService)
        {
            _aracRezervasyonDal = aracRezervasyonDal;
            _aracService = aracService;
        }

        public List<AracRezervasyonDto> AracRezervasyonDataGetir(DateTime Tarih)
        {

            var aracListesi = _aracService.TumAraclariGetir();
            List<AracRezervasyonDto> RezevasyonData = new List<AracRezervasyonDto>();
            foreach (var item in aracListesi)
            {
                AracRezervasyonDto rezervasyonDto = new AracRezervasyonDto();
                rezervasyonDto.Arac = item;
                rezervasyonDto.SaatlikDurumListesi = RezervasyonSaatleriniGetir(Tarih, item.AracId);
                RezevasyonData.Add(rezervasyonDto);
            }
            return RezevasyonData;
        }
        List<CheckboxItem> RezervasyonSaatleriniGetir(DateTime tarih,int aracId)
        {
            List<CheckboxItem> sonuc = new List<CheckboxItem>();
            var rezervasyon = _aracRezervasyonDal.GetAll(i => i.AracId == aracId && i.RezBasTarih >= tarih && i.RezBitTarih < tarih.AddDays(1));
            List<int> tutData = new List<int>();
            foreach (var item in rezervasyon)
            {
                tutData.AddRange(Static.TarihArasiSaatListele(item.RezBasTarih, item.RezBitTarih));        
            }
            for (int i = 0; i <24; i++)
            {
                CheckboxItem tut = new CheckboxItem();
                tut.Value = i.ToString();
                tut.Checked = tutData.Contains(i);
                if(tut.Checked)
                {
                    tut.Text = "Dolu";
                }
                else
                {
                    tut.Text = "Boş";
                }
                sonuc.Add(tut);
            }
            return sonuc;
        }
    }
}
