using FluentValidation;
using JAP_Task_1_MoviesApi.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesApp.Api.Validators
{
    public class AddRatingRequestValidator : AbstractValidator<AddRatingRequest>
    {
        public AddRatingRequestValidator()
        {
            RuleFor(x => x.Value)
                .NotNull()
                .GreaterThan(0)
                .LessThan(5);

            RuleFor(x => x.VideoId)
                .NotNull()
                .GreaterThan(0);
        }
    }
}
