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
    public class JoinEventDetailsModel : PageModel
    {
        private readonly Inlamning1ASP.Data.EventsDbContext _context;

        public JoinEventDetailsModel(Inlamning1ASP.Data.EventsDbContext context)
        {
            _context = context;
        }

        public Event Event { get; set; }
        public string message { get; set; }
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            message = "My Events";
            if (id == null)
            {
                return NotFound();
            }

            Event = await _context.Events.FirstOrDefaultAsync(m => m.Id == id);

            if (Event == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
