using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Inlamning1ASP.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Organizer Organizer { get; set; }
        public string Description { get; set; }
        public string Place { get; set; }
        public string Address { get; set; }
        public DateTime Date { get; set; }

        [Display(Name = "Spots Available")]
        public int SpotsAvailable { get; set; }

        public List<Attendee> Attendees { get; set; }
    }
}
