using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesApp.Api.Entities
{
    public class MoviesWithMostSoldTicketsEntity
    {
        public int VideoId { get; set; }
        public string VideoName { get; set; }
        public string ScreeningName { get; set; }
        public int SoldTickets { get; set; }
    }
}
