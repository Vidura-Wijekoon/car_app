namespace car_app.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<car_app.DataBase.DatabaseRepository>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "car_app.DataBase.DatabaseRepository";
        }

        protected override void Seed(car_app.DataBase.DatabaseRepository context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
