using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using EmpresaTransporte.Entities;

namespace EmpresaTransporte.Persistance.EntityConfiguration
{
    public class ServicioConfiguration : EntityTypeConfiguration<Servicio>
    {

        public ServicioConfiguration()
		{
			//Table Configurations
			ToTable("Servicio");
			HasKey(p => p.idServicio);
			Property(p => p.NombreServicio).IsRequired();
            HasRequired(p => p.lugarviaje).WithMany(c => c.ListaServicios).HasForeignKey(c => c.idLugarViaje).WillCascadeOnDelete(false); ;

			Map<Encomienda>(m => m.Requires("Discriminator").HasValue("Encomienda"));
			Map<Transporte>(m => m.Requires("Discriminator").HasValue("Transporte"));
		}
    }
}
