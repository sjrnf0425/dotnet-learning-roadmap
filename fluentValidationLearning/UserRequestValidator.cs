using FluentValidation;

namespace fluentValidationLearning
{
    public class UserRequestValidator : AbstractValidator<UserRequest>
    {
        public UserRequestValidator() { 
            RuleFor(x => x.UserName)
                .NotEmpty().WithMessage("UserName is required.")
                .MinimumLength(3).WithMessage("UserName must be at least 3 characters long.");

            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("Email is required.")
                .EmailAddress().WithMessage("Invalid email format.");
        }
    }
}
