using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using eCapitalAssignment.Models;

namespace eCapitalAssignment.Data
{
    public class eCapitalContext : DbContext
    {
        public eCapitalContext (DbContextOptions<eCapitalContext> options)
            : base(options)
        {
        }

        public DbSet<Employee> Employee { get; set; } = default!;
    }
}
