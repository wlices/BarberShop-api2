using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BarberShopAPI.Infra.Models;

namespace BarberShopAPI.Infra.Context
{
    class BarberShopAPIContext : DbContext
    {
        public BarberShopAPIContext() : base(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BarberShopDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        {

        }

        public DbSet<Customer> Customers { get; set; }
    }

}
