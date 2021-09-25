using JAP_Task_1_MoviesApi.Data;
using JAP_Task_1_MoviesApi.Entities;
using Microsoft.EntityFrameworkCore;
using MoviesApp.Api.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MoviesApp.Api.Services
{
    public class ReportService : IReportService
    {
        private readonly MoviesAppDbContext _context;
        public ReportService(MoviesAppDbContext context)
        {
            _context = context;
        }
        public async Task<ServiceResponse<List<MostRatedMoviesEntity>>> MostRatedMoviesReport()
        {
            var serviceResponse = new ServiceResponse<List<MostRatedMoviesEntity>>
            {
                Data = await _context.MostRatedVideos.FromSqlRaw("EXEC [dbo].[getTop10MoviesWithMostRatings];")
                                                            .ToListAsync(),
                Success = true,
                Message = "Success"
            };

            return serviceResponse;
        }

        public async Task<ServiceResponse<List<MoviesWithMostScreeningsEntity>>> MoviesWithMostScreeningsReport(DateTime fromDate, 
            DateTime toDate)
        {
            var serviceResponse = new ServiceResponse<List<MoviesWithMostScreeningsEntity>>
            {
                Data = await _context.VideosWithMostScreenings
                     .FromSqlRaw("EXEC [dbo].[getTop10MoviesWithMostScreenings] {0}, {1};", fromDate, toDate)
                     .ToListAsync(),
                Success = true,
                Message = "Success"
            };

            return serviceResponse;
        }

        public async Task<ServiceResponse<List<MoviesWithMostSoldTicketsEntity>>> MoviesWithMostSoldTicketsReport()
        {
            var serviceResponse = new ServiceResponse<List<MoviesWithMostSoldTicketsEntity>>
            {
                Data = await _context.VideosWithMostSoldTickets.FromSqlRaw("EXEC [dbo].[getMoviesWithMostSoldTicketsNoRating]")
                                                                      .ToListAsync(),
                Success = true,
                Message = "Success"
            };

            return serviceResponse;
        }
    }
}
