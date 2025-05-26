using Microsoft.EntityFrameworkCore;
using SimpleBookCatalog.Application.Interfaces;
using SimpleBookCatalog.Domain.Entities;
using SimpleBookCatalog.Infrastructure.Context;

namespace SimpleBookCatalog.Infrastructure.Repo
{
    public class BookRepo: IBookRepo    
    {
        private readonly SimpleBookDbContext _context;
        public BookRepo(IDbContextFactory<SimpleBookDbContext> factory)
        {
            _context = factory.CreateDbContext();
        }

        public async Task AddAsync(Book book)
        {
            await _context.Books.AddAsync(book);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var book = await _context.Books.FirstOrDefaultAsync(b => b.Id == id);   
            if(book is not null)
            {
                _context.Books.Remove(book);
                await _context.SaveChangesAsync();
            }

        }

        public async Task<List<Book>> GetAllAsync()
        {
            var bookModel = await _context.Books.ToListAsync();

            return bookModel;
        }

        public async Task<Book?> GetByIdAsync(int id)
        {
            var book = await _context.Books.FirstOrDefaultAsync(book => book.Id == id);
            return book;
        }

        public async Task UpdateAsync(Book book)
        {
            var existingBook = await _context.Books.FirstOrDefaultAsync(b => b.Id == book.Id);
            if (existingBook == null)
            {
                throw new Exception("Buku tidak ditemukan.");
            }

            // Update properti yang diperbolehkan
            existingBook.Title = book.Title;
            existingBook.Author = book.Author;
            existingBook.PublicationDate = book.PublicationDate;
            existingBook.Category = book.Category;


            await _context.SaveChangesAsync();
        }
    }
}
