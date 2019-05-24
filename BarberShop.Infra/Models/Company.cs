using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberShopAPI.Infra.Models
{
    public class Company
    {
        public int Id { get; set; }
        public String RazaoSocial { get; set; }
        public String NomeFantasia { get; set; }
    }
}
