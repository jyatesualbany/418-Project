using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using _418FinalProject.Models;

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
        public async Task<IActionResult> UserLogin(LoginViewModel model)
        {
            var usr = await _context.Users.FirstOrDefaultAsync(
            u => (u.Username == model.Username) && (u.Password == model.Password));

            if (usr == null) { return NotFound(); }

            if (usr.Type == true) { return Redirect("/admin/index"); }

            return Redirect("/nonadmin/index");
        }
    }
}
