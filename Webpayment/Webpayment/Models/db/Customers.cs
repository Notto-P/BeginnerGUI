using System;
using System.Collections.Generic;

namespace Webpayment.Models.db
{
    public partial class Customers
    {
        public int IdCus { get; set; }
        public string NameCus { get; set; }
        public string LastnameCus { get; set; }
        public string AddressCus { get; set; }
        public string TelCus { get; set; }
    }
}
