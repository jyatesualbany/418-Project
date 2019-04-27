using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _418FinalProject.Models
{
    [Table("User")]
    public class User
    {
        public User()
        {
        }

        [Column("USER_ID"), Display(Name = "User ID"), Key]
        public int UserID { get; set; }

        [Column("USER_NAME",TypeName = "varchar(20)"), Display(Name = "Username") , Required]
        public string Username { get; set; }

        [Column("PASSWORD", TypeName = "varchar(20)"), Required]
        public string Password { get; set; }

        [Column("ADMIN", TypeName = "BIT"), Required]
        public bool Type { get; set; }
    }
}
