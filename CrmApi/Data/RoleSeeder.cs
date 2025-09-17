using CrmApi.Models;
using Microsoft.AspNetCore.Identity;

public static class RoleSeeder
{
    public static async System.Threading.Tasks.Task SeedRolesAsync(RoleManager<IdentityRole> roleManager, UserManager<ApplicationUser> userManager)
    {
        string[] roles = { "superadmin", "admin", "user" };

        foreach (var role in roles)
        {
            if (!await roleManager.RoleExistsAsync(role))
                await roleManager.CreateAsync(new IdentityRole(role));
        }

        // Seed a default SuperAdmin
        var superAdminEmail = "superadmin@crm.com";
        var superAdmin = await userManager.FindByEmailAsync(superAdminEmail);

        if (superAdmin == null)
        {
            var user = new ApplicationUser
            {
                UserName = "superadmin",
                Email = superAdminEmail,
                Name = "System SuperAdmin",
                EmailConfirmed = true
            };

            var result = await userManager.CreateAsync(user, "SuperAdmin@123");
            if (result.Succeeded)
            {
                await userManager.AddToRoleAsync(user, "superadmin");
            }
        }
    }
}
