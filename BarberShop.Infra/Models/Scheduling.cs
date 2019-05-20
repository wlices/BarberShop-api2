using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberShopAPI.Infra.Models
{
    public class Scheduling
    {
        public int Id { get; set; }
        public DateTime InitialDate { get; set; }
        public DateTime EndTime { get; set; }
        public ICollection<Service> Services { get; set; }
        public ICollection<Customer> Customers { get; set; }
    }
}
