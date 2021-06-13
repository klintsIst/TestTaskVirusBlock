using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestTaskVirusBlock.DataAccess.Contexts;
using TestTaskVirusBlock.DataAccess.Models;

namespace TestTaskVirusBlock.DataAccess.Repositories
{
    public class CarRepository
    {
        private readonly ApplicationContext _context;

        public CarRepository()
        {
            this._context = new ApplicationContext();
        }

        public IEnumerable<Car> GetAllCars()
        {
            return _context.Cars.ToList();
        }
    }
}
