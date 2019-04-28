using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using _418FinalProject.Models;
using System.Data.SqlClient;
using System;
using System.Data;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace _418FinalProject.Controllers
{
    public class AdminTestController : Controller
    {
        //private readonly SqlConnectionStringBuilder builder;

        public AdminTestController()
        {

        }

        // GET: /<controller>/
        public IActionResult Index()
        {

            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "testtaker.database.windows.net";
            builder.UserID = "user";
            builder.Password = "Password1";
            builder.InitialCatalog = "TestTaker";

            List<Test> tests = new List<Test>();

            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {
                connection.Open();
                String sql = "SELECT * FROM Test_Titles;";


                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                            tests.Add
                            (
                                new Test
                                {
                                    TestID = reader.GetInt32(0),
                                    TestTitle = reader.GetString(1)
                                }
                            );
                    }
                    connection.Close();
                }
            }
            return View(tests);
        }

        //Page 
        //GET: /admintest/addtest
        public IActionResult AddTest()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "testtaker.database.windows.net";
            builder.UserID = "user";
            builder.Password = "Password1";
            builder.InitialCatalog = "TestTaker";

            List<Question> qs = new List<Question>();
            List<QuestionCheckedModel> qcm = new List<QuestionCheckedModel>();


            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {
                connection.Open();
                String sql = "SELECT * FROM Questions;";


                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read()) 
                        {
                            qs.Add
                            (
                                new Question
                                {
                                    QuestionID = reader.GetInt32(0),
                                    Category = Convert.ToString(reader.GetInt32(1)),
                                    TrueFalse = reader.GetBoolean(2),
                                    QuestionText = reader.GetString(3),
                                    Answer1Text = reader.GetString(4),
                                    Answer2Text = reader.GetString(5),
                                    Answer3Text = reader.GetString(6),
                                    Answer4Text = reader.GetString(7)
                                }
                            );
                            qcm.Add
                                (

                                new QuestionCheckedModel
                                {
                                    QuestionID = reader.GetInt32(0),
                                    Category = Convert.ToString(reader.GetInt32(1)),
                                    QuestionText = reader.GetString(3),
                                }

                                );
                        }
                    }
                    connection.Close();
                }
            }
            ViewData["Questions"] = qs;

            return View(new Test());
        }

    }
}
