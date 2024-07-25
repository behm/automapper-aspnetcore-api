using System;

namespace AutoMapperDemo.Data.Entities
{
    public class CustomerEntity
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public DateTime CreateDate { get; set; }
        public int Version { get; set; }
    }
}
