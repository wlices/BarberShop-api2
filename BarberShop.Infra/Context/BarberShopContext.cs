using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BarberShopAPI.Infra.Models;
using BarberShopAPI.Infra.Mappings;

namespace BarberShopAPI.Infra.Context
{
    public class BarberShopContext : DbContext
    {
        public BarberShopContext() : base(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BarberShopDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Scheduling> Schedulings { get; set; }
        public DbSet<Service> Services { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CustomerMap());
        }
    }

}
