using APTask2.Entities;
using APTask2.Migrations;
using System.Data.Entity;

namespace APTask2.DAL
{
    public class APTaskDbContext : DbContext
    {
        public APTaskDbContext() : base("DatabaseConnection")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<APTaskDbContext, Configuration>());
        }

        public DbSet<InventLocation> InventLocations { get; set; }
        public DbSet<InventDim> InventDims { get; set; }
    }
}
