using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameWorkDataAccessApproach
{
    class BoxContext : DbContext 
    {
        public BoxContext(DbContextOptions<BoxContext> options)
                 : base(options) { }

        public DbSet<MatchBox> Matchboxes { get; set; }
        public DbSet<LunchBox> Lunchboxes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("dbo");
            modelBuilder.ApplyConfiguration(new MatchBoxConfiguration());
            modelBuilder.ApplyConfiguration(new LunchBoxConfiguration());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("connectionstring");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
