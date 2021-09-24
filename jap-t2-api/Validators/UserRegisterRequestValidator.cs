using FluentValidation;
using JAP_Task_1_MoviesApi.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesApp.Api.Validators
{
    public class UserRegisterRequestValidator : AbstractValidator<UserRegisterRequest>
    {
        public UserRegisterRequestValidator()
        {
            RuleFor(x => x.Username)
                .NotNull()
                .MaximumLength(50)
                .MinimumLength(3);
            
            RuleFor(x => x.Password)
                .NotNull()
                .MaximumLength(50)
                .MinimumLength(8);
            
            RuleFor(x => x.FirstName)
                .NotNull()
                .MaximumLength(255)
                .MinimumLength(3);
            
            RuleFor(x => x.LastName)
                .NotNull()
                .MaximumLength(255)
                .MinimumLength(3);
        }
    }
}
