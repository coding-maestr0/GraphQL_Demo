using API.Context;
using API.Models;

namespace API.Repository.Interfaces
{
   
    public interface IRolesRepository
    {
        IEnumerable<RolesObject> GetAll();
    }
}
