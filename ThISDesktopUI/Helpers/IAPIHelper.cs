using System.Threading.Tasks;
using ThISDesktopUI.Models;

namespace ThISDesktopUI.Helpers
{
    public interface IAPIHelper
    {
        Task<AuthenticatedUser> Authenticate(string username, string password);
    }
}