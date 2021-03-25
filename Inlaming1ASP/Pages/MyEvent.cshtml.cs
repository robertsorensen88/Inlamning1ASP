using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Inlamning1ASP.Data;
using Inlamning1ASP.Models;

namespace Inlamning1ASP.Pages
{
    public class MyEventModel : PageModel
    {
        private readonly EventsDbContext _context;

        public MyEventModel(EventsDbContext context)
        {
            _context = context;
        }

        public IList<JoinEvent> JoinEvent { get;set; }

        public async Task OnGetAsync()
        {
            JoinEvent = await _context.JoinEvents
                .Include(r => r.Attendee)
                .Include(r => r.Event).ToListAsync();
        }
    }
}
