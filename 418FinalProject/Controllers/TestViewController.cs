using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using _418FinalProject.Models;
using System.Data.SqlClient;

namespace _418FinalProject.Controllers
{
    public class TestViewController : Controller
    {
        private readonly DataBankContext _context;

        public TestViewController(DataBankContext context)
        {
            _context = context;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {

            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "testtaker.database.windows.net";
            builder.UserID = "user";
            builder.Password = "Password1";
            builder.InitialCatalog = "TestTaker";

            List<Test_Titles> test_Titles = new List<Test_Titles>();

            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {
                connection.Open();
                String sql = "SELECT * FROM Test_Titles;";

               

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                            test_Titles.Add
                            (
                                new Test_Titles
                                {
                                    Test_ID = reader.GetInt32(0),
                                    Title = reader.GetString(1)
                                }
                            );
                    }
                    connection.Close();
                }
            }
            return View(test_Titles);
        }

        // GET: TestView/Details/5
        public IActionResult Select(int? id)
        {
            if (id == null) return NotFound();


            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "testtaker.database.windows.net";
            builder.UserID = "user";
            builder.Password = "Password1";
            builder.InitialCatalog = "TestTaker";

            List<Tests> test = new List<Tests>();

            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {
                connection.Open();
                String sql = "SELECT Questions.QUESTION_TEXT,Questions.ANS1," +
                    "Questions.ANS2,Questions.ANS3, Questions.ANS4 FROM Tests,Questions" +
                    "WHERE Test.Test_ID = " + Convert.ToString(id) + " AND Tests.QUESTION_ID = Questions.QUESTION_ID;";

                SqlCommand command = new SqlCommand(sql, connection);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    reader.GetString(0);
                    reader.GetString(1);
                    reader.GetString(2);
                    reader.GetString(3);
                    reader.GetString(4);
                   // Console.WriteLine(reader[0]);
                }
                reader.Close();
                connection.Close();
            }

            if (test == null) return NotFound();

            return View(test);
        }

        // GET: TestView/Results
        public IActionResult Result(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "testtaker.database.windows.net";
            builder.UserID = "user";
            builder.Password = "Password1";
            builder.InitialCatalog = "TestTaker";

            List<TestResults> tests = new List<TestResults>();


            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {
                connection.Open();

                String sql = "SELECT * from Test_Titles a inner join Tests b"
                    + " on a.Test_ID = b.Test_ID inner join Questions c on"
                    + " b.Question_ID = c.Question_ID WHERE b.Test_ID = '" + id
                    + "'";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // int i = 8;
                        while (reader.Read())

                            tests.Add
                            (
                                new TestResults
                                {


                                    TestID = reader.GetInt32(0),
                                    Test_Title = reader.GetString(1),
                                    QuestionID = reader.GetInt32(3),
                                    Question = reader.GetString(7),
                                    Answer1Text = reader.GetString(8),
                                    Answer2Text = reader.GetString(9),
                                    Answer3Text = reader.GetString(10),
                                    Answer4Text = reader.GetString(11),


                                }
                            );
                    }
                    connection.Close();
                }
            }

            foreach (var curr in tests)
            {
                if (curr.Answer2Text.Contains("*"))
                {
                    curr.Answer1Text = curr.Answer2Text;
                }
                else if (curr.Answer3Text.Contains("*"))
                {
                    curr.Answer1Text = curr.Answer3Text;
                }
                else if (curr.Answer4Text.Contains("*"))
                {
                    curr.Answer1Text = curr.Answer4Text;
                }
            }

            return View(tests);
        }


        private bool TestResultsExists(int id)
        {
            return _context.TestResults.Any(e => e.TestID == id);
        }
    }
}

