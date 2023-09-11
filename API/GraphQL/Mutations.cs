using API.Repository.Interfaces;
using API.ViewModels;

namespace API.GraphQL
{
    public class Mutations
    {
        public bool AddUsers([Service] IUsersRepository usersRepository, UsersVM user) => usersRepository.AddUser(user);
        public bool UpdateUsers([Service] IUsersRepository usersRepository, UsersVM user) => usersRepository.UpdateUser(user);
        public bool AddRole([Service] IRolesRepository roleRepository, RolesVM roles) => roleRepository.AddRole(roles);
        public bool UpdateRole([Service] IRolesRepository rolesRepository, RolesVM roles) => rolesRepository.UpdateRole(roles);
    }
}
