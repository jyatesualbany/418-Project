﻿using System.Collections.Generic;
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
    public class QuestionController : Controller
    {

        private readonly DataBankContext _context; //Database 

        public QuestionController(DataBankContext context)
        {
            _context = context; //Setting the database
        }

        //Home page
        // GET: /<controller>/
        public async Task<IActionResult> Index()
        {

            return View(await _context.Questions.ToListAsync());
        }

        //Page 
        //GET: /admin/AddQuestion
        public IActionResult AddQuestion()
        {
            return View();
        }

        //POST: /admin/AddQuestion/
        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> AddQuestion([Bind("QuestonID, QuestionText, Answer1Text, Answer2Text" +
                "Answer3Text, Answer4Text, Category, Image")]  Question question)
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
            if (questionNumber == null) { return NotFound(); }

            var question = await _context.Questions.FindAsync(questionNumber);

            if (question == null) { return NotFound(); }

            return View(question);
        }

        //POST: /admin/EditQuestion/{questionNumber}
        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> EditQuestion(int questionID,
            [Bind("QuestonID, QuestionText, Answer1Text, Answer2Text" +
                "Answer3Text, Answer4Text, Category, Image")] Question question)
        {

            if (questionID != question.QuestionID) { return NotFound(); }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(question);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    var temp = await _context.Questions.FindAsync(questionID);

                    if (temp == null) { return NotFound(); }

                }
                RedirectToAction(nameof(Index));
            }

            return View(question);
        }

        //GET: /admin/DeleteQuestion/questionNumber
        public async Task<IActionResult> DeleteQuestion(int? questionID)
        {
            if (questionID == null) { return NotFound(); }

            var question = await _context.Questions.FirstOrDefaultAsync(
            q => q.QuestionID == questionID);

            if (question == null) { return NotFound(); }

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