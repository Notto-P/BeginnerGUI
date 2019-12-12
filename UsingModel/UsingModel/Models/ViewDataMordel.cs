using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsingModel.Models
{
    public class ViewDataMordel
    {
        public IEnumerable<Customer> customers { get; set; }
        public IEnumerable<Product> products { get; set; }
    }
}
