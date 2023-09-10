using API.Models;
using API.Repository.Interfaces;

namespace API.GraphQL
{
    public class Query
    {
        public IEnumerable<UsersObject> GetUsersData([Service] IUsersRepository usersRepository) => usersRepository.GetAll();
        public IEnumerable<RolesObject> GetRolesData([Service] IRolesRepository rolesRepository) => rolesRepository.GetAll();
    }
}
