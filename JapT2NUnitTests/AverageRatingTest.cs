using AutoMapper;
using AutoMapper.Configuration;
using JAP_Task_1_MoviesApi.Data;
using JAP_Task_1_MoviesApi.Entities;
using JAP_Task_1_MoviesApi.Helpers;
using JAP_Task_1_MoviesApi.Models;
using JAP_Task_1_MoviesApi.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IConfiguration = Microsoft.Extensions.Configuration.IConfiguration;

namespace JAP_Task_1_MoviesApi
{
    [TestFixture]
    public class AverageRatingTest
    {
        MoviesAppDbContext _context;
        IVideoService _videoService;
        IMapper _mapper;

        [SetUp]
        public async Task OneTimeSetupAsync()
        {
            // database setup
            var options = new DbContextOptionsBuilder<MoviesAppDbContext>()
                .UseInMemoryDatabase(databaseName: "temp_moviesapp2")
                .Options;

            _context = new MoviesAppDbContext(options);

            // - add data

            _context.Videos.Add(new VideoEntity
            {
                Id = 1,
                Title = "The Shawshank Redemption",
                Overview = "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.",
                PosterPath = "https://swank.azureedge.net/swank/prod-film/3560cd8a-9491-4ab9-876c-8a8d6b84a6dd/f8e7c904-669a-4c9f-ac29-d19b64b43e33/one-sheet.jpg?width=335&height=508&mode=crop",
                Type = VideoEnum.Movie,
                ReleaseDate = new DateTime(1994, 9, 22),
                Actors = new List<ActorEntity>
                {
                    new ActorEntity { Id = 1, FirstName = "Morgan", LastName = "Freeman" },
                    new ActorEntity { Id = 2, FirstName = "Bob", LastName = "Gunton" },
                },
                Ratings = new List<RatingEntity>
                {
                    new RatingEntity { Id = 1, Value = 4.6, VideoEntityId = 1, UserEntityId = 1 },
                    new RatingEntity { Id = 2, Value = 3.6, VideoEntityId = 1, UserEntityId = 1 },
                    new RatingEntity { Id = 3, Value = 4.1, VideoEntityId = 1, UserEntityId = 1 }
                }
            });
            _context.Videos.Add(new VideoEntity
            {
                Id = 2,
                Title = "The Godfather",
                Overview = "An organized crime dynasty's aging patriarch transfers control of his clandestine empire to his reluctant son.",
                PosterPath = "https://www.reelviews.net/resources/img/posters/thumbs/godfather_poster.jpg",
                Type = VideoEnum.Movie,
                ReleaseDate = new DateTime(1972, 3, 24),
                Actors = new List<ActorEntity>
                {
                    new ActorEntity { Id = 3, FirstName = "Morgan", LastName = "Freeman" },
                    new ActorEntity { Id = 4, FirstName = "Bob", LastName = "Gunton" }
                },
                Ratings = new List<RatingEntity>
                {
                    new RatingEntity { Id = 4, Value = 4.4, VideoEntityId = 2, UserEntityId = 1 }
                }
            });
            _context.Videos.Add(new VideoEntity
            {
                Id = 3,
                Title = "The Godfather: Part II",
                Overview = "The early life and career of Vito Corleone in 1920s New York City is portrayed, while his son, Michael, expands and tightens his grip on the family crime syndicate.",
                PosterPath = "https://shotonwhat.com/images/0071562-med.jpg",
                Type = VideoEnum.Movie,
                ReleaseDate = new DateTime(1974, 12, 20),
                Actors = new List<ActorEntity>
                {
                    new ActorEntity { Id = 5, FirstName = "Morgan", LastName = "Freeman" },
                    new ActorEntity { Id = 6, FirstName = "Bob", LastName = "Gunton" }
                },
                Ratings = new List<RatingEntity>()
            });

            await _context.SaveChangesAsync();

            // --------------

            IConfiguration configuration = new ConfigurationBuilder().Build();

            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new AutoMapperProfiles());
            });
            _mapper = mappingConfig.CreateMapper();

            _videoService = new VideoService(_context, _mapper);
        }

        [TearDown]
        public async Task TearDownAsync()
        {
            await _context.Database.EnsureDeletedAsync();
        }

        [Test]
        public async Task RatingTest_NormalCase_ReturnsValid()
        {
            var videosList = (await _videoService.GetVideos(VideoEnum.Movie, new())).Data;

            var film1 = videosList.Find(x => x.Id == 1);
            Assert.AreEqual(4.10, film1.AverageRating, .1);
        }
        [Test]
        public async Task RatingTest_NoRatings_Returns0()
        {
            var videosList = (await _videoService.GetVideos(VideoEnum.Movie, new())).Data;

            var film1 = videosList.Find(x => x.Id == 3);
            Assert.AreEqual(0, film1.AverageRating);
        }

        [Test]
        public async Task RatingTest_RangeCheck_ReturnsNumberPositiveOrZero()
        {
            var videosList = (await _videoService.GetVideos(VideoEnum.Movie, new())).Data;

            // every average rating needs to be between 0 and 5 (0 and 5 are included)
            videosList.ForEach(x =>
            {
                Assert.IsTrue(x.AverageRating >= 0 && x.AverageRating <= 5);
            });

        }

    }
}
