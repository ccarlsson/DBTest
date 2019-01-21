using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookDB.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace BookDB.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookRepository _repository;

        public BooksController(IBookRepository repository)
        {
            _repository = repository;
        }
        // GET api/books
        [HttpGet]
        public async Task<ActionResult<IEnumerable<object>>> Get()
        {
            var result = await _repository.GetAllBooksAsync();
            return Ok(result);
        }

        // GET api/books/{ISBN}/copies
        [Route("{isbn}/copies")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<object>>> Get(string isbn)
        {
            var q = from copy in await _repository.GetAllBookCopiesAsync()
                    where copy.BookId == isbn
                    select copy;

            return Ok(q.ToList());
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
