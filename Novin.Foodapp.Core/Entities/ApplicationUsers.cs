using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novin.Foodapp.Core.Entities
{
    public class ApplicationUsers 
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Fullname { get; set; }
        public string Type { get; set; }
        public string Email { get; set; }
    }
}
