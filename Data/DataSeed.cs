using System.Collections.Generic;
using System.Threading.Tasks;
using Application;
using Domain;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Internal;

namespace Application
{
    public class DataSeed
    {
        public static async Task SeedDataAsync(DataContext context, UserManager<AppUser> userManager)
        {
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
                                            DisplayName = "User one",
                                            UserName = "User",
                                            Email = "User@user.com"
                                        }
                                };

                foreach (var user in users)
                {
                    await userManager.CreateAsync(user, "qwerty123");
                }
            }
        }
    }
}