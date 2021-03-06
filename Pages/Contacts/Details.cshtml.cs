using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ContactsManagementApp.Data;
using ContactsManagementApp.Models;

namespace ContactsManagementApp.Pages.Contacts
{
    public class DetailsModel : PageModel
    {
        private readonly ContactsManagementApp.Data.DatabaseContext _context;

        public DetailsModel(ContactsManagementApp.Data.DatabaseContext context)
        {
            _context = context;
        }

        public Contact Contact { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Contact = await _context.Contact
                .Include(c => c.Client)
                .Include(c => c.Department)
                .Include(c => c.Position).FirstOrDefaultAsync(m => m.ContactId == id);

            if (Contact == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
