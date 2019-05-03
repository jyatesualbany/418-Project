using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace _418FinalProject.Models
{
    public class UserGrades
    {
        public UserGrades()
        {
        }

        public UserGrades(int userName, int testID, int grade) 
        {
            UserRefName = userName;
            TestRefID = testID;
            Grade = grade; 
        }

        [Column(TypeName ="integer"), Required]
        public int UserRefName { get; set; }

        [Column(TypeName = "integer"), Required]
        public int TestRefID { get; set; }

        [Column(TypeName = "integer"), Key, Required]
        public int Grade{ get; set; }
    }
}

