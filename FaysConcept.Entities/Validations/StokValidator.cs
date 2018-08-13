using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using FaysConcept.Entities.Tables;

namespace FaysConcept.Entities.Validations
{
   public class StokValidator:AbstractValidator<Stok>
    {
        public StokValidator()
        {
            RuleFor(p => p.StokKodu).NotEmpty().WithMessage("Stok Kodu Alanı Boş Geçilemez");
            RuleFor(p => p.StokAdi).NotEmpty().WithMessage("Stok Adı Alanı Boş Geçilemez")
            .Length(5, 50).WithMessage("Stok Adı alanı 5 ile 50 karakter arasında olabilir");
            RuleFor(p => p.BarkodNo).NotEmpty().WithMessage("Barkod No alanı boş geçilemez");
            //.Length(13).WithMessage("Barkod No alanı 13 karakterden oluşmalı olmalı");
            RuleFor(p => p.AlisFiyat1).GreaterThanOrEqualTo(0).WithMessage("Alış fiyatı 1 alanı 0'dan küçük olamaz.");
            RuleFor(p => p.AlisFiyat2).GreaterThanOrEqualTo(0).WithMessage("Alış fiyatı 2 alanı 0'dan küçük olamaz.");
            RuleFor(p => p.AlisFiyat3).GreaterThanOrEqualTo(0).WithMessage("Alış fiyatı 3 alanı 0'dan küçük olamaz.");
            RuleFor(p => p.SatisFiyat1).GreaterThanOrEqualTo(0).WithMessage("Satış fiyatı 1 alanı 0'dan küçük olamaz.");
            RuleFor(p => p.SatisFiyat2).GreaterThanOrEqualTo(0).WithMessage("Satış fiyatı 2 alanı 0'dan küçük olamaz.");
            RuleFor(p => p.SatisFiyat3).GreaterThanOrEqualTo(0).WithMessage("Satış fiyatı 3 alanı 0'dan küçük olamaz.");

        }
    }
}
