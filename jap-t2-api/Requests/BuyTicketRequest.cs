using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesApp.Api.Requests
{
    public class BuyTicketRequest
    {
        public int ScreeningEntityId { get; set; }
        public int NumberOfTickets { get; set; }

    }
}
