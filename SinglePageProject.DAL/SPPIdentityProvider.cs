using System;
using SinglePageProject.EF;

namespace SinglePageProject.DAL
{
    public class SPPIdentityProvider
    {
        public SPPContext Context
        {
            get
            {
                return new SPPContext();
            }
        }

        public CustomUserManager GetUserManager(SPPContext context)
        {
            CustomUserStore store = new CustomUserStore(context);
            CustomUserManager manager = new CustomUserManager(store);

            return manager;
        }

        internal void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
