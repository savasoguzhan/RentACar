﻿using RentACar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Application.Interfaces.BlogInterfaces
{
    public interface IBlogRepository
    {
        public List<Blog> GetLastThereeBlogsWithAuthors();

        public List<Blog> GetAllBlogsWithAuthor();
    }
}
