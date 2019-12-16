using System;
using System.Collections.Generic;

namespace Webpayment.Models.db
{
    public partial class Payment
    {
        public int IdPay { get; set; }
        public int? IdProduct { get; set; }
        public int? IdCus { get; set; }
        public DateTime? PaymentDate { get; set; }
        public int? Totalprice { get; set; }
    }
}
