using JAP_Task_1_MoviesApi.Extensions;
using JAP_Task_1_MoviesApi.Models;
using Microsoft.EntityFrameworkCore;

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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
        }
    }
}
