using Microsoft.EntityFrameworkCore;
using RentACar.Application.Interfaces.BlogInterfaces;
using RentACar.Domain.Entities;
using RentACar.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Persistence.Repositories.BlogRepository
{
    public class BlogRepository : IBlogRepository
    {
        private readonly RentACarContext _rentACarContext;

        public BlogRepository(RentACarContext rentACarContext)
        {
            _rentACarContext = rentACarContext;
        }
        public List<Blog> GetLastThereeBlogsWithAuthors()
        {
            var values = _rentACarContext.Blogs.Include(x=>x.Author).OrderByDescending(x=>x.BlogId).Take(3).ToList();
            return values;
        }
    }
}
