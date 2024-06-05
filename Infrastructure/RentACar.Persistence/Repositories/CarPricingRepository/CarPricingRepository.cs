using Microsoft.EntityFrameworkCore;
using RentACar.Application.Interfaces.CarPricingInterfaces;
using RentACar.Domain.Entities;
using RentACar.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Persistence.Repositories.CarPricingRepository
{
    public class CarPricingRepository : ICarPricingRepository
    {
        private readonly RentACarContext _context;

        public CarPricingRepository(RentACarContext context)
        {
            _context = context;
        }
        public async Task<List<CarPricing>> GetCarPricingWithCars()
        {
            var values = await _context.CarsPricings.Include(x=> x.Car).ThenInclude(y=>y.Brand).Include(z =>z.Pricing).Where(c=>c.PricingId==1).ToListAsync();
            return values;
        }
    }
}
