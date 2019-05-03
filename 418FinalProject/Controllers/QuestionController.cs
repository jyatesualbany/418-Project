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
    public class QuestionController : Controller
    {

        private readonly DataBankContext _context; //Database 

        public QuestionController(DataBankContext context)
        {
            _context = context; //Setting the database
        }

        //Home page
        // GET: /<controller>/
        public IActionResult Index()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "testtaker.database.windows.net";
            builder.UserID = "user";
            builder.Password = "Password1";
            builder.InitialCatalog = "TestTaker";

            List<Question> qs = new List<Question>();


            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {
                connection.Open();
                //String sql = "SELECT a.QUESTION_ID,b.CATEGORY_NAME,a.TRUE_FALSE,a.QUESTION_TEXT,a.ANS1,a.ANS2,a.ANS3,a.ANS4"
                //+ " FROM Questions a, Question_Categories b"
                //+ " LEFT JOIN Questions ON QUESTION_ID = b.CATEGORY_ID;";
                //int cat_id = 0;
                String sql = "SELECT Questions.QUESTION_ID,Question_Categories.CATEGORY_NAME, "
                + "Questions.TRUE_FALSE,Questions.QUESTION_TEXT,Questions.ANS1, "
                + "Questions.ANS2,Questions.ANS3,Questions.ANS4 "
                + "FROM Questions "
                + "JOIN Question_Categories ON Questions.CATEGORY_ID = Question_Categories.CATEGORY_ID; ";


                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                            qs.Add
                            (
                                new Question
                                {
                                    QuestionID = reader.GetInt32(0),
                                    //Category = Convert.ToString(reader.GetInt32(1)),
                                    Category = reader.GetString(1),
                                    TrueFalse = reader.GetBoolean(2),
                                    QuestionText = reader.GetString(3),
                                    Answer1Text = reader.GetString(4),
                                    Answer2Text = reader.GetString(5),
                                    Answer3Text = reader.GetString(6),
                                    Answer4Text = reader.GetString(7)
                                }
                            );
                    }
                    connection.Close();
                }
            }



            return View(qs);
        }

        //Page 
        //GET: /admin/AddQuestion
        public IActionResult AddQuestion()
        {
            return View(new Question());
        }

        //POST: /admin/AddQuestion/
        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult AddQuestion([Bind("QuestionID, QuestionText, Answer1Text, Answer2Text," +
                "Answer3Text, Answer4Text, Category, Image")]  Question question)
        {
            if (ModelState.IsValid)
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "testtaker.database.windows.net";
                builder.UserID = "user";
                builder.Password = "Password1";
                builder.InitialCatalog = "TestTaker";

                int cat_exists = 0;
                int next_ID = 0;

                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    connection.Open();

                    String sql = "SELECT CATEGORY_ID FROM Question_Categories WHERE CATEGORY_NAME = '"+question.Category
                        +"';";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Connection = connection;

                        cat_exists = Convert.ToInt32(command.ExecuteScalar());
                    }
                    connection.Close();

                    if (cat_exists <= 0)
                    {
                        connection.Open();

                        sql = "SELECT MAX(CATEGORY_ID) FROM Question_Categories;";

                        using (SqlCommand command = new SqlCommand(sql, connection))
                        {
                            command.Connection = connection;

                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                    next_ID = reader.GetInt32(0) + 1;
                            }
                        }
                        connection.Close();

                        sql = "INSERT INTO Question_Categories VALUES(@CATEGORY_ID,@CATEGORY_NAME);";

                        connection.Open();

                        using (SqlCommand command = new SqlCommand(sql, connection))
                        {
                            command.Connection = connection;
                            command.Parameters.AddWithValue("@CATEGORY_ID", next_ID);
                            command.Parameters.AddWithValue("@CATEGORY_NAME", question.Category);

                            command.ExecuteNonQuery();
                        }
                        connection.Close();
                    }
                    else
                    {
                        connection.Open();

                        sql = "SELECT CATEGORY_ID FROM Question_Categories WHERE CATEGORY_NAME = '" + question.Category
                            + "';";

                        using (SqlCommand command = new SqlCommand(sql, connection))
                        {
                            command.Connection = connection;

                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                    next_ID = reader.GetInt32(0);
                            }
                        }
                        connection.Close();
                    }

                    connection.Open();

                        sql = "INSERT INTO Questions VALUES(@QUESTION_ID,@CATEGORY_ID,@TRUE_FALSE,@QUESTION_TEXT,@ANS1," +
                        "@ANS2,@ANS3,@ANS4);";

                        using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Connection = connection;
                        

                        command.Parameters.AddWithValue("@QUESTION_ID", question.QuestionID);
                        //command.Parameters.AddWithValue("@CATEGORY_ID", 1);
                        command.Parameters.AddWithValue("@CATEGORY_ID", next_ID);
                        command.Parameters.AddWithValue("@TRUE_FALSE", false);
                        command.Parameters.AddWithValue("@QUESTION_TEXT", question.QuestionText);
                        command.Parameters.AddWithValue("@ANS1", question.Answer1Text);
                        command.Parameters.AddWithValue("@ANS2", question.Answer2Text);
                        command.Parameters.AddWithValue("@ANS3", question.Answer3Text);
                        command.Parameters.AddWithValue("@ANS4", question.Answer4Text);

                        int recordsAffected = command.ExecuteNonQuery();
                    }
                    connection.Close();
                }
                return RedirectToAction(nameof(Index));
            }

            return View(question);
        }

        //GET: /question/EditQuestion/{id?}
        public async Task<IActionResult> EditQuestion(int? id)
        {
           
            if (id == null) return NotFound();

            var question = await _context.Questions.FindAsync(id);

            if (question == null) return NotFound();

            return View(question);
        }

        //POST: /question/EditQuestion/{id?}
        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> EditQuestion(int id,
            [Bind("QuestionID, QuestionText, Answer1Text, Answer2Text," +
                "Answer3Text, Answer4Text, Category, Image")] Question question)
        {

            if (id != question.QuestionID) {

                var msg = string.Format("ID {0} {1} is null",id, question.QuestionID);

                 return NotFound(msg); 
                 
                 }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(question);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    var temp = await _context.Questions.FindAsync(id);

                    if (temp == null) { return NotFound(); }

                }
                RedirectToAction(nameof(Index));
            }

            return View(question);
        }

        //GET: /admin/DeleteQuestion/{id?}
        public async Task<IActionResult> DeleteQuestion(int? id)
        {
            if (id == null) return NotFound();

            var question = await _context.Questions.FirstOrDefaultAsync(
            q => q.QuestionID == id);

            if (question == null) return NotFound();

            return View(question);
        }

        //POST: /admin/DeleteQuestion/{id}
        [HttpPost, ActionName("DeleteQuestion")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteQuestionConfirmed(int id)
        {

            var question = await _context.Questions.FindAsync(id);

            _context.Questions.Remove(question);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));

        }
        // GET: Movies/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();

            var question = await _context.Questions
                .FirstOrDefaultAsync(q => q.QuestionID == id);

            if (question == null) return NotFound();

            return View(question);
        }

        [HttpPost]
        public async Task<IActionResult> UploadFile(List<IFormFile> files) 
        {

            long size = files.Sum(f => f.Length);

            var filePath = Path.GetTempFileName();

            foreach (var formFile in files)
            {
                if (formFile.Length > 0)
                {
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await formFile.CopyToAsync(stream);
                    }
                }
            }

            // process uploaded files
            // Don't rely on or trust the FileName property without validation.

            return Ok(new { count = files.Count, size, filePath });
        }

    }
}
