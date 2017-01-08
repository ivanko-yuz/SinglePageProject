using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Data.Entity;

namespace SinglePageProject.EF
{
    public class CustomUserStore : UserStore<User, Role, Guid, UserLogin, UserRole, UserClaim>
    {
        public CustomUserStore(DbContext context) : base(context)
        {
        }
    }
}
