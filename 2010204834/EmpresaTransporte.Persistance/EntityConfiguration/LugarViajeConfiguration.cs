using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using EmpresaTransporte.Entities;

namespace EmpresaTransporte.Persistance.EntityConfiguration
{
    public class LugarViajeConfiguration : EntityTypeConfiguration<LugarViaje>
    {

        public LugarViajeConfiguration()
        {
            ToTable("LugarViaje");
            HasKey(p => p.idLugarViaje);
            Property(p => p.nombre).IsRequired();
        }

    }
}
