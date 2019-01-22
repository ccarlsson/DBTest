using System.Collections.Generic;
using BookDB.Api.Entites;

namespace BookDB.Services
{
    public interface ICustomerRepository
    {
        IEnumerable<Customer> GetCustomers();
    }
}