using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AgendaTelefonica.Models;

namespace AgendaTelefonica.Data
{
    public class AgendaTelefonicaDbContext : DbContext
    {
        public AgendaTelefonicaDbContext (DbContextOptions<AgendaTelefonicaDbContext> options)
            : base(options)
        {
        }

        public DbSet<AgendaTelefonica.Models.Agenda> Agenda { get; set; } = default!;
    }
}
