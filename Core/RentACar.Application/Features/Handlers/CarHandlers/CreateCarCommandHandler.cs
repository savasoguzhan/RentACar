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
    public class CreateCarCommandHandler
    {
        private readonly IRepository<Car> _repository;

        public CreateCarCommandHandler(IRepository<Car> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateCarCommand command)
        {
            await _repository.CreateAsync(new Car
            {
                BigImageUrl = command.BigImageUrl,
                BrandId = command.BrandId,
                Luggage = command.Luggage,
                Fuel = command.Fuel,
                Seat = command.Seat,
                Km = command.Km,
                Transmission = command.Transmission,
                CoverImageUrl = command.CoverImageUrl,
                Model = command.Model,
                



            });
        }
    }
}
