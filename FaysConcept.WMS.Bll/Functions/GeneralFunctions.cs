using FaysConcept.Dal.Base;
using FaysConcept.Dal.Interfaces;
using FaysConcept.WMS.Model.Entities.Base.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;

namespace FaysConcept.WMS.Bll.Functions
{
    // karşılaştırma yapmak için kontrol
    public static class GeneralFunctions
    {
        public static List<string> DegisenAlanlariGetir<T>(this T oldEntity, T currentEntity)
        {
            List<string> anlanlar = new List<string>();
            foreach (var prop in currentEntity.GetType().GetProperties())
            {
                if (prop.PropertyType.Namespace == "System.Collections.Generic") continue;
                var oldValue = prop.GetValue(oldEntity) ?? string.Empty;
                var currentValue = prop.GetValue(currentEntity) ?? string.Empty;

                // resimler ile ilgili karşılaştırma
                if (prop.PropertyType == typeof(byte[]))
                {
                    if (string.IsNullOrEmpty(oldValue.ToString()))
                        oldValue = new byte[] { 0 };
                    if (string.IsNullOrEmpty(currentEntity.ToString()))
                        currentValue = new byte[] { 0 };

                    if (((byte[])oldValue).Length != ((byte[])currentValue).Length)
                        anlanlar.Add(prop.Name);
                }

                else if (!currentValue.Equals(oldValue))
                    anlanlar.Add(prop.Name);
            }
            return anlanlar;
        }

        public static string GetConnectionString()
        {
            //appconfig de connectionstring okunuyor.
            return ConfigurationManager.ConnectionStrings["FaysConteptContext"].ConnectionString;
        }
        private static TContext CreateContext<TContext>() where TContext : DbContext
        {
            return (TContext)Activator.CreateInstance(typeof(TContext), GetConnectionString());
        }
        public static void CreateUnitOfWork<T, TContext>(ref IUnitOfWork<T> uow) where T : class, IBaseEntity where TContext : DbContext
        {
            //uow?.Dispose(); null değil ise dispose et.
            uow?.Dispose();
            uow = new UnitOfWork<T>(CreateContext<TContext>());
        }
    }
}
