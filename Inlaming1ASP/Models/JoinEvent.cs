using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inlamning1ASP.Models
{
    public class JoinEvent
    {
        
            public int JoinEventId { get; set; }
            public int AttendeeId { get; set; }
            public int EventId { get; set; }

            public Attendee Attendee { get; set; }
            public Event Event { get; set; }
        
    }
}
