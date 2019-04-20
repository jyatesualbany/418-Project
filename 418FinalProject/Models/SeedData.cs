using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace _418FinalProject.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new QuesitonContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<QuesitonContext>>()))
            {
                // Look for any movies.
                if (context.Questions.Any())
                {
                    return;   // DB has been seeded
                }

                context.Questions.AddRange(
                    new Question
                    {
                        QuestionNumber = 1,
                        QuestionText = "What is 1 + 1?",
                        Answer1 = "a",
                        Answer1Text = "11",
                        Answer2 = "b",
                        Answer2Text = "2",
                        Answer3 = "c",
                        Answer3Text = "4",
                        Answer4 = "d",
                        Answer4Text = "0",
                        Category = 1

                    },

                    new Question
                    {
                        QuestionNumber = 2,
                        QuestionText = "How many numbers are there, between 1 and 100 that are both a perfect square and even?",
                        Answer1 = "a",
                        Answer1Text = "0",
                        Answer2 = "b",
                        Answer2Text = "2",
                        Answer3 = "c",
                        Answer3Text = "5",
                        Answer4 = "d",
                        Answer4Text = "10",
                        Category = 2

                    },

                    new Question
                    {
                        QuestionNumber = 3,
                        QuestionText = "What is the common name for the Periodic element H2O?",
                        Answer1 = "a",
                        Answer1Text = "Water",
                        Answer2 = "b",
                        Answer2Text = "Salt",
                        Answer3 = "c",
                        Answer3Text = "Vinegar",
                        Answer4 = "d",
                        Answer4Text = "Sugar",
                        Category = 1

                    },

                    new Question
                    {
                        QuestionNumber = 4,
                        QuestionText = "The war of 1812 took place in what year?",
                        Answer1 = "a",
                        Answer1Text = "1218",
                        Answer2 = "b",
                        Answer2Text = "1939",
                        Answer3 = "c",
                        Answer3Text = "1812",
                        Answer4 = "d",
                        Answer4Text = "1776",
                        Category = 2

                    }
                );
                context.SaveChanges();
            }
        }
    }
}
