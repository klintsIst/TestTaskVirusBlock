using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using TestTaskVirusBlock.DataAccess.Models;

namespace TestTaskVirusBlock.DataAccess.Contexts
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext() : base("Data Source = DESKTOP-HB4PF3F; Initial Catalog = dbForTestTask; Integrated Security = True; user id = klinov; password=123456789; App=EntityFramework; MultipleActiveResultSets=true")
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<ApplicationContext>());
        }

        public DbSet<Car> Cars { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }
    }
}
