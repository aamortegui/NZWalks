using Microsoft.EntityFrameworkCore;
using NZWalks.API.Models.Domain;

namespace NZWalks.API.Data
{
    public class NZWalksDbContext : DbContext
    {
        public NZWalksDbContext(DbContextOptions<NZWalksDbContext> dbContextOptions) : base(dbContextOptions)
        {
        }

        public DbSet<Difficulty> Difficulties { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Walk> Walks { get; set; }
        public DbSet<Image> Images { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Seed data for Difficulties
            //Easy, Medium, Hard

            var difficulties = new List<Difficulty>()
            {
                new Difficulty()
                {
                    Id = Guid.Parse("2b2b5b23-d298-4750-89cb-910d3c9b8aef"),
                    Name ="Easy"
                },
                new Difficulty()
                {
                    Id = Guid.Parse("f638fa7e-1fa5-47ed-a018-ef6c52e267b2"),
                    Name ="Medium"
                },
                new Difficulty()
                {
                    Id = Guid.Parse("61c5e25e-77d9-4ed4-88c0-50564f809da9"),
                    Name ="Hard"
                }
            };
            //Seed difficulties to the database
            modelBuilder.Entity<Difficulty>().HasData(difficulties);

            //Seed data for Regions
            var regions = new List<Region>()
            {
                new Region()
                {
                    Id = Guid.Parse("3da99569-8372-4fe1-b9af-ea8ce054a3fa"),
                    Name = "Auckland",
                    Code = "AKL",
                    RegionImageUrl = "https://images.pexels.com/photos/21286407/pexels-photo-21286407/free-photo-of-mar-punto-de-referencia-oceano-viaje.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1"
                },
                new Region()
                {
                    Id = Guid.Parse("0530f273-6b0e-4f07-a03e-702ef58cfbaf"),
                    Name = "Northland",
                    Code = "NTL",
                    RegionImageUrl = null
                },
                new Region()
                {
                    Id = Guid.Parse("4e2e0bdf-3384-4351-8e7f-2d8025b5aa11"),
                    Name = "Bay Of Plenty",
                    Code = "BOP",
                    RegionImageUrl = null
                },
                new Region()
                {
                    Id = Guid.Parse("d6cad55c-4037-4dc4-b18b-d630b7213820"),
                    Name = "Wellington",
                    Code = "WGN",
                    RegionImageUrl = "https://images.pexels.com/photos/11639884/pexels-photo-11639884.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1"
                },
                new Region()
                {
                    Id = Guid.Parse("b5e3d57a-6c18-44dd-82d5-3ad0d9486312"),
                    Name = "Andres",
                    Code = "AAA",
                    RegionImageUrl = "https://images.pexels.com/photos/20759547/pexels-photo-20759547/free-photo-of-carretera-montana-vehiculo-asfalto.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1"
                },
                new Region()
                {
                    Id = Guid.Parse("29a6dd05-1dd6-4709-aafe-7b143aa7e8f2"),
                    Name = "Southland",
                    Code = "STL",
                    RegionImageUrl = null
                }
            };
            modelBuilder.Entity<Region>().HasData(regions);
        }
    }
}
