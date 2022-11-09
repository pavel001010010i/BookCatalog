using FluentValidation;

namespace Application.Users.Queries.Login
{
    public class LoginQueryValidation : AbstractValidator<LoginQuery>
    {
        public LoginQueryValidation()
        {
            RuleFor(x => x.Email).NotEmpty();

            RuleFor(x => x.Password).NotEmpty();
        }
    }
}
