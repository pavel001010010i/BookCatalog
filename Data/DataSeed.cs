using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Application;
using Application.Common.Constants;
using Domain.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.VisualBasic;

namespace Application
{
    public class DataSeed
    {
        public static async Task SeedDataAsync(UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            if (!roleManager.Roles.Any())
            {
                var roles = new List<IdentityRole>
                {
                    new IdentityRole
                    {
                        Id = Guid.NewGuid().ToString(),
                        Name = UserRoles.ADMIN_ROLE,
                        NormalizedName = UserRoles.ADMIN_ROLE.ToUpper(),
                    },
                    new IdentityRole
                    {
                        Id = Guid.NewGuid().ToString(),
                        Name = UserRoles.USER_ROLE,
                        NormalizedName = UserRoles.USER_ROLE.ToUpper()
                    }
                };
                foreach (var role in roles)
                {
                    await roleManager.CreateAsync(role);
                }
            }
            

            if (!userManager.Users.Any())
            {
                var users = new List<AppUser>
                {
                    new AppUser
                    {
                        DisplayName = "Admin main",
                        UserName = "Admin",
                        Email = "admin@admin.com"
                    },
                    new AppUser
                    {
                        DisplayName = "UserResponse one",
                        UserName = "UserResponse",
                        Email = "UserResponse@user.com"
                    }
                };
                //
                foreach (var user in users)
                {
                    await userManager.CreateAsync(user, "qazwsX123@");
                    if(user.UserName == "Admin")
                    {
                        await userManager.AddToRoleAsync(user, UserRoles.ADMIN_ROLE);
                    }
                    else
                        await userManager.AddToRoleAsync(user, UserRoles.USER_ROLE);
                }
            }
            
        }
    }
}