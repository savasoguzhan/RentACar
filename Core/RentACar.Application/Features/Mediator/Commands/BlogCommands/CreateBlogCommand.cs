﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Application.Features.Mediator.Commands.BlogCommands
{
    public class CreateBlogCommand : IRequest
    {
       

        public string Title { get; set; }
        public int AuthorId { get; set; }



        public string CoverImageUrl { get; set; }

        public DateTime CreateDate { get; set; }

        public int CategoryId { get; set; }
    }
}
