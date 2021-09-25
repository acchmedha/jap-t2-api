using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesApp.Api.Entities
{
    public class MostRatedVideoEntity
    {
        public int VideoId { get; set; }
        public string VideoName { get; set; }
        public int NumberOfRatings { get; set; }
        public double AverageRating { get; set; }
    }
}
