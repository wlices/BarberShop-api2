using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberShopAPI.Infra.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public ICollection<Scheduling> Schedulings { get; set; }
    }
}
