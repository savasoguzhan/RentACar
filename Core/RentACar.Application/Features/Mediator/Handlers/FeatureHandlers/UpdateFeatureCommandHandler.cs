﻿using MediatR;
using RentACar.Application.Features.Mediator.Commands.FeatureCommands;
using RentACar.Application.Interfaces;
using RentACar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace RentACar.Application.Features.Mediator.Handlers.FeatureHandlers
{
    public class UpdateFeatureCommandHandler : IRequestHandler<UpdateFeatureCommand>
    {
        private readonly IRepository<Feature> _repository;

        public UpdateFeatureCommandHandler(IRepository<Feature> repository)
        {
            _repository = repository;
        }
        public async Task Handle(UpdateFeatureCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.FeatureId);
            value.Name = request.Name;
            await _repository.UpdateAsync(value);
        }
    }
}
