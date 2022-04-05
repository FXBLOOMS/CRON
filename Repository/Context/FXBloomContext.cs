using Microsoft.EntityFrameworkCore;
using Repository.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Context
{
    public class FXBloomContext : DbContext
    {
        public FXBloomContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Listing> Listing { get; set; }
        public DbSet<Bid> Bid { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
