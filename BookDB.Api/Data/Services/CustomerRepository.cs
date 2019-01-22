using System.Collections.Generic;
using BookDB.Api.Entites;
using Microsoft.EntityFrameworkCore;

namespace BookDB.Services
{
    public class CustomerRepository : ICustomerRepository
    {
        readonly BookDbContext _context;

        public CustomerRepository(BookDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Customer> GetCustomers()
        {
            return _context.Customers.Include(c => c.Group);
        }
    }
}