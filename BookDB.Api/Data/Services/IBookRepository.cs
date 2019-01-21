using System.Collections.Generic;
using System.Threading.Tasks;
using BookDB.Api.Entites;

namespace BookDB.Services
{
    public interface IBookRepository
    {
        Task<IEnumerable<Book>> GetAllBooksAsync();
        Task<IEnumerable<BookCopy>> GetAllBookCopiesAsync();
    }
}