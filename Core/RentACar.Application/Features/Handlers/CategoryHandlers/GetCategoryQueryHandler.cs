﻿using RentACar.Application.Features.Results.CategoryResult;
using RentACar.Application.Interfaces;
using RentACar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Application.Features.Handlers.CategoryHandlers
{
    public class GetCategoryQueryHandler
    {
        private readonly IRepository<Category> _repository;

        public GetCategoryQueryHandler(IRepository<Category> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetCategoryQueryResult>> Handle()
        {
            var values = await _repository.GetAllAsync();

            return values.Select(x => new GetCategoryQueryResult{
                Name = x.Name,
                CategoryId = x.CategoryId,
            }).ToList();    

        }
    }
}
