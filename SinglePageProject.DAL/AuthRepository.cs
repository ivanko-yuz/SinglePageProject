using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using SinglePageProject.DAL.Interfaces;
using SinglePageProject.EF;
using System;
using System.Security.Claims;
using System.Threading.Tasks;

namespace SinglePageProject.DAL
{
    public class AuthRepository : IDisposable, IAuthRepository
    {
        private readonly SPPIdentityProvider provider;

        public AuthRepository()
        {
            provider = new SPPIdentityProvider();
        }
        //public async Task<IdentityResult> RegisterUser(User registerUserModel)
        //{
        //    User user = registerUserModel;

        //    using (var context = provider.Context)
        //    {
        //        CustomUserManager manager = provider.GetUserManager(context);
        //        IdentityResult result = await manager.CreateAsync(user, registerUserModel.PasswordHash);
        //        if (result.Succeeded)
        //        {
        //            await manager.AddToRolesAsync(user.Id, "User");
        //        }

        //        return result;
        //    }
        //}

        public async Task<IdentityResult> CreateAsync(User user)
        {
            using (var context = provider.Context)
            {
                CustomUserManager userManager =
                    provider.GetUserManager(context);
                var result = await userManager.CreateAsync(user);

                return result;
            }
        }

        public async Task<User> FindUser(string userName, string password)
        {
            using (var context = provider.Context)
            {
                CustomUserManager manager = provider.GetUserManager(context);
                User user = await manager.FindAsync(userName, password);

                return user;
            }
        }

        public async Task<ClaimsIdentity> CreateIdentity(User user, string authenticationType)
        {
            using (var context = provider.Context)
            {
                CustomUserManager manager = provider.GetUserManager(context);
                var userIdentity = await manager.CreateIdentityAsync(user, authenticationType);

                return userIdentity;
            }
        }

        public void Dispose()
        {
            provider.Dispose();
        }
    }
}
