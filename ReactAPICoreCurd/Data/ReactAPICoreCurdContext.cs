using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ReactAPICoreCurd.Model;

namespace ReactAPICoreCurd.Data
{
    public class ReactAPICoreCurdContext : DbContext
    {
        public ReactAPICoreCurdContext (DbContextOptions<ReactAPICoreCurdContext> options)
            : base(options)
        {
        }

        public DbSet<ReactAPICoreCurd.Model.customerDetails> customerDetails { get; set; } = default!;
    }
}
