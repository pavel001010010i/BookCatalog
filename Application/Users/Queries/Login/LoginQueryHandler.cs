using Application.Common.Exeption;
using Application.Interfaces;
using Domain.Models;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Net;
using System.Security.Claims;

namespace Application.Users.Queries.Login
{
    public class LoginQueryHandler : IRequestHandler<LoginQuery, UserResponse>
    {
        private readonly UserManager<AppUser> _userManager;

        private readonly SignInManager<AppUser> _signInManager;

        private readonly IJwtService _jwtService;

        public LoginQueryHandler (UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, IJwtService jwtService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _jwtService = jwtService;
        }

        public async Task<UserResponse> Handle(LoginQuery request, CancellationToken cancellationToken)
        {
            var user = await _userManager.FindByEmailAsync(request.Email);
            if (user == null)
            {
                throw new RestException(HttpStatusCode.Unauthorized, "User not found!");
            }

            var result = await _signInManager.CheckPasswordSignInAsync(user, request.Password, false);

            if (result.Succeeded)
            {
                var claim = await _jwtService.GetClaimsUser(user);
                var token = _jwtService.GenerateAccessToken(claim);
                var refreshToken = _jwtService.GenerateRefreshToken();

                user.Token = token;
                user.RefreshToken = refreshToken;
                user.RefreshTokenExpiryTime = DateTime.Now.AddDays(7);

                await _userManager.UpdateAsync(user);

                return new UserResponse
                {
                    DisplayName = user.DisplayName,
                    Email = user.Email,
                    Token = token,
                    RefreshToken = refreshToken
                };
            }
            throw new RestException(HttpStatusCode.Unauthorized, "Password isn't correct!");
        }
    }
}
