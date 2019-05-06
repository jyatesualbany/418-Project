using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _418FinalProject.Models
{
    public class QuestionCheckedModel
    {
        public QuestionCheckedModel()
        {
        }

        [Display(Name = "Question ID")]
        public int QuestionID { get; set; }

        [Display(Name ="Category")]
        public string Category { get; set; }

        [Display(Name = "Question Text")]
        public string QuestionText { get; set; }

        [Display(Name = "Selected")]
        public bool Checked { get; set; }
    }
<<<<<<< HEAD
}
=======
}
>>>>>>> Julie
