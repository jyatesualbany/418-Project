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

        public User(string username, string password, bool? type) 
        {
            Username = username;
            Password = password;
            Type = Type;//If true then the user is an admin else the user is a test taker.
        }

        [Column("USER_NAME",TypeName = "varchar(20)"), Key]
        public string Username { get; set; }

        [Column("PASSWORD", TypeName = "varchar(20)"),Required]
        public string Password { get; set; }

        [Column("ADMIN", TypeName = "BIT"), Required]
        public bool Type { get; set; }
    }
}
