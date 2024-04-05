using RentACar.Application.Features.Queries.ContactQueries;
using RentACar.Application.Features.Results.ContactResult;
using RentACar.Application.Interfaces;
using RentACar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Application.Features.Handlers.ContactHandlers
{
    public class GetContactByIdQueryHandler
    {
        private readonly IRepository<Contact> _repository;

        public GetContactByIdQueryHandler(IRepository<Contact> repository)

        {
            _repository = repository;
        }

        public async Task<GetContactByIdQueryResult> Handle(GetContactByIdQuery query)
        {
            var value = await _repository.GetByIdAsync(query.Id);
            return new GetContactByIdQueryResult
            {
                Email = value.Email,
                ContactId = value.ContactId,
                Message = value.Message,
                Name = value.Name,
                SendData = value.SendData,
                Subject = value.Subject,

            };

        }
        

        
    }
}
