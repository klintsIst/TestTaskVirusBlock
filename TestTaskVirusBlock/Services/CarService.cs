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
    public class CarService
    {
        private readonly CarRepository _repo = new CarRepository();
        
        public IEnumerable<CarPL> GetAllCars()
        {
            var configure = new MapperConfiguration(config => config.CreateMap<Car, CarPL>());
            var mapper = new Mapper(configure);
            var cars = mapper.Map<IEnumerable<CarPL>>(_repo.GetAllCars());
            return cars;
        }

        public string CreateCar(CarPL carPL)
        {
            var configure = new MapperConfiguration(config => config.CreateMap<CarPL, Car>());
            var mapper = new Mapper(configure);
            string newGuid = _repo.AddNewCar(mapper.Map<Car>(carPL));
            return newGuid;
        }
    }
}
