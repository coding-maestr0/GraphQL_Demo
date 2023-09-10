using API.Repository.Interfaces;
using API.ViewModels;

namespace API.GraphQL
{
    public class UserMutations
    {
        public bool AddUsers([Service] IUsersRepository usersRepository, UsersVM user) => usersRepository.AddUser(user);
        public bool UpdateUsers([Service] IUsersRepository usersRepository, UsersVM user) => usersRepository.UpdateUser(user);
    }
}
