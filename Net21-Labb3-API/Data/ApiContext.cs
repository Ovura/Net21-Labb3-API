using Microsoft.EntityFrameworkCore;
using Net21_Labb3_API.Models;

namespace Net21_Labb3_API.Data
{
    public class ApiContext : DbContext
    {

        public DbSet<Person> People { get; set; }
        public DbSet<Website> Websites { get; set; }
        public DbSet<Interest> Interests { get; set; }

        public ApiContext(DbContextOptions<ApiContext> options) :base(options)
        {

        }

        //Dummy Data
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().HasData(
                new Person { Id = 1, Name = "James Brown" },
                new Person { Id = 2, Name = "Tom Cruise" },
                new Person { Id = 3, Name = "Peter Pan" }
                );
            modelBuilder.Entity<Interest>().HasData(
                new { InterestId = 1, Title = "Swimming",Description = "Fresstyle swimming", Id = 3 },
                new { InterestId = 2, Title = "Cycling", Description = "Mx Mountain Bikes and Motorcycle racing", Id = 1 },
                new { InterestId = 3, Title = "Fishing", Description = "Deep Sea and hobby Fishing", Id = 2 }
                );
            modelBuilder.Entity<Website>().HasData(
                new { Id = 1, Description = "For those who love Fishing", InterestId = 3, Url = "https://www.etsy.com/market/fishing_lovers" },
                new { Id = 2, Description = "Motorsports", InterestId = 2, Url = "https://www.topendsports.com/sport/cycling-sports.htm" },
                new { Id = 3, Description = "The best male swimmers", InterestId = 1, Url = "https://www.swimmingworldmagazine.com/news/ranking-the-best-mens-swimmers-in-the-world-from-1-25-as-olympic-year-arrives/" },
                new { Id = 4, Description = "Top 10 Swimmers of all time. ", InterestId = 1, Url = "https://www.waterworksswim.com/swim-library/detail/2014-09-05-top-10-swimmers-of-all-time-post-378" }
                );


        }
    }
}
