using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _418FinalProject.Models
{
    [Table("Question")]
    public class Question
    {
        //Constructors
        public Question()
        {
        }

        [Column("Question ID"),Display(Name = "Question ID"),Key]
        public int QuestionID { get; set; }//Primary Key

        [Column(TypeName = "varchar(20)"), Required]
        public string Category { get; set; }

        [Display(Name = "Question Text")]
        [Column("Question Text",TypeName = "varchar(100)"),StringLength(100), Required]
        public string QuestionText { get; set; }

        [Column("True False",TypeName = "bit"), Display(Name ="True/False") ,Required]
        public bool TrueFalse { get; set; }

        [Display(Name ="Answer 1 Text")]
        [Column("ANS1",TypeName = "varchar(100)"), StringLength(100), Required]
        public string Answer1Text { get; set; }

        [Display(Name = "Answer 2 Text")]
        [Column("ANS2",TypeName = "varchar(100)"), StringLength(100), Required]
        public string Answer2Text { get; set; }

        [Display(Name = "Answer 3 Text")]
        [Column("ANS3",TypeName = "varchar(100)"), StringLength(100), Required]
        public string Answer3Text { get; set; }

        [Display(Name = "Answer 4 Text")]
        [Column("ANS4",TypeName = "varchar(100)"), StringLength(100), Required]
        public string Answer4Text { get; set; }

        [Column("Image",TypeName = "varchar(100)"), StringLength(100)]
        public string Image { get; set; }
    }
}
