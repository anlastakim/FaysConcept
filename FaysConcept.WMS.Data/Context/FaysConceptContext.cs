using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using FaysConcept.WMS.Data.WMSMigration;


namespace FaysConcept.WMS.Data.Context
{
      public class FaysConceptContext : BaseDbContext<FaysConceptContext,Configuration>
    {
       
        public FaysConceptContext()
        {
            Configuration.LazyLoadingEnabled = false; // baðlý olan tüm kayýtlarý sorgularda getirmemesi için
        }

        public FaysConceptContext(string connectionString) : base(connectionString)
        {
            Configuration.LazyLoadingEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();  // t
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }
    }


}