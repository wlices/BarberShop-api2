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
        public string Professional { get; set; }
        public DateTime InitialDate { get; set; }
        public DateTime EndTime { get; set; }
        public Service Service { get; set; }
        public Customer Customer { get; set; }
    }
}
