﻿using MediatR;
using RentACar.Application.Features.Mediator.Queries.TestimonialQueries;
using RentACar.Application.Features.Mediator.Results.TestimonialResult;
using RentACar.Application.Interfaces;
using RentACar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Application.Features.Mediator.Handlers.TestimonialHandlers
{
    public class GetTestimonialByIdQueryHandler : IRequestHandler<GetTestimonialByIdQuery, GetTestimonialByIdQueryResult>
    {
        private readonly IRepository<Testimonial> _repository;

        public GetTestimonialByIdQueryHandler(IRepository<Testimonial> repository)
        {
            _repository = repository;
        }
        public async Task<GetTestimonialByIdQueryResult> Handle(GetTestimonialByIdQuery request, CancellationToken cancellationToken)
        {
           var value = await _repository.GetByIdAsync(request.Id);
            return new GetTestimonialByIdQueryResult{
                Comment=value.Comment,
                ImageUrl=value.ImageUrl,
                Name=value.Name,
                Title=value.Title,
                TestimonialId=value.TestimonialId,
            };

        }
    }
}
