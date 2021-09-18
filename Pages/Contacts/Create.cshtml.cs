using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ContactsManagementApp.Data;
using ContactsManagementApp.Models;

namespace ContactsManagementApp.Pages.Contacts
{
    public class CreateModel : PageModel
    {
        private readonly ContactsManagementApp.Data.DatabaseContext _context;

        public CreateModel(ContactsManagementApp.Data.DatabaseContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["ClientId"] = new SelectList(_context.Client, "ClientId", "Name");
        ViewData["Departmentid"] = new SelectList(_context.Department, "DepartmentId", "Name");
        ViewData["PositionId"] = new SelectList(_context.Position, "PositionId", "Name");
            return Page();
        }

        [BindProperty]
        public Contact Contact { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Contact.Add(Contact);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
