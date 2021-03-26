using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Inlamning1ASP.Models;
using Microsoft.EntityFrameworkCore;

namespace Inlamning1ASP.Data
{
    public class EventsDbContext : DbContext
    {
        public EventsDbContext(DbContextOptions<EventsDbContext> options)
            : base(options)
        {
            
        }
        public DbSet<AttendeeEvent> AttendeeEvents { get; set; }
        public DbSet<Organizer> Organizers { get; set; }
        public DbSet<Attendee> Attendees { get; set; }
        public DbSet<Event> Events { get; set; }

        
    }
}
