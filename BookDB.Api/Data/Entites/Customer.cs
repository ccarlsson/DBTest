using System;

namespace BookDB.Api.Entites
{
    public class Customer
    {
        public Guid CustomerId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public Guid GroupId { get; set; }
        public Group Group { get; set; }
    }
}