﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Application.Features.Queries.CarQueries
{
    public class GetCarByIdQuery
    {
        public int Id { get; set; }

        public GetCarByIdQuery(int id)
        {
            Id= id;
        }
    }
}