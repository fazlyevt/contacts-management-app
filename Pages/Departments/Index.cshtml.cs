using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ContactsManagementApp.Data;
using ContactsManagementApp.Models;

namespace ContactsManagementApp.Pages.Departments
{
    public class IndexModel : PageModel
    {
        private readonly ContactsManagementApp.Data.DatabaseContext _context;

        public IndexModel(ContactsManagementApp.Data.DatabaseContext context)
        {
            _context = context;
        }

        public IList<Department> Department { get;set; }

        public async Task OnGetAsync()
        {
            Department = await _context.Department.ToListAsync();
        }
    }
}
