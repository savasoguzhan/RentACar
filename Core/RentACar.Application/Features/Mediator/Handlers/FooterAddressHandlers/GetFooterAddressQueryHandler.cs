using MediatR;
using RentACar.Application.Features.Mediator.Queries.FooterAddressQueries;
using RentACar.Application.Features.Mediator.Results.FooterAddressResult;
using RentACar.Application.Interfaces;
using RentACar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Application.Features.Mediator.Handlers.FooterAddressHandlers
{
    public class GetFooterAddressQueryHandler : IRequestHandler<GetFooterAddressQuery, List<GetFooterAddressQueryResult>>
    {
        private readonly IRepository<FooterAdress> _repository;

        public GetFooterAddressQueryHandler(IRepository<FooterAdress> repository)
        {
            _repository = repository;
        }
        public async Task<List<GetFooterAddressQueryResult>> Handle(GetFooterAddressQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetFooterAddressQueryResult
            {
                Adress =x.Adress,
                Description = x.Description,
                Email = x.Email,
                FooterAdressId = x.FooterAdressId,
                Phone=x.Phone
            }).ToList();
        }
    }
}
