using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace _418FinalProject.Models
{
    [Table("Test")]
    public class Test
    {
        public Test()
        {
        }

        [Column(TypeName = "integer"), Display(Name = "Test ID"), Key]
        public int TestID { get; set; }

        [Column(TypeName = "varchar(20)"), Display(Name = "Test Title"), Required]
        public string TestTitle { get; set; }

        [Display(Name = "Questions"), Required]
        public List<Question> Questions { get; set; }

        public List<QuestionCheckedModel> SelectQuestions { get; set; }
    }
}