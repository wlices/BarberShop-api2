using BarberShopAPI.Infra.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberShopAPI.Infra.Mappings
{
    public class SchedulingMap : EntityTypeConfiguration<Scheduling>
    {
        public SchedulingMap()
        {
            HasKey(x => x.Id);
            Property(x => x.Professional);
            Property(x => x.InitialDate);
            Property(x => x.EndTime);
            HasRequired(x => x.Customer);
            HasRequired(x => x.Service);
        }
    }
}
