using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _418FinalProject.Models
{
    public class TestTitles
    {
        public TestTitles()
        {
        }

        public TestTitles(int testID, string title) 
        {
            TestID = testID;
            Title = title;
        }

        [Key]
        public int TestID { get; set; }

        [Column(TypeName = ("varchar(20)"))]
        public string Title { get; set; }

    }
}
