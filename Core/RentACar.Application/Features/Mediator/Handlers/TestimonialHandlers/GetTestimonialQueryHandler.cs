using MediatR;
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
    public class GetTestimonialQueryHandler : IRequestHandler<GetTestimonialQuery, List<GetTestimonialQueryResult>>
    {
        private readonly IRepository<Testimonial> _repository;

        public GetTestimonialQueryHandler(IRepository<Testimonial> repository)
        {
            _repository = repository;
        }
        public async Task<List<GetTestimonialQueryResult>> Handle(GetTestimonialQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetTestimonialQueryResult
            {
                Comment = x.Comment,
                ImageUrl = x.ImageUrl,
                Name = x.Name,
                Title = x.Title,
                TestimonialId = x.TestimonialId
                
            }).ToList();
        }
    }
}
