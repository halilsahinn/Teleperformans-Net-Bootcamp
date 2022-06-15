using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace _4_Odev.Entities
{
    [Table("Main", Schema = "User")]
    public class UserEntity : IdentityUser
    {
       
        public string Email { get; set; }
        public string Password { get; set; }

        public string Name { get; set; }
        public string SurName { get; set; }


        public bool IsActive { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime UpdatedDate { get; set; }
    }
}
