using JAP_Task_1_MoviesApi.Controllers;
using JAP_Task_1_MoviesApi.Entities;
using Microsoft.AspNetCore.Mvc;
using MoviesApp.Api.Entities;
using MoviesApp.Api.Requests;
using MoviesApp.Api.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MoviesApp.Api.Controllers
{
    public class ReportsController : BaseApiController
    {
        private readonly IReportService _reportService;
        public ReportsController(IReportService reportService)
        {
            _reportService = reportService;
        }

        [HttpGet("most-rated-movies")]
        public async Task<ActionResult<ServiceResponse<List<MostRatedMoviesEntity>>>> GetMostRatedMoviesReport()
        {
            return Ok(await _reportService.MostRatedMoviesReport());
        }

        [HttpPost("movies-with-most-screenings")]
        public async Task<ActionResult<ServiceResponse<List<MoviesWithMostScreeningsEntity>>>> VideosWithMostScreeningsReport([FromBody] DateIntervalRequest dateInterval)
        {
            return Ok(await _reportService.MoviesWithMostScreeningsReport(dateInterval.StartDate, dateInterval.EndDate));
        }

        [HttpGet("movies-with-most-sold-tickets")]
        public async Task<ActionResult<ServiceResponse<List<MoviesWithMostSoldTicketsEntity>>>> MoviesWithMostSoldTicketsReport()
        {
            return Ok(await _reportService.MoviesWithMostSoldTicketsReport());
        }
    }
}
