using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BookListRazor.Model
{
    public class ApplicationDbContext : DbContext //inherit with EF DbContext
    {
        //add-migration -v generate script sql
        //update-database generate/update database
        //pass base > options
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        //entry
        public DbSet<Book> Book { get; set; }
    }
}
