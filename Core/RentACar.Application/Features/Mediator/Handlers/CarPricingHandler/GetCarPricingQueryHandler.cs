using MediatR;
using RentACar.Application.Features.Mediator.Queries.CarPricingQueries;
using RentACar.Application.Features.Mediator.Results.CarPricingResult;
using RentACar.Application.Interfaces.CarPricingInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Application.Features.Mediator.Handlers.CarPricingHandler
{
    public class GetCarPricingQueryHandler : IRequestHandler<GetCarPricingQuery, List<GetCarPricingQueryResult>>
    {
        private readonly ICarPricingRepository _carPricingRepository;

        public GetCarPricingQueryHandler(ICarPricingRepository carPricingRepository)
        {
            _carPricingRepository = carPricingRepository;
        }
        public async Task<List<GetCarPricingQueryResult>> Handle(GetCarPricingQuery request, CancellationToken cancellationToken)
        {
            var values = await _carPricingRepository.GetCarPricingWithCars();
            return values.Select(x =>new GetCarPricingQueryResult
            {
                Amount = x.Amount,
                CarPricingId = x.CarPricingId,
                Brand=x.Car.Brand.Name,
                CoverImageUrl = x.Car.CoverImageUrl,
                Model=x.Car.Model
            }).ToList();
        }
    }
}
