using System.Collections.Generic;
using System.Threading.Tasks;
using App.API.Models;

namespace App.API.Data.Repo
{
    public interface IDatingRepository
    {
         void Add<T>(T entity) where T: class;

         void Delete<T>(T entity) where T: class;

         Task<bool> SaveAll();

         Task<IEnumerable<User>> GetUsers();

         Task<User> GetUser(int id);

    }
}