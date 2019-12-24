using System;
using System.Collections.Generic;

namespace WebAppBook.Models.db
{
    public partial class Payments
    {
        public int IdPayments { get; set; }
        public int? IdCustomers { get; set; }
        public int? IdProducts { get; set; }
        public int? Totalprice { get; set; }
        public DateTime? DatePayments { get; set; }
    }
}
