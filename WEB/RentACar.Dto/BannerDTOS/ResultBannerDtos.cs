﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Dto.BannerDTOS
{
    public class ResultBannerDtos
    {
        public int BannerId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }
        public string VideoDescription { get; set; }

        public string VideoUrl { get; set; }
    }
}
