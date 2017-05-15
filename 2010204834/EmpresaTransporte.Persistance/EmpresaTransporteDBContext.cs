using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmpresaTransporte.Entities;
using EmpresaTransporte.Persistance.EntityConfiguration;

namespace EmpresaTransporte.Persistance
{
    public class EmpresaTransporteDBContext : DbContext
    {

         public DbSet<Bus> Bus { get; set; }
         public DbSet<Cliente> Cliente { get; set; }
         public DbSet<Empleado> Empleado { get; set; }
         public DbSet<LugarViaje> LugarViaje { get; set; }
         public DbSet<Servicio> Servicio { get; set; }
         public DbSet<Venta> Venta { get; set; }

         public EmpresaTransporteDBContext()
			:base("EmpresaTransporte")
		{

		}

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Configurations.Add(new BusConfiguration());
            modelBuilder.Configurations.Add(new ClienteConfiguration());
            modelBuilder.Configurations.Add(new EmpleadoConfiguration());
            modelBuilder.Configurations.Add(new LugarViajeConfiguration());
            modelBuilder.Configurations.Add(new ServicioConfiguration());
            modelBuilder.Configurations.Add(new VentaConfiguration());

			base.OnModelCreating(modelBuilder);
		}
    }
}
