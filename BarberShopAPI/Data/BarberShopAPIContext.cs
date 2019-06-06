using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BarberShopAPI.Infra.Models;

namespace BarberShopAPI.Models
{
    public class BarberShopAPIContext : DbContext
    {
        public BarberShopAPIContext (DbContextOptions<BarberShopAPIContext> options)
            : base(options)
        {
        }

        public DbSet<BarberShopAPI.Infra.Models.Scheduling> Scheduling { get; set; }

        public DbSet<BarberShopAPI.Infra.Models.Service> Service { get; set; }

        public DbSet<BarberShopAPI.Infra.Models.User> User { get; set; }
    }
}
