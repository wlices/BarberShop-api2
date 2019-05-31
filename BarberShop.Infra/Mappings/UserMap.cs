using BarberShopAPI.Infra.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberShopAPI.Infra.Mappings
{
    public class UserMap : EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            HasKey(x => x.Id);
            Property(x => x.Name);
            Property(x => x.Email);
            Property(x => x.Password);
        }
    }
}
