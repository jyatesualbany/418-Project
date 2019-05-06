<<<<<<< HEAD
﻿using System;
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
    public class TestResultsController : Controller
    {
        private readonly DataBankContext _context;

        public TestResultsController(DataBankContext context)
        {
            _context = context;
        }

        // GET: TestResults
        public IActionResult Index()
        {
=======
﻿using System;
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
    public class TestResultsController : Controller
    {
        private readonly DataBankContext _context;

        public TestResultsController(DataBankContext context)
        {
            _context = context;
        }

        // GET: TestResults
        public IActionResult Index()
        {
>>>>>>> Julie
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "testtaker.database.windows.net";
            builder.UserID = "user";
            builder.Password = "Password1";
            builder.InitialCatalog = "TestTaker";

            List<TestResults> tests = new List<TestResults>();


            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {
                connection.Open();
<<<<<<< HEAD
                
=======

>>>>>>> Julie
                String sql = "SELECT * from Test_Titles";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                            tests.Add
                            (
                                new TestResults
<<<<<<< HEAD
                                {
                                    TestID = reader.GetInt32(0),
                                    Test_Title = reader.GetString(1),
                                    
=======
                                {
                                    TestID = reader.GetInt32(0),
                                    Test_Title = reader.GetString(1),

>>>>>>> Julie
                                }
                            );
                    }
                    connection.Close();
                }
            }

<<<<<<< HEAD
            return View(tests);
        }

        // GET: TestResults/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

=======
            return View(tests);
        }

        // GET: TestResults/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

>>>>>>> Julie
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "testtaker.database.windows.net";
            builder.UserID = "user";
            builder.Password = "Password1";
            builder.InitialCatalog = "TestTaker";

            List<TestResults> tests = new List<TestResults>();


            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {
<<<<<<< HEAD
                connection.Open();

                String sql = "SELECT * from Test_Titles a inner join Tests b"
=======
                connection.Open();

                String sql = "SELECT * from Test_Titles a inner join Tests b"
>>>>>>> Julie
                    + " on a.Test_ID = b.Test_ID inner join Questions c on"
                    + " b.Question_ID = c.Question_ID WHERE b.Test_ID = '" + id
                    + "'";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
<<<<<<< HEAD
                    {
                       
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


=======
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


>>>>>>> Julie
                                }
                            );
                    }
                    connection.Close();
                }
            }

<<<<<<< HEAD
            foreach(var curr in tests)
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
=======
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
>>>>>>> Julie
