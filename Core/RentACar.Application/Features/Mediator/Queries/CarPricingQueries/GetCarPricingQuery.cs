using MediatR;
using RentACar.Application.Features.Mediator.Results.CarPricingResult;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Application.Features.Mediator.Queries.CarPricingQueries
{
    public class GetCarPricingQuery :IRequest <List<GetCarPricingQueryResult>>
    {
    }
}
