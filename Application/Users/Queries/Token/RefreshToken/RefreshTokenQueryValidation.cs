
using FluentValidation;


namespace Application.Users.Queries.Token.RefreshToken
{
    public class RefreshTokenQueryValidation : AbstractValidator<RefreshTokenQuery>
    {
        public RefreshTokenQueryValidation()
        {
            RuleFor(x => x.AccessToken).NotEmpty();

            RuleFor(x => x.RefreshToken).NotEmpty();
        }
    }
}
