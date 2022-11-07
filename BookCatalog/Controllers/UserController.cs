using Application.Users;
using Application.Users.Login;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BookCatalogApi.Controllers
{
    [AllowAnonymous]
    public class UserController : BaseController
    {
        [HttpPost("login")]
        public async Task<ActionResult<User>> LoginAsync(LoginQuery query)
        {
            return await Mediator.Send(query);
        }

        //[HttpPost("registration")]
        //public async Task<ActionResult<User>> RegistrationAsync(RegistrationCommand command)
        //{
        //    return await Mediator.Send(command);
        //}
    }
}
