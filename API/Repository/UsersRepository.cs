using API.Context;
using API.Models;
using API.Repository.Interfaces;
using API.ViewModels;

namespace API.Repository
{
    public class UsersRepository : IUsersRepository
    {
        public readonly ApplicationDbContext _dbContext;
        public UsersRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<UsersObject> GetAll()
        {
            return _dbContext.Users.ToList();
        }

        public bool AddUser(UsersVM user)
        {
            UsersObject model = new UsersObject()
            {
                Name = user.Name,
                Email = user.Email,
                RolesId = user.RolesId,
            };
            _dbContext.Users.Add(model);
            _dbContext.SaveChanges();
            return true;
        }

        public bool UpdateUser(UsersVM user)
        {
            var find = _dbContext.Users.Where(x => x.Id == user.Id).FirstOrDefault();
            if (find != null)
            {
                find.Name = user.Name;
                find.Email = user.Email;
                find.RolesId = user.RolesId;
                _dbContext.Users.Update(find);
                _dbContext.SaveChanges();
                return true;
            }
            return false;
           
        }
    }
}
