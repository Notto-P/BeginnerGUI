using System;
using System.Collections.Generic;

namespace Webpayment.Models.db
{
    public partial class User
    {
        public int IdUser { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public DateTime? Dob { get; set; }
        public int? IdStatus { get; set; }
        public string Image { get; set; }
    }
}
