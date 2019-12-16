using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;

namespace Webpayment.Models.db
{
    public partial class Product
    {
        public int IdProduct { get; set; }
        public string ProductName { get; set; }
        public string Image { get; set; }
        public int? Price { get; set; }
        public int? Unit { get; set; }
    }
}