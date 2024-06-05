using Microsoft.EntityFrameworkCore;
using RentACar.Application.Interfaces.CarInterfaces;
using RentACar.Domain.Entities;
using RentACar.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Persistence.Repositories.CarRepository
{
    public class CarRepositories : ICarRepository
    {
        private readonly RentACarContext _context;

        public CarRepositories(RentACarContext context)
        {
            _context = context;
        }

        public async Task<List<Car>> GetCarListWithBrand()
        {
            var values = await _context.Cars.Include(c => c.Brand).ToListAsync();
            return values;
        }

       

        public async Task<List<Car>> GetLastFiveCarsWithBrands()
        {
            var values = await _context.Cars.Include(x => x.Brand).OrderByDescending(o =>o.CarId).Take(5).ToListAsync();
            return values;
        }
    }
}
