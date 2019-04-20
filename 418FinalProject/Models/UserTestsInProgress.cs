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

        [Column(TypeName ="varchar(20)"), ForeignKey("User_Name")]
        public string UserNameRef { get; set; }

        [Column(TypeName ="integer"), ForeignKey("Test_ID")]
        public int TestID { get; set; }

        [Column(TypeName = "integer"), ForeignKey("Question_ID")]
        public int QuestionID { get; set; }

        [Column(TypeName = "varchar(20)")]
        public string SelectedAnswer { get; set; }
    }
}
