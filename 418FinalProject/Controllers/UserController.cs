using System.Collections.Generic;
using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using _418FinalProject.Models;
using System.Data.SqlClient;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace _418FinalProject.Controllers
{
    public class UserController : Controller
    {
        private readonly DataBankContext _context;

        public UserController(DataBankContext context)
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

            List<User> users = new List<User>();

            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {
                connection.Open();
                String sql = "SELECT * FROM Users;";



                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                            users.Add
                            (
                                new User
                                {
                                    UserID = reader.GetInt32(0),
                                    Username = reader.GetString(1),
                                    Password = reader.GetString(2),
                                    Type = reader.GetBoolean(3)
                                }
                            );
                    }
                    connection.Close();
                }
            }
            return View(users);
        }

        // GET: Movies/Details/{string}
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound(string.Format("Name is null"));

            var usr = await _context.Users
                .FirstOrDefaultAsync(u => u.UserID == id);

            if (usr == null) return NotFound(string.Format("User is not in Database"));

            return View(usr);
        }

        //Page 
        //GET: /admin/AddUser
        public IActionResult AddUser()
        {
            return View(new User());
        }

        //POST: /admin/AddUser/
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

                    String  sql = "SELECT MAX(User_ID) FROM Users;";

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
                        command.Parameters.AddWithValue("@Admin", user.Type);

                        command.ExecuteNonQuery();
                    }
                    connection.Close();
                }
                return RedirectToAction(nameof(Index));
            }
            return View(user);
        }
        //GET: /User/EditUser/{id?}
        public async Task<IActionResult> EditUser(int? id)
        {

            if (id == null) return NotFound();

            var user = await _context.Users.FindAsync(id);

            if (user == null) return NotFound();

            return View(user);
        }

        //POST: /User/EditUser/{id?}
        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> EditUser(int id, [Bind("UserID,Username,Password,Type")] User user)
        {

            if (id != user.UserID)
            {

                var msg = string.Format("ID {0} is null", id);

                return NotFound(msg);

            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(user);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    var temp = await _context.Users.FindAsync(id);

                    if (temp == null) { return NotFound(); }

                }
                RedirectToAction(nameof(Index));
            }

            return View(user);
        }

        //GET: /admin/DeleteQuestion/{id?}
        public async Task<IActionResult> DeleteUser(int? id)
        {
            if (id == null) return NotFound();

            var user = await _context.Users.FirstOrDefaultAsync(
            u => u.UserID == id);

            if (user == null) return NotFound();

            return View(user);
        }

        //POST: /admin/DeleteQuestion/{id}
        [HttpPost, ActionName("DeleteUser")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteUserConfirmed(int id)
        {

            var user = await _context.Users.FindAsync(id);

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));

        }
    }
}
