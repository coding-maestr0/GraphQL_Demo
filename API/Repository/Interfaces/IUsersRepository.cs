using API.Models;
using API.ViewModels;

namespace API.Repository.Interfaces
{
    public interface IUsersRepository
    {
        IEnumerable<UsersObject> GetAll();
        bool AddUser(UsersVM user);
        bool UpdateUser(UsersVM user);
    }
}
