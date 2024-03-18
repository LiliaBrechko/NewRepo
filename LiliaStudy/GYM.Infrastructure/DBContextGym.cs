using GYM.Models;
using Microsoft.EntityFrameworkCore;

namespace GYM.Infrastructure
{
    public class DBContextGym : DbContext
    {
        public DbSet<Exercise> Exercises { get; set; } = null!;

        public DbSet<Set> Sets { get; set; } = null!;

        public DbSet<TrainingSession> TrainingSessions { get; set; } = null!;

        public DbSet<BodyWeight> BodyWeights { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = \"E:\\CommonRepository\\LiliaStudy\\GYM.Infrastructure\\GYMDatabase.db\"");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Exercise>()
                .HasIndex(e => new { e.Name })
                .HasDatabaseName("UX_GYM_EXERCISE")
                .IsUnique();

            modelBuilder.Entity<TrainingSession>()
                .HasMany(p => p.Sets)
                .WithOne(p => p.TrainingSession)
                .HasForeignKey(p => p.TrainingSessionId);

            modelBuilder.Entity<Set>()
                .HasOne(p => p.TrainingSession)
                .WithMany(c => c.Sets)
                .HasForeignKey(p => p.TrainingSessionId);

            modelBuilder.Entity<Set>()
                .HasOne(p => p.Exercise)
                .WithMany(c => c.Sets)
                .HasForeignKey(p => p.ExerciseId);

            modelBuilder.Entity<Exercise>()
                .HasMany(p => p.Sets)
                .WithOne(c => c.Exercise)
                .HasForeignKey(p => p.ExerciseId);
        }
    }
}