using JAP_Task_1_MoviesApi.Data;
using JAP_Task_1_MoviesApi.Entities;
using JAP_Task_1_MoviesApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Moq;
using MoviesApp.Api.Entities;
using MoviesApp.Api.Services;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using IConfiguration = Microsoft.Extensions.Configuration.IConfiguration;

namespace JAP_Task_1_MoviesApi
{
    [TestFixture]
    public class BuyTicketsTest
    {
        MoviesAppDbContext _context;
        ITicketService ticketService;

        [SetUp]
        public async Task OneTimeSetupAsync()
        {
            // database setup
            var options = new DbContextOptionsBuilder<MoviesAppDbContext>()
                .UseInMemoryDatabase(databaseName: "temp_moviesapp1")
                .Options;

            _context = new MoviesAppDbContext(options);

            // - add data
            _context.Screenings.Add(new ScreeningEntity { Id = 1, Name = "Screening 1", VideoEntityId = 1, ScreeningDate = DateTime.Now.AddDays(30) });
            _context.Screenings.Add(new ScreeningEntity { Id = 2, Name = "Screening 2", VideoEntityId = 1, ScreeningDate = DateTime.Now.AddDays(-3) });
            await _context.SaveChangesAsync();

            AuthService.CreatePasswordHash("password", out byte[] passHash, out byte[] passSalt);
            _context.Users.Add(
                new UserEntity
                {
                    Id = 1,
                    Username = "admin",
                    FirstName = "Admin",
                    LastName = "Admin",
                    PasswordHash = passHash,
                    PasswordSalt = passSalt
                }
            );
            await _context.SaveChangesAsync();


            ticketService = new TicketService(_context);
        }

        [TearDown]
        public async Task TearDownAsync()
        {
            await _context.Database.EnsureDeletedAsync();
        }

        [Test]
        public async Task BuyTicketsTest_ValidInput_ReturnsTrue()
        {
            var response = await ticketService.BuyTickets(1, 2, 1);

            Assert.IsTrue(response);
        }

        [Test]
        public async Task BuyTicketsTest_InvalidInput_ScreeningsInPast_ReturnFalse()
        {
            try
            {
                await ticketService.BuyTickets(2, 1, 1);
            }
            catch (Exception e)
            {
                Assert.AreEqual(e.Message, "Screening is in the past!");
            }  
        }

    }

}
