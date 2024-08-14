using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ServiceOrderManager.Models;

namespace ServiceOrderManager.Data
{
    public class ServiceOrderManagerContext : DbContext
    {
        public ServiceOrderManagerContext (DbContextOptions<ServiceOrderManagerContext> options)
            : base(options)
        {
        }

        public DbSet<ServiceOrderManager.Models.Client> Client { get; set; }
    }
}
