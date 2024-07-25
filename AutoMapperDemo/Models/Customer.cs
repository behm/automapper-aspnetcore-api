using System;

namespace AutoMapperDemo.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public DateTime CreateDate { get; set; }
        public string Notes { get; set; }

        public string FullName 
        {
            get { return $"{FirstName} {LastName}"; }
        }
    }
}
