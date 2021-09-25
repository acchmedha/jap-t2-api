using JAP_Task_1_MoviesApi.Data;
using JAP_Task_1_MoviesApi.Entities;
using Microsoft.EntityFrameworkCore;
using MoviesApp.Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesApp.Api.Services
{
    public class TicketService : ITicketService
    {
        private readonly MoviesAppDbContext _context;
        public TicketService(MoviesAppDbContext context)
        {
            _context = context;
        }

        public async Task<ServiceResponse<bool>> BuyTickets(int screeningId, int numberOfTickets, int userId)
        {
            if (numberOfTickets <= 0)
                throw new Exception("Number of tickets cannot be zero or negative!");

            var screening = await _context.Screenings.FirstOrDefaultAsync(x => x.Id == screeningId);

            if (screening == null)
                throw new Exception("Screening does not exist!");
            else if (screening.ScreeningDate <= DateTime.Now)
                throw new Exception("Screening is in the past!");
            else
            {
                await _context.SaveChangesAsync();

                await _context.Tickets
                    .AddAsync(new TicketEntity
                    {
                        ScreeningEntityId = screeningId,
                        UserEntityId = userId,
                        BoughtTickets = numberOfTickets
                    });
                
                await _context.SaveChangesAsync();

                return new() { Success = true, Data = true, Message = "Successfully bought tickets!" };
            }
        }
    }
}
