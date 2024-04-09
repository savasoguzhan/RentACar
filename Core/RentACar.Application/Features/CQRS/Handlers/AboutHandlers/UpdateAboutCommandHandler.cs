using RentACar.Application.Features.CQRS.Commands.AboutCommands;
using RentACar.Application.Interfaces;
using RentACar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Application.Features.CQRS.Handlers.AboutHandlers
{
    public class UpdateAboutCommandHandler
    {
        private readonly IRepository<About> _repository;

        public UpdateAboutCommandHandler(IRepository<About> repository)
        {
            _repository = repository;
        }

        public async Task Handler(UpdateCommandUpdate commandUpdate)
        {
            var value = await _repository.GetByIdAsync(commandUpdate.AboutId);
            value.Description = commandUpdate.Description;
            value.Title = commandUpdate.Title;
            value.ImageUrl = commandUpdate.ImageUrl;
            await _repository.UpdateAsync(value);
        }
    }
}
