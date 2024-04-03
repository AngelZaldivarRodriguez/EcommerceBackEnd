using Core.Entitites.Identity;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Identity
{
    public class AppIdentityDbContextSeed
    {
        public static async Task SeedUserAsync(UserManager<AppUser> userManager)
        {
            if (!userManager.Users.Any())
            {
                var user = new AppUser
                {
                    DisplayName = "Wero",
                    Email = "wero@test.com",
                    UserName = "wero@test.com",
                    Address = new Address
                    {
                        FirstName = "Wero",
                        LastName = "Falcon",
                        Street = "10 The Street",
                        City = "Cancun",
                        State = "Quintana Roo",
                        ZipCode = "55631"
                    }
                };

                await userManager.CreateAsync(user, "Pa$$w0rd");
            }
        }
    }
}
