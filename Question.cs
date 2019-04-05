using System;
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

        public Question(short quesionNumber, string questionText, string answer1, string answer1Text, 
            string answer2, string answer2Text, string answer3, string answer3Text, string answer4, 
            string answer4Text, short category, string img = null) 
        {
            QuestionNumber = quesionNumber;
            QuestionText = questionText;
            Answer1 = answer1;
            Answer1Text = answer1Text;
            Answer2 = answer2;
            Answer2Text = answer2Text;
            Answer3 = answer3;
            Answer3Text = answer3Text;
            Answer4 = answer4;
            Answer4Text = answer4Text;
            Image = img; //Since the image is an optional file I have set to be NULL if one isn't added
            Category = category;

        }

        //Properties
        [Key]
        [Required]
        [Column(TypeName ="smallint")]
        public short QuestionNumber { get; set; } //Primary Key
        [Column(TypeName = "varchar(100)")]
        public string QuestionText { get; set; }
        [Column(TypeName = "varchar(2)")]
        public string Answer1 { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string Answer1Text { get; set; }
        [Column(TypeName = "varchar(2)")]
        public string Answer2 { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string Answer2Text { get; set; }
        [Column(TypeName = "varchar(2)")]
        public string Answer3 { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string Answer3Text { get; set; }
        [Column(TypeName = "varchar(2)")]
        public string Answer4 { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string Answer4Text { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string Image { get; set; }
        [Column(TypeName ="smallint")]
        public short Category { get; set; }

    }
}
