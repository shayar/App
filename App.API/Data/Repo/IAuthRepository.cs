using System.Threading.Tasks;
using App.API.Models;

namespace App.API.Data.Repo
{
    public interface IAuthRepository
    {
         Task<User> Register(User user, string password);
         Task<User> Login(string username, string password);
         Task<bool> UserExists(string username);
    }
}