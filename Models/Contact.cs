using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppProject.Models
{
    public class Contact
    {
        public int ContactId { get; set; }
        public string? EmailAddress { get; set; }
        public string? Title { get; set; }
        public string? Content { get; set; }
    }
}