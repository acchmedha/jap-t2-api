using JAP_Task_1_MoviesApi.Data;
using JAP_Task_1_MoviesApi.DTO;
using JAP_Task_1_MoviesApi.Entities;
using JAP_Task_1_MoviesApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace JAP_Task_1_MoviesApi.Services
{
    public class AuthService : IAuthService
    {
        private readonly MoviesAppDbContext _context;
        private readonly IConfiguration _config;
        public AuthService(MoviesAppDbContext context, IConfiguration config)
        {
            _context = context;
            _config = config;
        }

        public async Task<ServiceResponse<LoginDto>> Login(string username, string password)
        {
            ServiceResponse<LoginDto> response = new();
            UserEntity user = await _context.Users.FirstOrDefaultAsync(x => x.Username == username);

            if (user == null)
            {
                throw new Exception("User not found!");
            }
            else if (!VerifyPasswordHash(password, user.PasswordHash, user.PasswordSalt))
            {
                throw new Exception("Wrong password!");
            }
            else
            {
                LoginDto userLogin = new()
                {
                    Token = CreateToken(user),
                    Username = user.Username,
                    FirstName = user.FirstName,
                    LastName = user.LastName
                };

                response.Success = true;
                response.Data = userLogin;
                response.Message = "Login successful!";
            }
            return response;
        }

        public async Task<ServiceResponse<int>> Register(UserEntity user, string password)
        {
            if (await UserExists(user.Username))
                throw new Exception("User already exists");

            CreatePasswordHash(password, out byte[] passwordHash, out byte[] passwordSalt);

            user.PasswordHash = passwordHash;
            user.PasswordSalt = passwordSalt;

            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();

            return new ServiceResponse<int>() { Data = user.Id, Message = "User registered successfully", Success = true };
        }

        private async Task<bool> UserExists(string username) => await _context.Users.AnyAsync(x => x.Username.ToLower() == username.ToLower());

        public static void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using var hmac = new System.Security.Cryptography.HMACSHA512();
            passwordSalt = hmac.Key;
            passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
        }

        public static bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt);
            var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));

            for (int i = 0; i < computedHash.Length; i++)
                if (computedHash[i] != passwordHash[i]) return false;

            return true;
        }

        public string CreateToken(UserEntity user)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(ClaimTypes.Name, user.Username)
            };
            
            SymmetricSecurityKey key = new(
                Encoding.UTF8.GetBytes(_config.GetSection("AppSettings:Token").Value)
            );

            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.Now.AddDays(7),
                SigningCredentials = creds
            };

            var tokenHandler = new JwtSecurityTokenHandler();

            var token = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(token);
        }
    }
}
