using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Threading.Tasks;

namespace SinglePageProject.DAL.Interfaces
{
    public interface IAuthRepository
    {
        //Task<IdentityResult> RegisterUser(IdentityUser userModel);
        //Task<IdentityUser> FindUser(string userName, string password);
        void Dispose();
    }
}
