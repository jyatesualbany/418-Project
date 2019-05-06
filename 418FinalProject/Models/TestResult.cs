using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
<<<<<<< HEAD
using System;

=======
using System;

>>>>>>> Julie
namespace _418FinalProject.Models
{
    [Table("TestResults")]
    public class TestResults
    {

<<<<<<< HEAD
        public TestResults()
        {
        }

        [Display(Name = "Test ID")] 
        [Column("Test ID", TypeName = "integer"), Key]
        public int TestID { get; set; }

=======
        public TestResults()
        {
        }

        [Display(Name = "Test ID")]
        [Column("Test ID", TypeName = "integer"), Key]
        public int TestID { get; set; }

>>>>>>> Julie
        [Display(Name = "Question ID")]
        [Column("Question ID", TypeName = "integer")]
        public int QuestionID { get; set; }

        [Display(Name = "Test Title")]
        [Column("Test Title", TypeName = "varchar(100)"), StringLength(100), Required]
        public String Test_Title { get; set; }

        [Display(Name = "Question")]
        [Column("Question", TypeName = "varchar(100)"), StringLength(100), Required]
<<<<<<< HEAD
        public String Question { get; set; }

=======
        public String Question { get; set; }

>>>>>>> Julie
        [Display(Name = "Answer 1 Text")]
        [Column("ANS1", TypeName = "varchar(100)"), StringLength(100), Required]
        public string Answer1Text { get; set; }

        [Display(Name = "Answer 2 Text")]
        [Column("ANS2", TypeName = "varchar(100)"), StringLength(100), Required]
        public string Answer2Text { get; set; }

        [Display(Name = "Answer 3 Text")]
        [Column("ANS3", TypeName = "varchar(100)"), StringLength(100), Required]
        public string Answer3Text { get; set; }

        [Display(Name = "Answer 4 Text")]
        [Column("ANS4", TypeName = "varchar(100)"), StringLength(100), Required]
        public string Answer4Text { get; set; }

    }
}