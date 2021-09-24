using AutoMapper;
using JAP_Task_1_MoviesApi.Models;
using JAP_Task_1_MoviesApi.Requests;
using JAP_Task_1_MoviesApi.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace JAP_Task_1_MoviesApi.Controllers
{
    public class AuthController : BaseApiController
    {
        private readonly IAuthService _authService;
        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(UserRegisterRequest request)
        {
            var response = await _authService.Register(new UserEntity
            { Username = request.Username, FirstName = request.FirstName, LastName = request.LastName },
                request.Password);

            return (response.Success) ? Ok(response) : BadRequest(response);
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(UserLoginRequest request)
        {
            var response = await _authService.Login(request.Username, request.Password);

            return (response.Success) ? Ok(response) : BadRequest(response);
        }
    }
}
