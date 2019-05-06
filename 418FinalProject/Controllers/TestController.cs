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

        // GET: Test_Titles
        public IActionResult Index()
        {
            return View();
        }

    }
}