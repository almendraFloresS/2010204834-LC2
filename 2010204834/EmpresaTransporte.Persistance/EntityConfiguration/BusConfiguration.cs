using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using EmpresaTransporte.Entities;

namespace EmpresaTransporte.Persistance.EntityConfiguration
{
    public class BusConfiguration : EntityTypeConfiguration<Bus>
    {

        public BusConfiguration()
        {
            ToTable("Bus");
            HasKey(p => p.idBus);
            Property(p => p.placa).IsRequired();

        }

            
    }
}
