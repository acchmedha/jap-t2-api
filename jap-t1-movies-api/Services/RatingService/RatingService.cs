using JAP_Task_1_MoviesApi.Data;
using JAP_Task_1_MoviesApi.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace JAP_Task_1_MoviesApi.Services
{
    public class RatingService : IRatingService
    {
        private readonly MoviesAppDbContext _context;
        public RatingService(MoviesAppDbContext context)
        {
            _context = context;
        }
        public async Task<ServiceResponse<bool>> AddRating(double addValue, int addVideoId, int userId)
        {
            ServiceResponse<bool> response = new() { Data = false };

            if (addValue < 1 || addValue > 5)
                throw new Exception("Rating must be between 1 and 5!");

            if ((await _context.Ratings.FirstOrDefaultAsync(x => x.UserEntityId == userId && x.VideoEntityId == addVideoId)) != null)
                throw new Exception("You already rated this item");
            
            if (await _context.Videos.FirstOrDefaultAsync(x => x.Id == addVideoId) == null)
                throw new Exception("The given video does not exist!");

            if (await _context.Users.FirstOrDefaultAsync(x => x.Id == userId) == null)
                throw new Exception("The given user does not exist!");

            await _context.Ratings.AddAsync( new() { Value = addValue, VideoEntityId = addVideoId, UserEntityId = userId});
            await _context.SaveChangesAsync();

            return new() { Data = true, Success = true, Message = "Successfully added rating" };
        }
    }
}
