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
using System.Web;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace _418FinalProject.Controllers
{
    public class AdminTestController : Controller
    {
        //private readonly SqlConnectionStringBuilder builder;
        public Test tempTest;

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
            return View(new Test());
        }

        //Page 
        //POST: /admintest/addtest/
        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult AddTest([Bind("TestID, TestTitle")] Test test)
        {
            return RedirectToAction(nameof(TestQuestions), test);
        }

        //Page 
        //GET: /admintest/testquestions
        public IActionResult TestQuestions(Test test)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "testtaker.database.windows.net";
            builder.UserID = "user";
            builder.Password = "Password1";
            builder.InitialCatalog = "TestTaker";

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
                            qcm.Add
                                (

                                new QuestionCheckedModel
                                {
                                    QuestionID = reader.GetInt32(0),
                                    Category = Convert.ToString(reader.GetInt32(1)),
                                    QuestionText = reader.GetString(3),
                                    Checked = false
                                }
                                );
                        }
                    }
                    connection.Close();
                }
            }
            ViewData["Questions"] = qcm;

            return View(test);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult TestQuestions()
        {
            var nvc = Request.Form;

            Test test;
            string q_id;
            try
            {
                test = new Test
                {
                    TestID = Int32.Parse(nvc["TestID"]),
                    TestTitle = nvc["TestTitle"],
                    SelectQuestions = new List<QuestionCheckedModel>()
                };

                q_id = nvc["sql"];
            }
            catch (Exception e)
            {
                return NotFound(e);
            }



            ViewData["Debugging"] = q_id;


            return View("Details", test);
        }
    }
}
