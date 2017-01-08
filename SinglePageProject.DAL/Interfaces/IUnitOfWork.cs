using SinglePageProject.EF;

namespace SinglePageProject.DAL.Interfaces
{
    public interface IUnitOfWork
    {
        IGenericRepository<User> UserRepository { get; }
    }
}
