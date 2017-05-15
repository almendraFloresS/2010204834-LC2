using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using EmpresaTransporte.Entities;
namespace EmpresaTransporte.Persistance.EntityConfiguration
{
    public class ClienteConfiguration : EntityTypeConfiguration<Cliente>
    {

        public ClienteConfiguration()
        {
            ToTable("Cliente");
            HasKey(p => p.idCliente);
            Property(p => p.NombreCliente).IsRequired();

        }
    }
}
