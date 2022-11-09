using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Users
{
    public class AuthenticatedResponse
    {
        public string? Token { get; set; }
        public string? RefreshToken { get; set; }  
    }
}
