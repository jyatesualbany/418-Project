using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using _418FinalProject.Models;

namespace _418FinalProject.Controllers
{
    public class AdminController : Controller
    {
        public AdminController()
        {
 
        }

        //Home page
        // GET: /<controller>/
        public IActionResult Index()
        {

            return View();
        }

    }
}
