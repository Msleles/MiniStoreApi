using Microsoft.AspNetCore.Identity;
using MiniStore.Domain.Account;

namespace MiniStore.Infra.Data.Identity
{
    public class SeedUserRoleInitialService : ISeedUserRoleInitial
    {
        private readonly UserManager<ApplicationUser> _userMananger;
        private readonly RoleManager<IdentityRole> _roleMananger;


        public SeedUserRoleInitialService(UserManager<ApplicationUser> userMananger,
            RoleManager<IdentityRole> roleMananger)
        {
            _userMananger = userMananger;
            _roleMananger = roleMananger;
        }

        public void SeedRoles()
        {
            if (!_roleMananger.RoleExistsAsync("User").Result)
            {
                IdentityRole role = new IdentityRole();
                role.Name = "User";
                role.NormalizedName = "USER";

                IdentityResult roleResult = _roleMananger.CreateAsync(role).Result;
            }

            if (!_roleMananger.RoleExistsAsync("Admin").Result)
            {
                IdentityRole role = new IdentityRole();
                role.Name = "admin";
                role.NormalizedName = "ADMIN";

                IdentityResult roleResult = _roleMananger.CreateAsync(role).Result;
            }
        }

        public void SeedUsers()
        {
            if (_userMananger.FindByEmailAsync("usuario@localhost").Result == null)
            {
                ApplicationUser user = new ApplicationUser
                {
                    UserName = "usuario@localhost",
                    Email = "usuario@localhost",
                    NormalizedEmail = "USUARIO@LOCALHOST",
                    NormalizedUserName = "USUARIO@LOCALHOST",
                    EmailConfirmed = true,
                    LockoutEnabled = false,
                    SecurityStamp = Guid.NewGuid().ToString()
                };

                IdentityResult result = _userMananger.CreateAsync(user, "Numsey#2023").Result;

                if (result.Succeeded)
                {
                    _userMananger.AddToRoleAsync(user, "User").Wait();
                }
            }

            if (_userMananger.FindByEmailAsync("admin@localhost").Result == null)
            {
                ApplicationUser user = new ApplicationUser
                {
                    UserName = "admin@localhost",
                    Email = "admin@localhost",
                    NormalizedEmail = "ADMIN@LOCALHOST",
                    NormalizedUserName = "ADMIN@LOCALHOST",
                    EmailConfirmed = true,
                    LockoutEnabled = false,
                    SecurityStamp = Guid.NewGuid().ToString()
                };

                IdentityResult result = _userMananger.CreateAsync(user, "Numsey#2023").Result;

                if (result.Succeeded)
                {
                    _userMananger.AddToRoleAsync(user, "Admin").Wait();
                }
            }
        }
    }
}
