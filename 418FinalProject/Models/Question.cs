using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _418FinalProject.Models
{
    public class Question
    {
        //Constructors
        public Question()
        {
        }

        public Question(int quesionID, string questionText, string answer1Text, string answer2Text, 
            string answer3Text, string answer4Text, string category, string img = null)
        {
            QuestionID = quesionID;
            QuestionText = questionText;
            Answer1Text = answer1Text;
            Answer2Text = answer2Text;
            Answer3Text = answer3Text;
            Answer4Text = answer4Text;
            Image = img; //Since the image is an optional file I have set to be NULL if one isn't added
            Category = category;

        }

        [Column("Question_ID"),Key]
        public int QuestionID { get; set; }//Primary Key

        [Column(TypeName = "varchar(20)"), Required]
        public string Category { get; set; }

        [Column("Question_Text",TypeName = "varchar(100)"), StringLength(100), Required]
        public string QuestionText { get; set; }

        [Column("True_False",TypeName = "bit"), Required]
        public byte TrueFalse { get; set; }

        [Column("ANS1",TypeName = "varchar(100)"), StringLength(100), Required]
        public string Answer1Text { get; set; }

        [Column("ANS2",TypeName = "varchar(100)"), StringLength(100), Required]
        public string Answer2Text { get; set; }

        [Column("ANS3",TypeName = "varchar(100)"), StringLength(100), Required]
        public string Answer3Text { get; set; }

        [Column("ANS4",TypeName = "varchar(100)"), StringLength(100), Required]
        public string Answer4Text { get; set; }

        [Column(TypeName = "varchar(100)"), StringLength(100)]
        public string Image { get; set; }
    }



}
