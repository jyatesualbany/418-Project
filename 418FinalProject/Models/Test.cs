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

        [Column("Test ID",TypeName = "integer"), Key]
        public int TestID { get; set; }

        [Column(TypeName ="integer")]
        public int TestRefID { get; set; }


        [Column(TypeName = "integer")]
        public int QuestionRefID { get; set; }
     
        [Column("Quesitions")]
        public List<Question> Questions { get; set; }
    }
}
