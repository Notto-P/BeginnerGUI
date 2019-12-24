using System;
using System.Collections.Generic;

namespace WebAppBook.Models.db
{
    public partial class Products
    {
        public int IdProducts { get; set; }
        public string ProductsName { get; set; }
        public string Image { get; set; }
        public int? Price { get; set; }
        public int? Unit { get; set; }
    }
}
