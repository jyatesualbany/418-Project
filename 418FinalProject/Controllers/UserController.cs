using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using _418FinalProject.Models;

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
        public async Task<IActionResult> Index() 
        {

            return View(await _context.Users.ToListAsync());
        }
    }
}
