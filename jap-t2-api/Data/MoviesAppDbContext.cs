using JAP_Task_1_MoviesApi.Entities;
using JAP_Task_1_MoviesApi.Extensions;
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
        public DbSet<MostRatedMoviesEntity> MostRatedVideos { get; set; }
        public DbSet<MoviesWithMostScreeningsEntity> VideosWithMostScreenings { get; set; }
        public DbSet<MoviesWithMostSoldTicketsEntity> VideosWithMostSoldTickets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();

            modelBuilder.Entity<MostRatedMoviesEntity>().HasNoKey();
            modelBuilder.Entity<MoviesWithMostScreeningsEntity>().HasNoKey();
            modelBuilder.Entity<MoviesWithMostSoldTicketsEntity>().HasNoKey();
        }
    }
}
