using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _418FinalProject.Models
{
    public class Test_Titles
    {
        public Test_Titles()
        {
        }

        public Test_Titles(int testID, string title) 
        {
            Test_ID = testID;
            Title = title;
        }

        [Key]
        public int Test_ID { get; set; }

        [Column(TypeName = ("varchar(20)"))]
        public string Title { get; set; }

    }
}

