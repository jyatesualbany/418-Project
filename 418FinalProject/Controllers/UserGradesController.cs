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
    public class UserGradesController : Controller
    {
        private readonly DataBankContext _context;

        public UserGradesController(DataBankContext context)
        {
            _context = context;
        }

        // GET: UserGrades
        public IActionResult Index()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "testtaker.database.windows.net";
            builder.UserID = "user";
            builder.Password = "Password1";
            builder.InitialCatalog = "TestTaker";

            List<UserGrades> grades = new List<UserGrades>();


            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {
                connection.Open();
                String sql = "SELECT * FROM User_Grades;";


                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                            grades.Add
                            (
                                new UserGrades
                                {
                                    UserRefName = reader.GetInt32(0),
                                    TestRefID = reader.GetInt32(1),
                                    Grade = reader.GetInt32(2),
                                }
                            );
                    }
                    connection.Close();
                }
            }

            return View(grades);
        }
        

        // GET: UserGrades/Details/5
        public IActionResult Details(int? id)

        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "testtaker.database.windows.net";
            builder.UserID = "user";
            builder.Password = "Password1";
            builder.InitialCatalog = "TestTaker";

            List <UserGrades> individual = new List <UserGrades>();
            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {
                connection.Open();

                String sql = "SELECT * FROM User_Grades WHERE User_ID = '" + id
                        + "';";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                            individual.Add
                                  (
                                new UserGrades
                                {
                                    UserRefName = reader.GetInt32(0),
                                    TestRefID = reader.GetInt32(1),
                                    Grade = reader.GetInt32(2),
                                }
                          );
                           
                    }
                    connection.Close();
                }
            }

            return View(individual.FirstOrDefault());


        }


        private bool UserGradesExists(int id)
        {
            return _context.User_Grades.Any(e => e.Grade == id);
        }
    }
}
