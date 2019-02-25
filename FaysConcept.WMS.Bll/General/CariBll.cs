using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Windows.Forms;
using FaysConcept.WMS.Bll.Base;
using FaysConcept.WMS.Common.Enums;
using FaysConcept.WMS.Data.Context;
using FaysConcept.WMS.Model.Dto;
using FaysConcept.WMS.Model.Entities;
using FaysConcept.WMS.Model.Entities.Base;

namespace FaysConcept.WMS.Bll.General
{
    public class CariBll : BaseBll<CariKartlar, FaysConceptContext>
    {
        protected CariBll()
        {
        }

        protected CariBll(Control ctrl) : base(ctrl)
        {
        }

        public BaseEntity Single(Expression<Func<CariKartlar, bool>> filter)
        {
            return BaseSingle(filter, x => new CariS
            {
                Id = x.Id,
                Kod = x.Kod,
                CariKodu = x.CariKodu,
                CariAdi = x.CariAdi,
                IlId = x.IlId,
                IlAdi = x.Il.IlAdi,
                IlceId = x.IlceId,
                IlceAdi = x.Ilce.IlceAdi,
                Aciklama = x.Aciklama,
                Durum = x.Durum
            });
        }

        public IEnumerable<BaseEntity> List(Expression<Func<CariKartlar, bool>> filter)
        {
            return BaseList(filter, x => new CariL
            {
                Id = x.Id,
                Kod = x.Kod,
                CariAdi = x.CariAdi,
                IlAdi = x.Il.IlAdi,
                IlceAdi = x.Ilce.IlceAdi,
                Aciklama = x.Aciklama
            });
        }
        public bool Insert(BaseEntity entity)
        {
            return BaseInsert(entity, x => x.Kod == entity.Kod);
        }
        public bool Updatw(BaseEntity oldEntity,BaseEntity currentEntity)
        {
            return BaseUpdate(oldEntity, currentEntity, x => x.Kod == currentEntity.Kod);
        
        }
        public bool Delete(BaseEntity entity)
        {
            return BaseDelete(entity, KartTuru.Cari);
        }
    }
}
