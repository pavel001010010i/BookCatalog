﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Users
{
    public class UserResponse
    {
        public string DisplayName { get; set; }
        public string Email { get; set; }
        public string Token { get; set; }
        public string? RefreshToken { get; set; }  
    }
}
