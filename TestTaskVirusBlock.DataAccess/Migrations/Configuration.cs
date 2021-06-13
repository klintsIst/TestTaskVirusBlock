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
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(TestTaskVirusBlock.DataAccess.Contexts.ApplicationContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
