using System;
using Microsoft.EntityFrameworkCore;
namespace _418FinalProject.Models
{
    public class QuesitonContext : DbContext
    {
        public QuesitonContext(DbContextOptions<QuesitonContext> options) : base(options)
        {
        }

        public DbSet<Question> Questions { get; set; }
    }
}
