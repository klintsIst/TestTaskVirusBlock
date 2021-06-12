namespace TestTaskVirusBlock.DataAccess.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using TestTaskVirusBlock.DataAccess.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<TestTaskVirusBlock.DataAccess.Contexts.ApplicationContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TestTaskVirusBlock.DataAccess.Contexts.ApplicationContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            SeedDatabase(context);
        }

        private void SeedDatabase(TestTaskVirusBlock.DataAccess.Contexts.ApplicationContext context)
        {
            var cars = new List<Car>
            {
                new Car{ Id = Guid.NewGuid().ToString(), Brand = "BMW", Model = "E4", YearCreation = DateTime.Parse("1999-01-01"), Color = "#000000", IsAutomaticTransmission = true},
                new Car{ Id = Guid.NewGuid().ToString(), Brand = "BMW", Model = "X5", YearCreation = DateTime.Parse("2005-01-01"), Color = "#ffffff", IsAutomaticTransmission = true},
                new Car{ Id = Guid.NewGuid().ToString(), Brand = "Audi", Model = "100", YearCreation = DateTime.Parse("1995-01-01"), Color = "#000000", IsAutomaticTransmission = false},
                new Car{ Id = Guid.NewGuid().ToString(), Brand = "Opel", Model = "200", YearCreation = DateTime.Parse("2010-01-01"), Color = "#0000ff", IsAutomaticTransmission = true},
                new Car{ Id = Guid.NewGuid().ToString(), Brand = "BMW", Model = "X6", YearCreation = DateTime.Parse("2020-01-01"), Color = "#ffffff", IsAutomaticTransmission = false}
            };

            cars.ForEach(car => context.Cars.Add(car));
            context.SaveChanges();
        }
    }
}
