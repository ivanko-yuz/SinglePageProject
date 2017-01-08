using SinglePageProject.DAL.Interfaces;
using SinglePageProject.EF;

namespace SinglePageProject.DAL
{
    public class UnitOfWork : IUnitOfWork
    {

        private SPPContext context = new SPPContext();
        private IGenericRepository<User> userRepository;

        public IGenericRepository<User> UserRepository
        {
            get
            {
                if (userRepository == null)
                {
                    userRepository = new GenericRepository<User>(context);
                }

                return userRepository;
            }
        }
    }
}
