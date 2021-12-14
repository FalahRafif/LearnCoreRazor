using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookListRazor.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BookListRazor.Pages.BookList
{
    public class IndexModel : PageModel
    {
        //add object dependency injection
        private readonly ApplicationDbContext _db;

        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }

        //list book
        public IEnumerable<Book> Books { get; set; }

        //using async then change to async Task
        //async : run multiple task until awaited
        public async Task OnGet() //action method
        {
            //asign book form db
            Books = await _db.Book.ToListAsync();
        }
    }
}
