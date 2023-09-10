using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<RolesObject> Roles { get; set; }
        public DbSet<UsersObject> Users{ get; set; }
    }
}
