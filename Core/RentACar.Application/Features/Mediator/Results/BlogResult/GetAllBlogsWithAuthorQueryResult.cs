using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Application.Features.Mediator.Results.BlogResult
{
    public class GetAllBlogsWithAuthorQueryResult
    {
        public int BlogId { get; set; }

        public string Title { get; set; }
        public int AuthorId { get; set; }

        public string AuthorName { get; set; }
    

        public string CoverImageUrl { get; set; }

        public DateTime CreateDate { get; set; }

       

        public string? Description { get; set; }
    }
}
