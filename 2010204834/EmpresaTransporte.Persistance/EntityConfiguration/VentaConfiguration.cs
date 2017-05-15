using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using EmpresaTransporte.Entities;

namespace EmpresaTransporte.Persistance.EntityConfiguration
{
    public class VentaConfiguration : EntityTypeConfiguration<Venta>
    {
        public VentaConfiguration()
        {

            ToTable("Venta");
            HasKey(p => p.idVenta);

            HasRequired(p => p.servicio).WithMany(c => c.Listaventas).HasForeignKey(c => c.idServicio).WillCascadeOnDelete(false); ;
            HasRequired(p => p.cliente).WithMany(c => c.Listaventas).HasForeignKey(c => c.idCliente).WillCascadeOnDelete(false); ;
            HasRequired(p => p.administrativo).WithMany(c => c.Listaventas).HasForeignKey(c => c.idAdministrativo).WillCascadeOnDelete(false); ;
        }
    }
}
