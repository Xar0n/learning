using DAL.Fakers;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Data
{
    public class LearningContext: DbContext
    {
        public DbSet<Offer> Offers { get; set; }
        public DbSet<FileDescription> FileDescriptions { get; set; }

        public LearningContext(DbContextOptions<LearningContext> options) : base(options)
        { 
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Offer>().HasOne(p => p.Photo).WithOne(o => o.Offer);
            // builder.Entity<Offer>().Navigation(p => p.Photo).AutoInclude();
            // builder.Entity<FileDescription>().HasOne(o => o.Offer).WithOne(p => p.Photo).IsRequired();

            OfferFaker offerFaker = new OfferFaker();
            builder.Entity<Offer>().HasData(offerFaker.Generate(500));
            base.OnModelCreating(builder);
        }
    }
}
