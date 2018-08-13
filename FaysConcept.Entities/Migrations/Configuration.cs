namespace FaysConcept.Entities.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<FaysConcept.Entities.Context.FaysConceptContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
           AutomaticMigrationDataLossAllowed = true;
            ContextKey = "FaysConcept.Entities.Context.FaysConceptContext";
        }

        protected override void Seed(FaysConcept.Entities.Context.FaysConceptContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
