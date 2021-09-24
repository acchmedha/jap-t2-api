using FluentValidation;
using FluentValidation.AspNetCore;
using JAP_Task_1_MoviesApi.Data;
using JAP_Task_1_MoviesApi.Helpers;
using JAP_Task_1_MoviesApi.Requests;
using JAP_Task_1_MoviesApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.OpenApi.Models;
using MoviesApp.Api.Validators;
using Swashbuckle.AspNetCore.Filters;
using System.Reflection;

namespace JAP_Task_1_MoviesApi.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddScoped<IVideoService, VideoService>();
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<IRatingService, RatingService>();
            services.AddAutoMapper(typeof(AutoMapperProfiles).Assembly);
            services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddDbContext<MoviesAppDbContext>(options =>
            {
                options.UseSqlServer(config.GetConnectionString("DefaultConnection"));
            });

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "JapTask1BackendCorrection", Version = "v1" });

                c.AddSecurityDefinition("oauth2", new OpenApiSecurityScheme
                {
                    Description = "Standard Authorization header using the Bearer token",
                    In = ParameterLocation.Header,
                    Name = "Authorization",
                    Type = SecuritySchemeType.ApiKey
                });
                c.OperationFilter<SecurityRequirementsOperationFilter>();
            });

            //Fluent Validation
            services.AddMvc().AddFluentValidation();
            services.AddTransient<IValidator<UserLoginRequest>, UserLoginRequestValidator>();
            services.AddTransient<IValidator<UserRegisterRequest>, UserRegisterRequestValidator>();

            return services;
        }

    }
}


