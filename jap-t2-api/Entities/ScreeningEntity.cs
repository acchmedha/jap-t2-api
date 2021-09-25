using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesApp.Api.Entities
{
    public class ScreeningEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int VideoEntityId { get; set; }
        public int SoldTickets { get; set; }
        public DateTime ScreeningDate { get; set; }
        public List<TicketEntity> Tickets { get; set; }
    }
}
