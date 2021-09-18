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
    public class IndexModel : PageModel
    {
        private readonly ContactsManagementApp.Data.DatabaseContext _context;

        public IndexModel(ContactsManagementApp.Data.DatabaseContext context)
        {
            _context = context;
        }

        public IList<Contact> Contact { get;set; }

        public async Task OnGetAsync()
        {
            Contact = await _context.Contact
                .Include(c => c.Client)
                .Include(c => c.Department)
                .Include(c => c.Position).ToListAsync();
        }
    }
}
