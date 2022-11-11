using MediatR;
using System.ComponentModel;

namespace Application.Users.Queries.Login
{
    public class LoginQuery : IRequest<UserResponse>
    {
        [DefaultValue("admin@admin.com")]
        public string Email { get; set; }

        [DefaultValue("qazwsX123@")]
        public string Password { get; set; }
    }
}
