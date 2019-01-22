using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookDB.Api.Entites;
using BookDB.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace BookDB.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerRepository _repository;

        public CustomersController(ICustomerRepository repository)
        {
            _repository = repository;
        }
        // GET api/customers
        [HttpGet]
        public ActionResult<IEnumerable<Customer>> Get()
        {
            var result = _repository.GetCustomers();
            return Ok(result);
        }

        //      [HttpGet("{isbn}")]
        //      public async Task<ActionResult<Book>> GetBook(string isbn)
        //      {
        //          var result = await _repository.GetBook(isbn);
        //          if (result != null)
        //          {
        //              return Ok(result);
        //          }
        //          return NotFound();
        //      }

        // GET api/books/{ISBN}/copies
        //        [Route("{isbn}/copies")]
        //        [HttpGet]
        //        public ActionResult<IEnumerable<BookCopy>> Get(string isbn)
        //        {
        //            var q = _repository.GetBookCopies().Where(c => c.BookId == isbn);
        //
        //            return Ok(q);
        //        }
        //
        // POST api/books
        //        [HttpPost]
        //        public async Task<ActionResult> Post([FromBody] Book book)
        //        {
        //            if (ModelState.IsValid)
        //            {
        //                try
        //                {
        //                    await _repository.AddBook(book);
        //                    await _repository.SaveChangesAsync();
        //                    return CreatedAtAction(nameof(GetBook), new { ISBN = book.ISBN }, book);
        //                }
        //                catch
        //                {
        //                    return BadRequest();
        //                }
        //            }
        //            return BadRequest();
        //        }
        //
        //        // PUT api/values/5
        //        [HttpPut("{id}")]
        //        public void Put(int id, [FromBody] string value)
        //        {
        //        }
        //
        //        // DELETE api/values/5
        //        [HttpDelete("{id}")]
        //        public void Delete(int id)
        //        {        }
        //        
    }
}
