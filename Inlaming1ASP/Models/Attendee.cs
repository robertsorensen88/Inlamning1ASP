using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Inlamning1ASP.Models
{
    public class Attendee
    {

        public int Id { get; set; }

        public string Name {get; set;}
        public string Email { get; set; }

        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        public List <Event> Events { get; set; }
    }
}
