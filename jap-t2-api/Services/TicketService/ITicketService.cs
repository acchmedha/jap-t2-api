using JAP_Task_1_MoviesApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesApp.Api.Services
{
    public interface ITicketService
    {
        Task<bool> BuyTickets(int screeningId, int numberOfTickets, int userId);
    }
}
