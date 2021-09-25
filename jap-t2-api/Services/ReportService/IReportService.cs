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
        Task<ServiceResponse<List<MostRatedMoviesEntity>>> MostRatedMoviesReport();
        Task<ServiceResponse<List<MoviesWithMostScreeningsEntity>>> MoviesWithMostScreeningsReport(DateTime fromDate, DateTime toDate);
        Task<ServiceResponse<List<MoviesWithMostSoldTicketsEntity>>> MoviesWithMostSoldTicketsReport();
    }
}
