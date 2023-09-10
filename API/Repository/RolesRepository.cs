using API.Context;
using API.Models;
using API.Repository.Interfaces;

namespace API.Repository
{
    public class RolesRepository : IRolesRepository
    {
        public readonly ApplicationDbContext _dbContext;

        public RolesRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<RolesObject> GetAll()
        {
            return _dbContext.Roles.ToList();
        }
    }
}
