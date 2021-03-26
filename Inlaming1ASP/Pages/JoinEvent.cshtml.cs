using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Inlamning1ASP.Data;
using Inlamning1ASP.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;


namespace Inlamning1ASP.Pages
{
    public class JoinEventModel : PageModel
    {
        private readonly EventsDbContext _context;
        
        public JoinEventModel(EventsDbContext context)
        {
            _context = context;
        }

        public Event Event { get; set; }
        public List<Attendee> Attendee { get; set; }
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Event = await _context.Events
                .Include(e => e.Organizer)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (Event == null)
            {
                return NotFound();
            }
            return Page();
        }


        public async Task<IActionResult> OnPostAsync(int? id)
        {

            AttendeeEvent joinsEvent= new()
            {
                Attendee = await _context.Attendees.Where(a => a.Id == 1).FirstOrDefaultAsync(),
                Event = await _context.Events.Where(e => e.Id == id).FirstOrDefaultAsync()
            };

            _context.AttendeeEvents.Add(joinsEvent);

            _context.Events.Where(e => e.Id == id).First().SpotsAvailable--;

            await _context.SaveChangesAsync();

            return RedirectToPage("/JoinEventDetails", new { id } );
        }
    }
}
