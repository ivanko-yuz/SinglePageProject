using Microsoft.AspNet.Identity.EntityFramework;
using System;

namespace SinglePageProject.EF
{
    public class Role : IdentityRole<Guid,UserRole>
    {
    }
}
