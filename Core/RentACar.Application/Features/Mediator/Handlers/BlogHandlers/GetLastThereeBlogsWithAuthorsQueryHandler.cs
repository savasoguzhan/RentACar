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
    public class GetLastThereeBlogsWithAuthorsQueryHandler : IRequestHandler<GetLastThereeBlogsWithAuthorsQuery, List<GetLastThereeBlogsWithAuthorsQueryResult>>
    {
        private readonly IBlogRepository _blogRepository;

        public GetLastThereeBlogsWithAuthorsQueryHandler(IBlogRepository blogRepository)
        {
            _blogRepository = blogRepository;
        }

        public async Task<List<GetLastThereeBlogsWithAuthorsQueryResult>> Handle(GetLastThereeBlogsWithAuthorsQuery request, CancellationToken cancellationToken)
        {
            var values =   _blogRepository.GetLastThereeBlogsWithAuthors();

            return values.Select(x => new GetLastThereeBlogsWithAuthorsQueryResult
            {
                AuthorId = x.AuthorId,
                BlogId = x.BlogId,
                CategoryId = x.CategoryId,
                CoverImageUrl = x.CoverImageUrl,
                CreateDate = x.CreateDate,
                Title = x.Title,
                AuthorName=x.Author.Name
            }).ToList();
        }
    }
}
