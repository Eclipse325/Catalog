using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookCatalog.Model
{
    public class BookDbContext : DbContext
    {
        public BookDbContext(DbContextOptions<BookDbContext> options) : base(options)
        {
            //Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasData(GetBooks());
            base.OnModelCreating(modelBuilder);
        }

        private Book[] GetBooks()
        {
            return new Book[]
            {
                new Book { Id = 1, Name = "Book 1", Author = "No Name", Year = 1600, ISBN = "123123455", Picture = @"C:\testpic.jpg", Description = "Bestseller"},
                new Book { Id = 2, Name = "Book 2", Author = "Dostoevski", Year = 1854, ISBN = "512345123",  Picture = @"C:\testpic.jpg", Description = "Not The Best"},
                new Book { Id = 3, Name = "Book 3", Author = "Mr. Smith", Year = 2012, ISBN = "432456XFdd",  Picture = @"C:\testpic.jpg", Description = "Good One"},
                new Book { Id = 4, Name = "Book 4", Author = "Old Longfellow", Year = 2279, ISBN = "GS234123FR",  Picture = @"C:\testpic.jpg", Description = "Drop it"},
            };
        }
    }
}
