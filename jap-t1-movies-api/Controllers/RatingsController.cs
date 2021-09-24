using JAP_Task_1_MoviesApi.Requests;
using JAP_Task_1_MoviesApi.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Threading.Tasks;

namespace JAP_Task_1_MoviesApi.Controllers
{
    public class RatingsController : BaseApiController
    {
        private readonly IRatingService _ratingService;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public RatingsController(IRatingService ratingService, IHttpContextAccessor httpContextAccessor)
        {
            _ratingService = ratingService;
            _httpContextAccessor = httpContextAccessor;
        }

        int GetUserId() => int.Parse(_httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier));

        [HttpPost("add")]
        [Authorize]
        public async Task<IActionResult> AddRating(AddRatingRequest ratingReq)
        {
            var response = await _ratingService.AddRating(ratingReq.Value, ratingReq.VideoId, GetUserId());

            if (!response.Success) return BadRequest(response);

            return Ok(response);
        }
    }
}