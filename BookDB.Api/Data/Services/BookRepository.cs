using System.Collections.Generic;
using System.Threading.Tasks;
using BookDB.Api.Entites;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace BookDB.Services
{
    public class BookRepository : IBookRepository
    {
        private readonly BookDbContext _context;

        public BookRepository(BookDbContext context) => _context = context;
        public IEnumerable<Book> GetBooks()
        {
            return _context.Books;
        }

        public IEnumerable<BookCopy> GetBookCopies()
        {
            return _context.BookCopies.Include(bc => bc.Book);
        }

        public async Task AddBook(Book book)
        {
            await _context.Books.AddAsync(book);
        }

        public async Task<int> SaveChangesAsync() =>
            await _context.SaveChangesAsync();

        public async Task<Book> GetBook(string isbn) =>
            await _context.Books.SingleOrDefaultAsync(b => b.ISBN == isbn);

    }
}