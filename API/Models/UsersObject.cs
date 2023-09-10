using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    public class UsersObject
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }    
        public string Email { get; set; }


        [ForeignKey("RolesId")]
        public int RolesId { get; set; }
        public RolesObject Roles { get; set; }

    }
}
