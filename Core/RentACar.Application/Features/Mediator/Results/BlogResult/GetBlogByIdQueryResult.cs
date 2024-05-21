﻿using RentACar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Application.Features.Mediator.Results.BlogResult
{
    public class GetBlogByIdQueryResult
    {
        public int BlogId { get; set; }

        public string Title { get; set; }
        public int AuthorId { get; set; }

       

        public string CoverImageUrl { get; set; }

        public DateTime CreateDate { get; set; }

        public int CategoryId { get; set; }

        
    }
}
