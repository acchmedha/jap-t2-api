using JAP_Task_1_MoviesApi.DTO;
using JAP_Task_1_MoviesApi.Entities;
using JAP_Task_1_MoviesApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JAP_Task_1_MoviesApi.Services
{
    public interface IAuthService
    {
        Task<ServiceResponse<int>> Register(UserEntity user, string password);
        Task<ServiceResponse<LoginDto>> Login(string username, string password);
    }
}
