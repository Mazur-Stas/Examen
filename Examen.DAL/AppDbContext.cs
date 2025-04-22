using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Examen.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace Examen.DAL.Data
{
    public class AppDbContext : DbContext
    {
        //private string _connectionString = "Data Source = (localdb)\\MSSQLLocalDB;Initial Catalog = UN; Integrated Security = True; Connect Timeout = 30;";
        public DbSet<Team> Teams { get; set; }
        public DbSet<Match> Matches { get; set; }
        public DbSet<Tournament> Tournaments { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connection = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsetting.json")
                .Build();


            var _connectionString = connection.GetConnectionString("DefaultConnection");
            optionsBuilder.UseSqlServer(_connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {



          modelBuilder.Entity<Match>()
                .HasKey(m => new { m.Team1Id , m.Team2Id , m.TournamentId });

            modelBuilder.Entity<Match>()
                .HasOne(m => m.Tournament)
                .WithMany(m => m.Matches)
                .HasForeignKey(m => m.TournamentId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Match>()
                .HasOne(m => m.Team1)
                .WithMany(m => m.HomeMatches)
                .HasForeignKey(m => m.TournamentId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Match>()
                .HasOne(m => m.Team2)
                .WithMany(m => m.AwayMatches)
                .HasForeignKey(m => m.TournamentId)
                .OnDelete(DeleteBehavior.Restrict);


        }
    }
}