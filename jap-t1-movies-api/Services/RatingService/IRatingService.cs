using JAP_Task_1_MoviesApi.Entities;
using System.Threading.Tasks;

namespace JAP_Task_1_MoviesApi.Services
{
    public interface IRatingService
    {
        Task<ServiceResponse<bool>> AddRating(double AddValue, int AddMovieId, int userId);
    }
}
