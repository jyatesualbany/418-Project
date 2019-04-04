using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _418FinalProject.Models
{
    public class Question
    {
        [Required]
        [Column(TypeName ="smallint")]
        public short QuestionNumber { get; set; }
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
