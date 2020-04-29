using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ibank.Models;

namespace Ibank.Data
{
    public class IbankContext : DbContext
    {
        public IbankContext (DbContextOptions<IbankContext> options)
            : base(options)
        {
        }

        public DbSet<Ibank.Models.User> User { get; set; }

        public DbSet<Ibank.Models.Transfer> Transfer { get; set; }

        public DbSet<Ibank.Models.Extract> Extract { get; set; }
    }
}
