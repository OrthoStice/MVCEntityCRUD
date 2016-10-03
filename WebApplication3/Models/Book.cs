using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebApplication3.Models
{
    public class Book
    {
        public int BookID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }
    }

    public class BookContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
    }
}

//extra comments for commit