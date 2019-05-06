using System.Threading.Tasks;
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

                    }
                    connection.Close();
                }
            }

            return NotFound();
        }

        public IActionResult AddUser()
        {
            return View(new User());
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult AddUser([Bind("UserID,Username,Password,Type")] User user)
        {
            if (ModelState.IsValid)
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "testtaker.database.windows.net";
                builder.UserID = "user";
                builder.Password = "Password1";
                builder.InitialCatalog = "TestTaker";

                int next_ID = 0;

                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {

                    connection.Open();

                    String sql = "SELECT MAX(User_ID) FROM Users;";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Connection = connection;

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                                next_ID = reader.GetInt32(0) + 1;
                        }
                    }

                    sql = "INSERT INTO Users VALUES(@UserID, @Username, @Password, @Admin);";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Connection = connection;


                        command.Parameters.AddWithValue("@UserID", next_ID);
                        command.Parameters.AddWithValue("@Username", user.Username);
                        command.Parameters.AddWithValue("@Password", user.Password);
                        command.Parameters.AddWithValue("@Admin", 0);

                        command.ExecuteNonQuery();
                    }
                    connection.Close();
                }
                return RedirectToAction(nameof(Index));
            }
            return View(user);
        }
    }
}
