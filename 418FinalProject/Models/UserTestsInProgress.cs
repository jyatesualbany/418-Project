using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace _418FinalProject.Models
{
    public class UserTestsInProgress
    {
        public UserTestsInProgress()
        {
        }

        public UserTestsInProgress(string userName, int testID, int questionID, string selectedAnswer) 
        {
            UserNameRef = userName;
            TestID = testID;
            QuestionID = questionID;
            SelectedAnswer = selectedAnswer;
        }

        [Column("User Test In Progress"), Key]
        public int UserTestInProgress { get; set; }

        [Column(TypeName ="varchar(20)")]
        public string UserNameRef { get; set; }

        [Column(TypeName ="integer")]
        public int TestID { get; set; }

        [Column(TypeName = "integer")]
        public int QuestionID { get; set; }

        [Column(TypeName = "varchar(20)")]
        public string SelectedAnswer { get; set; }
    }
}
