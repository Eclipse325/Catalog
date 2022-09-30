using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BookCatalog.Model
{
    public partial class CatalogModel
    {
        public BookDbContext dbContext;

        private ServiceProvider serviceProvider;

        public CatalogModel(BookDbContext dbcontext)
        {
            dbContext = dbcontext;
        }

        public List<Book> GetBooks()
        {
            return dbContext.Books.ToList();
        }

        public void Add(Book book)
        {
            dbContext.Add(book);
            dbContext.SaveChanges();
        }

        public void Delete(Book book)
        {
            try
            {
                dbContext.Remove(book);
                dbContext.SaveChanges();
            }
            catch (Exception ex) { }
            
        }

        public void Update(Book book)
        {
            try
            {
                if (book.Name != null)
                    try
                    {
                        dbContext.Update(book);
                        dbContext.SaveChanges();
                    }
                    catch (Exception ex) { }
            }
            catch (NullReferenceException ex) { }
        }
    }
}
