using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookListRazor.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookListRazor.Pages.BookList
{
    public class CreateModel : PageModel
    {

        private readonly ApplicationDbContext _db;

        public CreateModel(ApplicationDbContext db)
        {
            _db = db;
        }
        [BindProperty] //on post getting book on post handler
        public Book Book { get; set; }
        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPost() //handle to retreive data | Iactionresult redirect to main page
        {
            if(ModelState.IsValid)
            {
                await _db.Book.AddAsync(Book); //add data to queue
                await _db.SaveChangesAsync(); //push data to db
                return RedirectToPage("Index");
            }
            else
            {
                return Page();
            }
        }
    }
}
