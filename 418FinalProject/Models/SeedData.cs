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
            using (var context = new DataBankContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<DataBankContext>>()))
            {
                // Look for any movies.
                if ((context.Questions.Any())|| (context.Users.Any()))
                {
                    return;   // DB has been seeded
                }

                context.Questions.AddRange(
                    new Question
                    {
                        QuestionID = 1,
                        QuestionText = "What is 1 + 1?",
                       
                        Answer1Text = "11",

                        Answer2Text = "2",

                        Answer3Text = "4",
                       
                        Answer4Text = "0",
                        Category = "Mathematics"

                    },

                    new Question
                    {
                        QuestionID = 2,
                        QuestionText = "How many numbers are there, between 1 and 100 that are both a perfect square and even?",

                        Answer1Text = "0",
                       
                        Answer2Text = "2",

                        Answer3Text = "5",

                        Answer4Text = "10",
                        Category = "Mathematics"

                    },

                    new Question
                    {
                        QuestionID = 3,
                        QuestionText = "What is the common name for the Periodic element H2O?",
                       
                        Answer1Text = "Water",
                       
                        Answer2Text = "Salt",
                       
                        Answer3Text = "Vinegar",

                        Answer4Text = "Sugar",
                        Category = "Chemistry"

                    },

                    new Question
                    {
                        QuestionID = 4,
                        QuestionText = "The war of 1812 took place in what year?",

                        Answer1Text = "1218",

                        Answer2Text = "1939",
                       
                        Answer3Text = "1812",

                        Answer4Text = "1776",
                        Category = "History"

                    }
                );
                context.Users.AddRange(
                new User
                {
                    Username = "User1",
                    Password = "Password1",
                    Type = true
                },

                new User
                {
                    Username = "User2",
                    Password = "Password2",
                    Type = false

                }
                 );
                context.SaveChanges();
            }
        }
    }
}
