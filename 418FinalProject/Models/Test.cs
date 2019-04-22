using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace _418FinalProject.Models
{
    [Table("Tests")]
    public class Test
    {

        public Test() 
        { 
        }

        public Test(int testID, int questionID, Question question) 
        {
            TestRefID = testID;
            QuestionRefID = questionID;
            Questions.Add(question);
        }

        [Column(TypeName ="integer"), ForeignKey("Test_ID")]
        public int TestRefID { get; set; }


        [Column(TypeName = "integer"), ForeignKey("Question_ID")]
        public int QuestionRefID { get; set; }

        [Column("Quesitions")]
        public List<Question> Questions { get; set; }
    }
}
