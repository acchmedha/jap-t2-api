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
        public async Task<List<MostRatedMoviesEntity>> MostRatedMoviesReport()
        {
            return await _context.MostRatedVideos.FromSqlRaw("EXEC [dbo].[getTop10MoviesWithMostRatings];")
                                                            .ToListAsync();
        }

        public async Task<List<MoviesWithMostScreeningsEntity>> MoviesWithMostScreeningsReport(DateTime fromDate, 
            DateTime toDate)
        {
            return await _context.VideosWithMostScreenings
                     .FromSqlRaw("EXEC [dbo].[getTop10MoviesWithMostScreenings] {0}, {1};", fromDate, toDate)
                     .ToListAsync();
        }

        public async Task<List<MoviesWithMostSoldTicketsEntity>> MoviesWithMostSoldTicketsReport()
        {
            return await _context.VideosWithMostSoldTickets.FromSqlRaw("EXEC [dbo].[getMoviesWithMostSoldTicketsNoRating]")
                                                                      .ToListAsync();
        }
    }
}
