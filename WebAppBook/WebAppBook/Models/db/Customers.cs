using System;
using System.Collections.Generic;

namespace WebAppBook.Models.db
{
    public partial class Customers
    {
        public int IdCustomers { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Tel { get; set; }
        public int? IdStatus { get; set; }
    }
}
