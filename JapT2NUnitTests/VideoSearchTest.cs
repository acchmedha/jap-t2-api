using AutoMapper;
using AutoMapper.Configuration;
using JAP_Task_1_MoviesApi.Data;
using JAP_Task_1_MoviesApi.Entities;
using JAP_Task_1_MoviesApi.Helpers;
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
    public class VideoSearchTest
    {
        MoviesAppDbContext _context;
        IVideoService _videoService;
        IMapper _mapper;

        [SetUp]
        public async Task OneTimeSetupAsync()
        {
            // database setup
            var options = new DbContextOptionsBuilder<MoviesAppDbContext>()
                .UseInMemoryDatabase(databaseName: "temp_moviesapp3")
                .Options;

            _context = new MoviesAppDbContext(options);

            // - add data

            AuthService.CreatePasswordHash("admin", out byte[] passHash, out byte[] passSalt);
            _context.Users.Add(
                new UserEntity
                {
                    Id = 1,
                    Username = "admin",
                    FirstName = "Admin",
                    LastName = "Admin",
                    PasswordSalt = passSalt,
                    PasswordHash = passHash
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
        public async Task MediaSearchTests_InputNormalFilmTitle_ReturnListOf1()
        {
            var list = (await _videoService.GetFilteredVideos("The s")).Data;

            foreach (var i in list) Console.WriteLine(i.Title);

            //should only be one from the three given movies
            Assert.AreEqual(1, list.Count);
            Assert.AreEqual(list[0].Title, "The Shawshank Redemption");
        }

        [Test]
        public async Task MediaSearchTests_InputAfter1970_ReturnListOf1()
        {
            var list = (await _videoService.GetFilteredVideos("after 1980")).Data;

            //should only be one from the three given movies
            Assert.AreEqual(1, list.Count);
        }

        [Test]
        public async Task MediaSearchTests_InputAfter72EdgeCase_ReturnListOf2()
        {
            var list = (await _videoService.GetFilteredVideos("after 1972")).Data;

            //movie with the release year 1972 should not be included
            Assert.AreEqual(2, list.Count);
        }

        [Test]
        public async Task MediaSearchTests_InputDescriptionWord_ReturnListOf1()
        {
            var list = (await _videoService.GetFilteredVideos("Vito Corleone")).Data;

            //should only be one from the three given movies
            Assert.AreEqual(1, list.Count);
            Assert.IsTrue(list[0].Overview.Contains("Vito Corleone"));
        }
    }
}
