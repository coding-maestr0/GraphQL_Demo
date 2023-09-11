using API.Context;
using API.Models;
using API.ViewModels;

namespace API.Repository.Interfaces
{
   
    public interface IRolesRepository
    {
        IEnumerable<RolesObject> GetAll();
        bool AddRole(RolesVM roles);
        bool UpdateRole(RolesVM roles);
    }
}
