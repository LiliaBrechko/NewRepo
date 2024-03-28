using GYM.Models;
using Microsoft.EntityFrameworkCore;

namespace GYM.Infrastructure
{
    public class DBContextGym : DbContext
    {
        public DbSet<Profile> Profiles { get; set; } = null!;

        public DbSet<Exercise> Exercises { get; set; } = null!;

        public DbSet<Set> Sets { get; set; } = null!;

        public DbSet<TrainingSession> TrainingSessions { get; set; } = null!;

        public DbSet<BodyWeight> BodyWeights { get; set; } = null!;

        //public DBContextGym()
        //{
        //    if (!File.Exists("GYMDatabase.db"))
        //    {
        //        Database.EnsureCreated();
        //    }
        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlite("Data Source = GYMDatabase.db");
            optionsBuilder.UseSqlite("Data Source = \"E:\\CommonRepository\\LiliaStudy\\GYM.Infrastructure\\GYMDatabase.db\"");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Exercise>()
                .HasIndex(e => new { e.Name, e.ProfileId })
                .HasDatabaseName("UX_GYM_EXERCISE")
                .IsUnique();

            modelBuilder.Entity<Profile>()
                .HasIndex(e => new { e.Name })
                .HasDatabaseName("UX_GYM_PROFILE")
                .IsUnique();

            modelBuilder.Entity<Profile>()
                .HasMany(p => p.BodyWeights)
                .WithOne(p => p.Profile)
                .HasForeignKey(p => p.ProfileId);

            modelBuilder.Entity<Profile>()
                .HasMany(p => p.Exercises)
                .WithOne(p => p.Profile)
                .HasForeignKey(p => p.ProfileId);

            modelBuilder.Entity<Profile>()
                .HasMany(p => p.TrainingSessions)
                .WithOne(p => p.Profile)
                .HasForeignKey(p => p.ProfileId);

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

            modelBuilder.Entity<Exercise>()
                .HasOne(p => p.Profile)
                .WithMany(c => c.Exercises)
                .HasForeignKey(p => p.ProfileId);

            modelBuilder.Entity<TrainingSession>()
                .HasOne(p => p.Profile)
                .WithMany(c => c.TrainingSessions)
                .HasForeignKey(p => p.ProfileId);

            modelBuilder.Entity<BodyWeight>()
                .HasOne(p => p.Profile)
                .WithMany(c => c.BodyWeights)
                .HasForeignKey(p => p.ProfileId);
        }
    }
}