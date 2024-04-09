using MediatR;
using RentACar.Application.Features.Mediator.Commands.FooterAddressCommands;
using RentACar.Application.Interfaces;
using RentACar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Application.Features.Mediator.Handlers.FooterAddressHandlers
{
    public class UpdateFooterAddressCommandHandler : IRequestHandler<UpdateFooterAddressCommand>
    {
        private readonly IRepository<FooterAdress> _repository;

        public UpdateFooterAddressCommandHandler(IRepository<FooterAdress> repository)
        {
            _repository = repository;
        }
        public async Task Handle(UpdateFooterAddressCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.FooterAdressId);
            value.Phone = request.Phone;
            value.Adress = request.Adress;
            value.Description = request.Description;
            value.Email = request.Email;
            await _repository.UpdateAsync(value);
           

        }
    }
}
