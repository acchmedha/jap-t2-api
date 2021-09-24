using JAP_Task_1_MoviesApi.Models;

namespace JAP_Task_1_MoviesApi.Requests
{
    public class GetVideosRequest
    {
        public Pagination Pagination { get; set; } = new Pagination();
        public string Search { get; set; }
        public VideoEnum VideoType { get; set; } = VideoEnum.Movie;
    }
}
