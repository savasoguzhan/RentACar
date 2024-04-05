using RentACar.Application.Features.Commands.CarCommands;
using RentACar.Application.Interfaces;
using RentACar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Application.Features.Handlers.CarHandlers
{
    public class UpdateCarCommandHandler
    {
        private readonly IRepository<Car> _repository;

        public UpdateCarCommandHandler(IRepository<Car> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateCarCommand command)
        {
            var value = await _repository.GetByIdAsync(command.CarId);
            value.Transmission = command.Transmission;
            value.CoverImageUrl = command.CoverImageUrl;
            value.Km=command.Km;
            value.Fuel=command.Fuel;
            value.Seat=command.Seat;
            value.Luggage=command.Luggage;
            value.BigImageUrl=command.BigImageUrl;
            value.Model=command.Model;
            value.BrandId=command.BrandId;

            await _repository.UpdateAsync(value);


        }
    }
}
