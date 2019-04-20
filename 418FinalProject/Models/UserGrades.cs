using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace _418FinalProject.Models
{
    public class UserGrades
    {
        public UserGrades()
        {
        }

        public UserGrades(string userName, int testID, int grade) 
        {
            UserRefName = userName;
            TestRefID = testID;
            Grade = grade; 
        }

        [Column(TypeName ="varchar(20)"), ForeignKey("User_Name")]
        public string UserRefName { get; set; }

        [Column(TypeName = "integer"), ForeignKey("Test_ID")]
        public int TestRefID { get; set; }

        [Column(TypeName = "integer"), Required]
        public int Grade{ get; set; }
    }
}
