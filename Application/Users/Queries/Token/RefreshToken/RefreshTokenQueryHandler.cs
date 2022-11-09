using Application.Common.Exeption;
using Application.Interfaces;
using Domain.Models;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System.Net;


namespace Application.Users.Queries.Token.RefreshToken
{
    internal class RefreshTokenQueryHandler : IRequestHandler<RefreshTokenQuery, AuthenticatedResponse>
    {
        private readonly UserManager<AppUser> _userManager;

        private readonly SignInManager<AppUser> _signInManager;

        private readonly IJwtService _jwtService;

        public RefreshTokenQueryHandler(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, IJwtService jwtService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _jwtService = jwtService;
        }
        public async Task<AuthenticatedResponse> Handle(RefreshTokenQuery request, CancellationToken cancellationToken)
        {
            var principal = _jwtService.GetPrincipalFromExpiredToken(request.AccessToken);

            var user = await _userManager.FindByNameAsync(principal.Identity.Name);

            if (user is null || user.RefreshToken != request.RefreshToken || user.RefreshTokenExpiryTime <= DateTime.Now)
                throw new RestException(HttpStatusCode.InternalServerError, "Server error!");

            var newAccessToken = _jwtService.GenerateAccessToken(principal.Claims);
            var newRefreshToken = _jwtService.GenerateRefreshToken();

            user.RefreshToken = newRefreshToken;
            user.Token = newAccessToken;

            await _userManager.UpdateAsync(user);

            return new AuthenticatedResponse
            {
                Token = newAccessToken,
                RefreshToken = newRefreshToken
            };
        }
    }
}
