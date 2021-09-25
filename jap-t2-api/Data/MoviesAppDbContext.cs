using JAP_Task_1_MoviesApi.Extensions;
using JAP_Task_1_MoviesApi.Models;
using Microsoft.EntityFrameworkCore;
using MoviesApp.Api.Entities;

namespace JAP_Task_1_MoviesApi.Data
{
    public class MoviesAppDbContext : DbContext
    {
        public MoviesAppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<UserEntity> Users { get; set; }
        public DbSet<VideoEntity> Videos { get; set; }
        public DbSet<ActorEntity> Actors { get; set; }
        public DbSet<RatingEntity> Ratings { get; set; }
        public DbSet<ScreeningEntity> Screenings { get; set; }
        public DbSet<TicketEntity> Tickets { get; set; }
        public DbSet<MostRatedVideoEntity> MostRatedVideos { get; set; }
        public DbSet<VideosWithMostScreeningsEntity> VideosWithMostScreenings { get; set; }
        public DbSet<VideosWithMostSoldTicketsEntity> VideosWithMostSoldTickets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();

            modelBuilder.Entity<MostRatedVideoEntity>().HasNoKey();
            modelBuilder.Entity<VideosWithMostScreeningsEntity>().HasNoKey();
            modelBuilder.Entity<VideosWithMostSoldTicketsEntity>().HasNoKey();
        }
    }
}
