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
        public async Task<IEnumerable<Book>> GetAllBooks()
        {
            return await _context.Books.ToListAsync();
        }

        public async Task<IEnumerable<BookCopy>> GetAllBookCopies()
        {
            return await _context.BookCopies.Include(bc => bc.Book).ToListAsync();
        }
    }
}