using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using EmpresaTransporte.Entities;

namespace EmpresaTransporte.Persistance
{
    public class EmpleadoConfiguration : EntityTypeConfiguration<Empleado>
    {

        public EmpleadoConfiguration()
        {
            ToTable("Empleado");
            HasKey(p => p.idEmpleado);
            Property(p => p.NombreEmpleado).IsRequired();

            Map<Administrativo>(m => m.Requires("Discriminator").HasValue("Administrativo"));
            Map<Tripulacion>(m => m.Requires("Discriminator").HasValue("Tripulacion"));
        }
    }
}
