using Microsoft.AspNet.Identity.EntityFramework;
using System;

namespace SinglePageProject.EF
{
    public class User : IdentityUser<Guid, UserLogin, UserRole, UserClaim>
    {
    }
}
