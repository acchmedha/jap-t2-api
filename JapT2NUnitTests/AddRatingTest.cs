using JAP_Task_1_MoviesApi.Data;
using JAP_Task_1_MoviesApi.Entities;
using JAP_Task_1_MoviesApi.Services;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAP_Task_1_MoviesApi
{
    [TestFixture]
    public class AddRatingTest
    {
        MoviesAppDbContext _context;
        IRatingService _ratingsService;

        [SetUp]
        public async Task SetupAsync()
        {
            // database setup
            var options = new DbContextOptionsBuilder<MoviesAppDbContext>()
                .UseInMemoryDatabase(databaseName: "temp_moviesapp4")
                .Options;

            _context = new MoviesAppDbContext(options);

            // - add data

            AuthService.CreatePasswordHash("admin", out byte[] passHashAdmin, out byte[] passSaltAdmin);
            _context.Users.Add(
                new UserEntity
                {
                    Id = 1,
                    Username = "admin",
                    FirstName = "Admin",
                    LastName = "Admin",
                    PasswordSalt = passSaltAdmin,
                    PasswordHash = passHashAdmin
                }
            );
            AuthService.CreatePasswordHash("user", out byte[] passHashUser, out byte[] passSaltUser);
            _context.Users.Add(
                new UserEntity
                {
                    Id = 2,
                    Username = "user",
                    FirstName = "User",
                    LastName = "User",
                    PasswordSalt = passSaltUser,
                    PasswordHash = passHashUser
                }
            );

            _context.Videos.Add(new VideoEntity
            {
                Id = 1,
                Title = "The Shawshank Redemption",
                Overview = "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.",
                PosterPath = "https://swank.azureedge.net/swank/prod-film/3560cd8a-9491-4ab9-876c-8a8d6b84a6dd/f8e7c904-669a-4c9f-ac29-d19b64b43e33/one-sheet.jpg?width=335&height=508&mode=crop",
                Type = 0,
                ReleaseDate = new DateTime(1994, 9, 22),
                Ratings = new List<RatingEntity>
                {
                    new RatingEntity { Id = 1, Value = 4.6, VideoEntityId = 1, UserEntityId = 1 },
                    new RatingEntity { Id = 2, Value = 4, VideoEntityId = 1, UserEntityId = 1 }
                }
            });

            _context.Videos.Add(new VideoEntity
            {
                Id = 2,
                Title = "The Godfather",
                Overview = "An organized crime dynasty's aging patriarch transfers control of his clandestine empire to his reluctant son.",
                PosterPath = "https://www.reelviews.net/resources/img/posters/thumbs/godfather_poster.jpg",
                Type = 0,
                ReleaseDate = new DateTime(1972, 3, 24),
                Ratings = new List<RatingEntity>
                {
                    new RatingEntity { Id = 3, Value = 2.6, VideoEntityId = 2, UserEntityId = 1 }
                }
            });
            _context.Videos.Add(new VideoEntity
            {
                Id = 3,
                Title = "The Godfather: Part II",
                Overview = "The early life and career of Vito Corleone in 1920s New York City is portrayed, while his son, Michael, expands and tightens his grip on the family crime syndicate.",
                PosterPath = "https://shotonwhat.com/images/0071562-med.jpg",
                Type = 0,
                ReleaseDate = new DateTime(1974, 12, 20),
                Ratings = new List<RatingEntity>
                {
                    new RatingEntity { Id = 4, Value = 3.6, VideoEntityId = 3, UserEntityId = 1 }
                }
            });

            await _context.SaveChangesAsync();

            // --------------

            _ratingsService = new RatingService(_context);
        }
        [TearDown]
        public async Task TearDownAsync()
        {
            await _context.Database.EnsureDeletedAsync();
        }

        [Test]
        public async Task AddRatingTest_InputValidRatingAdd_ReturnTrue()
        {
            var response = await _ratingsService.AddRating(4.1, 1, 2);

            //Is the rating added?
            Assert.IsTrue(response);

            var ratingAfter = (await _context.Ratings.Where(x => x.VideoEntityId == 1).ToListAsync()).Average(x => x.Value);

            Assert.AreEqual(4.3F, ratingAfter, .1);
        }

        [Test]
        public async Task AddRatingTest_InputInValidRatingAdd_ReturnFalse()
        {
            var response1 = await _ratingsService.AddRating(4.1, 2, 2);

            //Is the rating added?
            //first one needs to be added
            Assert.IsTrue(response1);

            //second time it shouldn't. one user cannot rate the same film/show twice!
            try
            {
                var response2 = await _ratingsService.AddRating(4.1, 2, 2);
            }
            catch (Exception e)
            {
                Assert.AreEqual(e.Message, "You already rated this item");
            }

            var ratingAfter = (await _context.Ratings.Where(x => x.VideoEntityId == 1).ToListAsync()).Average(x => x.Value);

            Assert.AreEqual(4.3F, ratingAfter, .1);
        }
    }
}
