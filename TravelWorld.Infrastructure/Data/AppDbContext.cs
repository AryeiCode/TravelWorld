using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelWorld.Domain.Entities;

namespace TravelWorld.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<CountryHouse> CountryHouses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<CountryHouse>().HasData(
            new CountryHouse
            {
                Id = 1,
                Name = "Royal CountryHouse",
                Description = "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                ImageUrl = "https://placehold.co/600x400",
                Occupancy = 4,
                Price = 200,
                Sqft = 550,
            },
            new CountryHouse
            {
                Id = 2,
                Name = "Premium Pool CountryHouse",
                Description = "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                ImageUrl = "https://placehold.co/600x401",
                Occupancy = 4,
                Price = 300,
                Sqft = 550,
            },
            new CountryHouse
            {
                Id = 3,
                Name = "Luxury Pool CountryHouse",
                Description = "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                ImageUrl = "https://placehold.co/600x402",
                Occupancy = 4,
                Price = 400,
                Sqft = 750,
            });
        }
    }
}
