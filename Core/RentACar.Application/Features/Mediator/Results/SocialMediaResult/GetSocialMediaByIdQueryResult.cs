﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Application.Features.Mediator.Results.SocialMediaResult
{
    public class GetSocialMediaByIdQueryResult
    {
        public int SocialMediaId { get; set; }

        public string Name { get; set; }

        public string Url { get; set; }
        public string Icon { get; set; }
    }
}
