﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using _418FinalProject.Models;
using System.Data.SqlClient;
using System;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace _418FinalProject.Controllers
{
    public class LoginController : Controller
    {

        private DataBankContext _context; //Database 

        //Constructor
        public LoginController(DataBankContext context) 
        {
            _context = context;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult UserLogin(LoginViewModel model)
        {
            /*
            var usr = await _context.Users.FirstOrDefaultAsync(
            
            u => (u.Username == model.Username) && (u.Password == model.Password));
            if (usr == null) 
            {
                return NotFound(); 
            }
            
            if (usr.Type == true) { return Redirect("/admin/index"); }
            */

            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "testtaker.database.windows.net";
            builder.UserID = "user";
            builder.Password = "Password1";
            builder.InitialCatalog = "TestTaker";

            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {
                connection.Open();
                String sql = "SELECT USER_NAME, PASSWORD, ADMIN FROM dbo.Users WHERE USER_NAME = '" + model.Username + "';";



                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                            if (reader.GetString(0) == model.Username && reader.GetString(1) == model.Password)
                            {
                                if (reader.GetBoolean(2) == true) return Redirect("/Admin/index");
                                else return Redirect("/NonAdmin/Index");
                            }

                    }   //need to fix this, gives error message for every incorrect row it checks
                    connection.Close();
                }
            }

            return NotFound();
        }
    }
}
