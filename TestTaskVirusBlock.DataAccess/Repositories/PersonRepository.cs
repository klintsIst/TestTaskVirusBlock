using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestTaskVirusBlock.DataAccess.Contexts;
using TestTaskVirusBlock.DataAccess.Models;

namespace TestTaskVirusBlock.DataAccess.Repositories
{
    public class PersonRepository
    {
        private readonly ApplicationContext _context;

        public PersonRepository()
        {
            this._context = new ApplicationContext();
        }

        public IEnumerable<Person> GetAllPersons()
        {
            return _context.Persons.ToList();
        }

        public string AddNewPerson(Person person)
        {
            if (person.Id is null)
            {
                person.Id = Guid.NewGuid().ToString();
            }
            _context.Persons.Add(person);
            _context.SaveChanges();
            return person.Id;
        }
    }
}
