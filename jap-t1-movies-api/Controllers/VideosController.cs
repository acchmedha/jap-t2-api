using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using JAP_Task_1_MoviesApi.Services;
using JAP_Task_1_MoviesApi.DTO;
using JAP_Task_1_MoviesApi.Requests;
using JAP_Task_1_MoviesApi.Entities;
using JAP_Task_1_MoviesApi.Models;

namespace JAP_Task_1_MoviesApi.Controllers
{
    public class VideosController : BaseApiController
    {
        private readonly IVideoService _videoService;
        public VideosController(IVideoService videoService)
        {
            _videoService = videoService;
        }

        // GET: api/Videos
        [HttpGet]
        [Authorize]
        public async Task<ActionResult<List<MovieDto>>> GetFilteredVideos([FromQuery] GetVideosRequest request)
        {
            if (request.Search == null) return Ok(await _videoService.GetVideos(request.VideoType, request.Pagination));

            return Ok(await _videoService.GetFilteredVideos(request.Search));
        }

        // GET: api/Videos/id
        [HttpGet("{id}")]
        [Authorize]
        public async Task<ActionResult<VideoFullInfoDto>> GetMovie(int id)
        {
            var response = await _videoService.GetVideo(id);

            return response.Success ? Ok(response) : NotFound();
        }
    }
}
