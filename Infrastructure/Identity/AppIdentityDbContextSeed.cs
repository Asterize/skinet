using System.Linq;
using System.Threading.Tasks;
using Core.Entities.Identity;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Identity
{
    public class AppIdentityDbContextSeed
    {
        public static async Task SeedUsersAsync(UserManager<AppUser> userManager)
        {
            if (!userManager.Users.Any())
            {
                var user = new AppUser()
                {
                    DisplayName = "Tien",
                    Email = "Tien@test.com",
                    UserName = "Tien@test.com",
                    Address = new Address
                    {
                        Name = "Tran Thuan Tien",
                        Street = "13 Le Kim Sa",
                        Ward = "phuong 6",
                        District = "quan 8",
                        City = "TP Ho Chi Minh",
                        Zipcode = "72000"
                    },
                    Role = "Admin"
                };

                await userManager.CreateAsync(user,"Pa$$w0rd");
            }
        }
    }
}