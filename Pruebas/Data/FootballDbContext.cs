using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using System.Drawing;
using Pruebas.Controllers;
using Pruebas.Models;

namespace Pruebas.Data
{
    public class FootballDbContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(@"User ID = postgres; Password = 1234; Host = localhost; Port = 5432; Database = PruebaFutbol;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new Mappings.TeamEntityConfiguration());
            modelBuilder.ApplyConfiguration(new Mappings.LeagueEntityConfiguration());
            modelBuilder.ApplyConfiguration(new Mappings.MatchEntityConfiguration());
        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<League> Leagues { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Match> Matches { get; set; }

    }
}
