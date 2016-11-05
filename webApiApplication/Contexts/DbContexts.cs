using HiFive.Models;
using Microsoft.EntityFrameworkCore;

namespace HiFive.Contexts 
{
    public class HiFiveContext : DbContext
    {
        public HiFiveContext(DbContextOptions<HiFiveContext> options) : base(options) { }
        public HiFiveContext() { }

        // dbsets in here
        public DbSet<HiFiveRecord> HiFiveRecords { get; set; }
    }
}