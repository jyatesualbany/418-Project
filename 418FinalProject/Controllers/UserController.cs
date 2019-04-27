using System.Collections.Generic;
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

        // GET: Movies/Details/{string}
        public async Task<IActionResult> Details(int? id )
        {
            if (id == null) return NotFound(string.Format("Name is null"));

            var usr = await _context.Users
                .FirstOrDefaultAsync(u => u.UserID == id);

            if (usr == null) return NotFound(string.Format("User is not in Database"));

            return View(usr);
        }

        //Page 
        //GET: /admin/AddQuestion
        public IActionResult AddUser()
        {
            return View(new User());
        }

        //POST: /admin/AddQuestion/
        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> AddUser([Bind("UserID,Username,Password,Type")] User user)
        {
            if (ModelState.IsValid)
            {
                _context.Add(user);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(user);
        }
        //GET: /question/EditQuestion/{id?}
        public async Task<IActionResult> EditUser(int? id)
        {

            if (id == null) return NotFound();

            var user = await _context.Users.FindAsync(id);

            if (user == null) return NotFound();

            return View(user);
        }

        //POST: /question/EditQuestion/{id?}
        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> EditUser(int id, [Bind("UserID,Username,Password,Type")] User user)
        {

            if (id != user.UserID)
            {

                var msg = string.Format("ID {0} is null",id);

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
