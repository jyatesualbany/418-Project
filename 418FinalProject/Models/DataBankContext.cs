using Microsoft.EntityFrameworkCore;

namespace _418FinalProject.Models
{
    public class DataBankContext : DbContext
    {

        public DataBankContext(DbContextOptions<DataBankContext> options) : base(options)
        {
        }

        public DbSet<Question> Questions { get; set; }
        public DbSet<User> Users { get; set; }
<<<<<<< HEAD
        public DbSet<Test> Tests { get; set; }
        public DbSet<TestResults> TestResults { get; set; }
        public DbSet<UserGrades> User_Grades { get; set; }
=======
        public DbSet<Test> Test { get; set; }
        public DbSet<Test_Titles> Test_Titles { get; set;}
        public DbSet<TestResults> TestResults { get; set; }
>>>>>>> Julie

    }
}
