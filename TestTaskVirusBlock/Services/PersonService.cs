using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestTaskVirusBlock.DataAccess.Models;
using TestTaskVirusBlock.DataAccess.Repositories;
using TestTaskVirusBlock.ModelsPL;

namespace TestTaskVirusBlock.Services
{
    public class PersonService
    {
        private readonly PersonRepository _repo = new PersonRepository();

        public IEnumerable<PersonPL> GetAllPersons()
        {
            var configure = new MapperConfiguration(config => config.CreateMap<Person, PersonPL>());
            var mapper = new Mapper(configure);
            var persons = mapper.Map<IEnumerable<PersonPL>>(_repo.GetAllPersons());
            return persons;
        }

        public string CreatePerson(PersonPL personPl)
        {
            var configure = new MapperConfiguration(config => config.CreateMap<PersonPL, Person>());
            var mapper = new Mapper(configure);
            string newGuid = _repo.AddNewPerson(mapper.Map<Person>(personPl));
            return newGuid;
        }
    }
}
