using Electricity.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Electricity.Api.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        DbSet<City> Cities { get; set; }
        DbSet<Zone> Zones { get; set; }
        DbSet<Spreadsheet> Spreadsheets { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<City>().HasData(
                new City { Id = 1, Name = "Київ" },
                new City { Id = 2, Name = "Львів" },
                new City { Id = 3, Name = "Одеса" },
                new City { Id = 4, Name = "Дніпро" },
                new City { Id = 5, Name = "Харків" }
            );

            modelBuilder.Entity<Zone>().HasData(
                new Zone { Id = 1, CityId = 1, ZoneKey = 1 },
                new Zone { Id = 2, CityId = 1, ZoneKey = 2 },

                new Zone { Id = 3, CityId = 2, ZoneKey = 1 },
                new Zone { Id = 4, CityId = 2, ZoneKey = 2 },

                new Zone { Id = 5, CityId = 3, ZoneKey = 1 },
                new Zone { Id = 6, CityId = 3, ZoneKey = 2 },

                new Zone { Id = 7, CityId = 4, ZoneKey = 1 },
                new Zone { Id = 8, CityId = 4, ZoneKey = 2 },

                new Zone { Id = 9, CityId = 5, ZoneKey = 1 },
                new Zone { Id = 10, CityId = 5, ZoneKey = 2 }
            );

            DateTime startDate = DateTime.Now.Date;
            List<Spreadsheet> spreadsheets = new List<Spreadsheet>();

            int cityIdKyiv = 1;
            int group1Id = 1;
            int group2Id = 2;

            for (int i = 0; i < 7; i++)
            {
                DateTime date = startDate.AddDays(i);
                string dayName = date.ToString("dddd");

                spreadsheets.Add(new Spreadsheet
                {
                    Id = i * 2 + 1,
                    CityId = cityIdKyiv,
                    GroupId = group1Id,
                    Date = date,
                    DateName = dayName,
                    Hour00 = false,
                    Hour01 = false,
                    Hour02 = false,
                    Hour03 = false,
                    Hour04 = true,
                    Hour05 = true,
                    Hour06 = true,
                    Hour07 = false,
                    Hour08 = false,
                    Hour09 = false,
                    Hour10 = true,
                    Hour11 = true,
                    Hour12 = false,
                    Hour13 = false,
                    Hour14 = false,
                    Hour15 = false,
                    Hour16 = true,
                    Hour17 = true,
                    Hour18 = false,
                    Hour19 = false,
                    Hour20 = true,
                    Hour21 = true,
                    Hour22 = false,
                    Hour23 = false
                });

                spreadsheets.Add(new Spreadsheet
                {
                    Id = i * 2 + 2,
                    CityId = cityIdKyiv,
                    GroupId = group2Id,
                    Date = date,
                    DateName = dayName,
                    Hour00 = true,
                    Hour01 = true,
                    Hour02 = false,
                    Hour03 = false,
                    Hour04 = false,
                    Hour05 = true,
                    Hour06 = true,
                    Hour07 = false,
                    Hour08 = false,
                    Hour09 = true,
                    Hour10 = true,
                    Hour11 = false,
                    Hour12 = false,
                    Hour13 = true,
                    Hour14 = true,
                    Hour15 = false,
                    Hour16 = false,
                    Hour17 = true,
                    Hour18 = true,
                    Hour19 = false,
                    Hour20 = false,
                    Hour21 = true,
                    Hour22 = true,
                    Hour23 = false
                });
            }

            modelBuilder.Entity<Spreadsheet>().HasData(spreadsheets);
        }
    }
}
