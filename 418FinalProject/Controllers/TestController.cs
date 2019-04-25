using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using _418FinalProject.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Text.Encodings.Web;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace _418FinalProject.Controllers
{
    public class TestController : Controller
    {
        private DataBankContext _context; //Database 

        //Constructor
        public TestController(DataBankContext context)
        {
            _context = context;
        }

        // GET: Movies
        public async Task<IActionResult> Index(string testcategory, int? testID)
        {
            IQueryable<string> categoryQuery = from m in _context.Test_Titles
                                               orderby m.Test_ID
                                               select m.Title;

            var category = from m in _context.Test_Titles
                           select m;

           
            var testCategoriesVM = new testTitlesModel
            {
                categories = new SelectList(await categoryQuery.Distinct().ToListAsync()),
                Tests = await category.ToListAsync()
            };

            return View(testCategoriesVM);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Userinput(testTitlesModel model)
        {
            Test_Titles test = await _context.Test_Titles.FirstOrDefaultAsync(
            category => (category.Title == model.Title));

            if (test == null)
            {
                return NotFound();
            }

            return Redirect("/testCategories/index");
        }


    }
}