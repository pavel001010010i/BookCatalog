using Application.Common.Constants;
using Domain.Models;
using Microsoft.AspNetCore.Identity;

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
                        Id ="3d490a70-94ce-4d15-9494-86dba8c0",
                        DisplayName = "Admin main",
                        UserName = "Admin",
                        Email = "admin@admin.com"
                    },
                    new AppUser
                    {
                        Id ="3d490a70-d178-4d15-938c-ed49778fb52a",
                        DisplayName = "Userone",
                        UserName = "User",
                        Email = "User@user.com"
                    }
                };
                
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