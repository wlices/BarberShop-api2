﻿using BarberShopAPI.Infra.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberShopAPI.Infra.Mappings
{
    public class CustomerMap : EntityTypeConfiguration<Customer>
    {
        public CustomerMap()
        {
            HasKey(x => x.Id);
            Property(x => x.Name);
            Property(x => x.LastName);
            Property(x => x.Cpf);
            Property(x => x.Email);
            Property(x => x.Phone);
        }
    }
}
