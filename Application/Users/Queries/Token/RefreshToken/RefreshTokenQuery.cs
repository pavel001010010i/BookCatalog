using MediatR;


namespace Application.Users.Queries.Token.RefreshToken
{
    public class RefreshTokenQuery : IRequest<AuthenticatedResponse>
    {
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
    }
}
