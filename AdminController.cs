using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using _418FinalProject.Models;

namespace _418FinalProject.Controllers
{
    public class AdminController : Controller
    {

        private readonly Models.QuesitonContext _context; //Database 

        public AdminController(Models.QuesitonContext context)
        {
            _context = context; //Setting the database
        }

        //Home page
        // GET: /<controller>/
        public async Task<IActionResult> Index()
        {

            return View( await _context.Questions.ToListAsync());
        }

        //Page 
        //GET: /admin/AddQuestion
        public IActionResult AddQuestion() 
        {
            return View();
        }

        //POST: /admin/AddQuestion/
        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> AddQuestion([Bind("QuestonNumber, QuestionText," +
        	" Answer1, Answer1Text, Answer2, Answer2Text, Answer3" +
                "Answer3Text, Answer4, Answer4Text, Category, Image")] Question question)
        {
            if (ModelState.IsValid) 
            {
                _context.Add(question);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(question);
        }

        //GET: /admin/EditQuestion/{questionNumber}
        public async Task<IActionResult> EditQuestion(int? questionNumber) 
        {
            if (questionNumber == null)  { return NotFound(); }

            var question = await _context.Questions.FindAsync(questionNumber);

            if(question == null) { return NotFound(); }

            return View(question);
        }

        //POST: /admin/EditQuestion/{questionNumber}
        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> EditQuestion(int questionNumber, 
            [Bind("QuestonNumber, QuestionText, Answer1, Answer1Text, Answer2, Answer2Text, Answer3" +
            	"Answer3Text, Answer4, Answer4Text, Category, Image")] Question question) 
        {

            if (questionNumber != question.QuestionNumber) { return NotFound();}

            if (ModelState.IsValid)
            {
                try 
                {
                    _context.Update(question);
                    await _context.SaveChangesAsync();
                }
                catch(DbUpdateConcurrencyException)
                {
                    var temp = await _context.Questions.FindAsync(questionNumber);
                   
                     if (temp == null){ return NotFound(); }

                    else { throw; }
                }
                RedirectToAction(nameof(Index));
            }

            return View(question);
        }

        //GET: /admin/DeleteQuestion/questionNumber
        public async Task<IActionResult> DeleteQuestion(int? questionNumber) 
        { 
            if(questionNumber == null) { return NotFound(); }

            var question = await _context.Questions.FirstOrDefaultAsync(
            q => q.QuestionNumber == questionNumber);

            if(question == null) { return NotFound(); }

            return View(question);
        }

        //POST: /admin/DeleteQuestion/
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteQuestionConfirmed(int questionNumber) 
        {
            var question = await _context.Questions.FindAsync(questionNumber);
            _context.Questions.Remove(question);
            await _context.SaveChangesAsync();

            return View(nameof(Index));
        
        }

    }
}
