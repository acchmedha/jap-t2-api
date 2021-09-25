using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesApp.Api.Entities
{
    public class TicketEntity
    {
        public int Id { get; set; }
        public int ScreeningEntityId { get; set; }
        public int UserEntityId { get; set; }
        public int BoughtTickets { get; set; }
    }
}
