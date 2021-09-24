using FluentValidation;
using JAP_Task_1_MoviesApi.Requests;

namespace MoviesApp.Api.Validators
{
    public class UserLoginRequestValidator : AbstractValidator<UserLoginRequest>
    {
        public UserLoginRequestValidator()
        {
            RuleFor(x => x.Username)
                .NotNull()
                .MaximumLength(50)
                .MinimumLength(3);
            
            RuleFor(x => x.Password)
                .NotNull()
                .MaximumLength(64)
                .MinimumLength(5); 
        }
    }
}
