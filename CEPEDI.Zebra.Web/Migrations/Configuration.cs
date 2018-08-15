namespace CEPEDI.Zebra.Web.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CEPEDI.Zebra.Web.Models.ZebraDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "CEPEDI.Zebra.Web.Models.ZebraDBContext";
        }

        protected override void Seed(CEPEDI.Zebra.Web.Models.ZebraDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
