using MediatR;
using RentACar.Application.Features.Mediator.Queries.BlogQueries;
using RentACar.Application.Features.Mediator.Results.BlogResult;
using RentACar.Application.Interfaces.BlogInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Application.Features.Mediator.Handlers.BlogHandlers
{
    public class GetAllBlogsWithAuthorQueryHandler : IRequestHandler<GetAllBlogsWithAuthorQuery, List<GetAllBlogsWithAuthorQueryResult>>
    {
        private readonly IBlogRepository _repository;

        public GetAllBlogsWithAuthorQueryHandler(IBlogRepository repository)
        {
            _repository = repository;
        }
        public async Task<List<GetAllBlogsWithAuthorQueryResult>> Handle(GetAllBlogsWithAuthorQuery request, CancellationToken cancellationToken)
        {
            var values = _repository.GetAllBlogsWithAuthor();
            return values.Select(x=> new GetAllBlogsWithAuthorQueryResult
            {
                AuthorId = x.AuthorId,
                AuthorName =x.Author.Name,
                BlogId = x.BlogId,
               
                CoverImageUrl = x.CoverImageUrl,
                CreateDate = x.CreateDate,
                Title=x.Title,
                Description=x.Description ?? "No Description Avaible"
               
            }).ToList();

        }
    }
}
