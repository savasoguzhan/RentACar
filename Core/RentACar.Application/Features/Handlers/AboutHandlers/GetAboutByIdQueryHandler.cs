﻿using RentACar.Application.Features.Queries.AboutQueries;
using RentACar.Application.Features.Results.AboutResult;
using RentACar.Application.Interfaces;
using RentACar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Application.Features.Handlers.AboutHandlers
{
    public class GetAboutByIdQueryHandler
    {
        private readonly IRepository<About> _repository;

        public GetAboutByIdQueryHandler(IRepository<About> repository)
        {
            _repository = repository;
        }

        public async Task<GetAboutByIdQueryResult> Handler(GetAboutByIdQuery query)
        {
            var values =  await _repository.GetByIdAsync(query.Id);
            return new GetAboutByIdQueryResult
            {
                AboutId = values.AboutId,
                Description = values.Description,
                ImageUrl= values.ImageUrl,
                Title = values.Title,
            };
        }
    }
}
