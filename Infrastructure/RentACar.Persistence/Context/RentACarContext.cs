﻿using Microsoft.EntityFrameworkCore;
using RentACar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Persistence.Context
{
    public class RentACarContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;initial Catalog=RentACarDb; integrated Security=true;TrustServerCertificate=true");
        }

        public DbSet<About> Abouts { get; set; }
        public DbSet<Banner> Banners { get; set; }

        public DbSet<Brand> Brands { get; set; }

        public DbSet<Car> Cars { get; set; }

        public DbSet<CarDescription> CarsDescriptions { get; set; }

        public DbSet<CarFeature> CarsFeatures { get; set; }

        public DbSet<CarPricing> CarsPricings { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Contact> Contacts { get; set; }

        public DbSet<Feature> Features { get; set; }

        public DbSet<FooterAdress> FooterAdresses { get; set;}

        public DbSet<Location> Locations { get; set; }

        public DbSet<Pricing> Pricings { get; set; }

        public DbSet<Service> Services { get; set; }

        public DbSet<SocialMedia> SocialMedias { get; set; }

        public DbSet<Testimonial> Testimonials { get; set;}

        public DbSet<Author> Authors { get; set; }

        public DbSet<Blog> Blogs { get; set; }

    }
}
