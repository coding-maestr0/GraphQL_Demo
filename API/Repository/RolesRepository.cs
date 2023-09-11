using API.Context;
using API.Models;
using API.Repository.Interfaces;
using API.ViewModels;
using Microsoft.Identity.Client;

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

        public bool AddRole(RolesVM roles)
        {
            RolesObject role = new RolesObject()
            {
                RoleName = roles.RoleName
            };
            _dbContext.Roles.Add(role);
            _dbContext.SaveChanges();
            return true;
        }

        public bool UpdateRole(RolesVM roles)
        {
            var find = _dbContext.Roles.Where(x => x.Id == roles.Id).FirstOrDefault();
            if (find != null)
            {
                find.RoleName = roles.RoleName;
                _dbContext.Update(find);
                _dbContext.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
