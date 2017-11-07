using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Accounting.Models
{
    public class GeneralJournalContext : DbContext
    {
        public GeneralJournalContext (DbContextOptions<GeneralJournalContext> options)
            : base(options)
        {
        }

        public DbSet<Accounting.Models.GeneralJournal> GeneralJournal { get; set; }
    }
}
