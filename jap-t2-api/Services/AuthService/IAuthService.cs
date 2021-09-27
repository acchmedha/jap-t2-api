using JAP_Task_1_MoviesApi.DTO;
using JAP_Task_1_MoviesApi.Entities;
using System.Threading.Tasks;

namespace JAP_Task_1_MoviesApi.Services
{
    public interface IAuthService
    {
        Task<int> Register(UserEntity user, string password);
        Task<LoginDto> Login(string username, string password);
    }
}
