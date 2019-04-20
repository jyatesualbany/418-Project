using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace _418FinalProject.Models
{
    public class Test
    {

        public Test() 
        { 
        }

        public Test(int testID, int questionID) 
        {
            TestRefID = testID;
            QuestionRefID = questionID;
        }

        [Column(TypeName ="integer"), ForeignKey("Test_ID")]
        public int TestRefID { get; set; }


        [Column(TypeName = "integer"), ForeignKey("Question_ID")]
        public int QuestionRefID { get; set; }
    }
}
