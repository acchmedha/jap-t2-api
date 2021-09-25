using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesApp.Api.Entities
{
    public class VideosWithMostScreeningsEntity
    {
        public int VideoId { get; set; }
        public string VideoName { get; set; }
        public int NumberOfScreenings { get; set; }
    }
}
