using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameApp.Models;
using Microsoft.EntityFrameworkCore;


namespace GameApp.Data
{
    public class GameAppContext : DbContext
    {
        public GameAppContext(DbContextOptions<GameAppContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Game>(entity =>
            {
                entity.HasMany<Review>().WithOne(a => a.Game).HasForeignKey(a => a.GameId);
            });
            modelBuilder.Entity<Review>(entity =>
            {
                entity.HasOne<Game>().WithMany(a => a.Reviews);
            });
        }
        public DbSet<GameApp.Models.Game> Game { get; set; } = default!;
        public DbSet<GameApp.Models.Review> Review { get; set; } = default!;

    }
}