using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SMP.Models
{
    public class SMPContext : DbContext
    {
        public SMPContext (DbContextOptions<SMPContext> options)
            : base(options)
        {
        }

        public DbSet<Meeting> Meeting { get; set; }
    }
}
