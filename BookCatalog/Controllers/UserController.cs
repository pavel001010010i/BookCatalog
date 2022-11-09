using Application.Common.Constants;
using Application.Users;
using Application.Users.Queries.Login;
using Application.Users.Queries.Token.RefreshToken;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BookCatalogApi.Controllers
{

    public class UserController : BaseController
    {
        [AllowAnonymous]
        [HttpPost("login")]
        public async Task<ActionResult<UserResponse>> LoginAsync(LoginQuery command)
        {
            return await Mediator.Send(command);
        }

        [Authorize]
        [HttpPost("refresh-token")]
        public async Task<ActionResult<AuthenticatedResponse>> RefreshTokenAsync(RefreshTokenQuery command)
        {
            return await Mediator.Send(command);
        }
    }
}
