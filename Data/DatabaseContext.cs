using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ContactsManagementApp.Models;

namespace ContactsManagementApp.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext (DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }

        public DbSet<Position> Position { get; set; }

        public DbSet<Client> Client { get; set; }

        public DbSet<Contact> Contact { get; set; }
    }
}
