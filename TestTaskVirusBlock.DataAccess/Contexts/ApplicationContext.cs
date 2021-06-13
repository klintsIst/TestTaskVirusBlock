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
            Database.SetInitializer(new MyInitializer());
            Database.Initialize(true);
        }

        public class MyInitializer : DropCreateDatabaseAlways<ApplicationContext>
        {
            protected override void Seed(ApplicationContext context)
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

                var persons = new List<Person>
                {
                    new Person{ Id = Guid.NewGuid().ToString(), FirstName = "Ivan", LastName = "Ivanov"},
                    new Person{ Id = Guid.NewGuid().ToString(), FirstName = "Petr", LastName = "Petrov"},
                    new Person{ Id = Guid.NewGuid().ToString(), FirstName = "Vasil", LastName = "Vasilev"}
                };
                persons.ForEach(person => context.Persons.Add(person));

                context.SaveChanges();
            }
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Person> Persons { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }
    }
}
