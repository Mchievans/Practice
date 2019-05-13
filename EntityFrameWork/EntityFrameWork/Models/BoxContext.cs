using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace EntityFrameWork.Models
{
    public class BoxContext : DbContext
    {
        public BoxContext(DbContextOptions<BoxContext> options)
           : base(options) { }

        public DbSet<Matchbox> Matchboxes { get; set; }
        public DbSet<Lunchbox> Lunchboxes { get; set; }

        public BoxContext CreateDbContext(string[] args) =>
             Program.BuildWebHost(args).Services
                 .GetRequiredService<BoxContext>();
    }
}
