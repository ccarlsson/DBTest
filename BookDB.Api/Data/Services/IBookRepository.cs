using System.Collections.Generic;
using System.Threading.Tasks;
using BookDB.Api.Entites;

namespace BookDB.Services
{
    public interface IBookRepository
    {
        IEnumerable<Book> GetBooks();
        IEnumerable<BookCopy> GetBookCopies();
        Task AddBook(Book book);
        Task<Book> GetBook(string isbn);
        Task<int> SaveChangesAsync();
    }
}