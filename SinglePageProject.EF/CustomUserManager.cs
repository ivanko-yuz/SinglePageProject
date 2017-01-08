using Microsoft.AspNet.Identity;
using System;
using System.Security.Claims;

namespace SinglePageProject.EF
{
    public class CustomUserManager : UserManager<User, Guid>
    {
        public CustomUserManager(CustomUserStore store)
            : base(store)
        {
            UserValidator = new UserValidator<User, Guid>(this)
            {
                AllowOnlyAlphanumericUserNames = false
            };
        }

        public ClaimsIdentity CreateExternalIdentity(User user, string authenticationType)
        {
            return this.CreateIdentity(user, authenticationType);
        }
    }
}
