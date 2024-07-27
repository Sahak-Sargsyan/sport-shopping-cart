using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace SportStore.Models
{
    public static class IdentitySeedData
    {
        private const string adminUser = "admin";
        private const string adminPassword = "Password111@";
        public static async void EnsurePopulated(IApplicationBuilder app)
        {
            AppIdentityDbContext context = app.ApplicationServices.CreateScope()
                .ServiceProvider.GetRequiredService<AppIdentityDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            UserManager<IdentityUser> userManager = app.ApplicationServices
                .CreateScope().ServiceProvider.GetRequiredService<UserManager<IdentityUser>>();

            IdentityUser user = await userManager.FindByNameAsync(adminUser);
            if (user == null)
            {
                user = new IdentityUser("admin");
                user.Email = "admin@example.com";
                user.PhoneNumber = "555-1234";
                await userManager.CreateAsync(user, adminPassword);
            }
        }
    }
}
