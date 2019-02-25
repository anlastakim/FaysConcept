using FaysConcept.WMS.Data.Context;
using System.Data.Entity.Migrations;


namespace FaysConcept.WMS.Data.WMSMigration
{
  public  class Configuration:DbMigrationsConfiguration<FaysConceptContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }
    }
}
