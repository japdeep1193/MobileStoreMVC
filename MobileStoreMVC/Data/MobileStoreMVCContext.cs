using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MobileStoreMVC.Models;

namespace MobileStoreMVC.Data
{
    public class MobileStoreMVCContext : DbContext
    {
        public MobileStoreMVCContext (DbContextOptions<MobileStoreMVCContext> options)
            : base(options)
        {
        }

        public DbSet<MobileStoreMVC.Models.Mobile> Mobile { get; set; }

        public DbSet<MobileStoreMVC.Models.Stock> Stock { get; set; }

        public DbSet<MobileStoreMVC.Models.Sale> Sale { get; set; }
    }
}
