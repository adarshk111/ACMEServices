using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ACME.Services.DAL.Models
{
    public class InvestorContext : DbContext
    {
        public InvestorContext(DbContextOptions<InvestorContext> options)
            : base(options)
        { }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Post> Posts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>().HasData(
                new Country() { CountryId = 1, CountryName = "Australia", CountryCode = "AU" },
                new Country() { CountryId = 2, CountryName = "New Zealand", CountryCode = "NZ" },
                new Country() { CountryId = 3, CountryName = "Antarctica", CountryCode = "AQ" },
                 new Country() { CountryId = 4, CountryName = "Argentina", CountryCode = "AR" },
                  new Country() { CountryId = 5, CountryName = "Brazil", CountryCode = "BR" }
                );

            modelBuilder.Entity<Post>().HasData(
                new Post() { ID = 50, Pcode = "0822", Locality = "ACACIA HILLS", State = "NT", Category = "DeliveryArea" },
                new Post() { ID = 55, Pcode = "2601", Locality = "ACTON", State = "ACT", Category = "DeliveryArea" },
                new Post() { ID = 60, Pcode = "2850", Locality = "AARONS PASS", State = "NSW", Category = "DeliveryArea" },
                new Post() { ID = 65, Pcode = "3737", Locality = "ABBEYARD", State = "VIC", Category = "DeliveryArea" });
        }
    }

    public class Country
    {
        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public string CountryCode { get; set; }
    }

    public class Post
    {
        public int ID { get; set; }
        public string Pcode { get; set; }
        public string Locality { get; set; }

        public string State { get; set; }
        public string Comments { get; set; }
        public string DeliveryOffice { get; set; }
        public string PreSortIndicator { get; set; }
        public string ParcelZone { get; set; }
        public string BSPName { get; set; }
        public string Category { get; set; }
    }

    
}
