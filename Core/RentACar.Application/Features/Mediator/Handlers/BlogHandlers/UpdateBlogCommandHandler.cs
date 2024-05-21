using MediatR;
using RentACar.Application.Features.Mediator.Commands.BlogCommands;
using RentACar.Application.Interfaces;
using RentACar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Application.Features.Mediator.Handlers.BlogHandlers
{
    public class UpdateBlogCommandHandler : IRequestHandler<UpdateBlogCommand>
    {
        private readonly IRepository<Blog> _repository;

        public UpdateBlogCommandHandler(IRepository<Blog> repository)
        {
            _repository = repository;
        }
        public async Task Handle(UpdateBlogCommand request, CancellationToken cancellationToken)
        {
           var value = await _repository.GetByIdAsync(request.BlogId);
            value.AuthorId = request.AuthorId;
            value.CategoryId = request.CategoryId;
            value.Title = request.Title;
            value.CoverImageUrl = request.CoverImageUrl;
            value.CreateDate = request.CreateDate;
            await _repository.UpdateAsync(value);
        }
    }
}
