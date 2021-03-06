using JAP_Task_1_MoviesApi.Models;
using MoviesApp.Api.Entities;
using System;
using System.Collections.Generic;

namespace JAP_Task_1_MoviesApi.Entities
{
    public class VideoEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string PosterPath { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Overview { get; set; }
        public VideoEnum Type { get; set; }
        public List<ActorEntity> Actors { get; set; }
        public List<RatingEntity> Ratings { get; set; }
        public List<ScreeningEntity> Screenings { get; set; }
    }
}
