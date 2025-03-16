using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Domains
{
    public class PhoneContact
    {
        public required string Name { get; set; }
        public required string PhoneNumber { get; set; }
    }
}
