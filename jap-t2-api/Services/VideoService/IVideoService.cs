using JAP_Task_1_MoviesApi.DTO;
using JAP_Task_1_MoviesApi.Entities;
using JAP_Task_1_MoviesApi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace JAP_Task_1_MoviesApi.Services
{
    public interface IVideoService
    {
        Task<List<MovieDto>> GetVideos(VideoEnum videoType, Pagination pagination);
        Task<VideoFullInfoDto> GetVideo(int id);
        Task<List<MovieDto>> GetFilteredVideos(string search);
    }
}
