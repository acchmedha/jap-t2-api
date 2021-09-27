using JAP_Task_1_MoviesApi.Entities;
using MoviesApp.Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesApp.Api.Services
{
    public interface IReportService
    {
        Task<List<MostRatedMoviesEntity>> MostRatedMoviesReport();
        Task<List<MoviesWithMostScreeningsEntity>> MoviesWithMostScreeningsReport(DateTime fromDate, DateTime toDate);
        Task<List<MoviesWithMostSoldTicketsEntity>> MoviesWithMostSoldTicketsReport();
    }
}
