using JAP_Task_1_MoviesApi.Controllers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MoviesApp.Api.Requests;
using MoviesApp.Api.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MoviesApp.Api.Controllers
{
    public class TicketsController : BaseApiController
    {
        private readonly ITicketService _ticketService;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public TicketsController(ITicketService ticketService, IHttpContextAccessor httpContextAccessor)
        {
            _ticketService = ticketService;
            _httpContextAccessor = httpContextAccessor;
        }

        private int GetUserId() => int.Parse(_httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier));

        [HttpPost("buy-tickets")]
        [Authorize]
        public async Task<IActionResult> BuyTickets([FromBody] BuyTicketRequest request)
        {
            var response = await _ticketService.BuyTickets(request.ScreeningEntityId, request.NumberOfTickets, GetUserId());

            return Ok("Successfully bought tickets!");
        }
    }
}
