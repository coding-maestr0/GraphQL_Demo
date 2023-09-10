using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    public class RolesObject
    {
        [Key]
        public int Id { get; set; }
        public string RoleName { get; set; }

        public ICollection<UsersObject> Users { get; set; }
    }
}
