using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2010204834_ENT.Entities;
using _2010204834_ENT.IRepository;

namespace _2010204834_PER{

    public class EmpresaTransporteDBContext : DbContext
    {

        public DbSet<Bus> Bus { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Empleado> Empleado { get; set; }
        public DbSet<Administrativo> Administrativo { get; set; }
        public DbSet<Tripulacion> Tripulacion { get; set; }
        public DbSet<LugarViaje> LugarViaje { get; set; }
        public DbSet<Servicio> Servicio { get; set; }
        public DbSet<Transporte> Transporte { get; set; }
        public DbSet<Encomienda> Encomienda { get; set; }
        public DbSet<Venta> Venta { get; set; }

        public EmpresaTransporteDBContext()
            : base("EmpresaTransporte")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Configurations.Add(new BusConfiguration());
            //modelBuilder.Configurations.Add(new ClienteConfiguration());
            //modelBuilder.Configurations.Add(new EmpleadoConfiguration());
            //modelBuilder.Configurations.Add(new LugarViajeConfiguration());
            //modelBuilder.Configurations.Add(new ServicioConfiguration());
            //modelBuilder.Configurations.Add(new VentaConfiguration());


            modelBuilder.Entity<Bus>().ToTable("Bus");
            modelBuilder.Entity<Bus>().HasKey(p => p.idBus);
            modelBuilder.Entity<Bus>().Property(p => p.placa).IsRequired();

            modelBuilder.Entity<Servicio>().ToTable("Servicio");
            modelBuilder.Entity<Servicio>().HasKey(p => p.idServicio);
            modelBuilder.Entity<Servicio>().Property(p => p.NombreServicio).IsRequired();
            modelBuilder.Entity<Servicio>().Map<Transporte>(m => m.Requires("Discriminator").HasValue("Transporte"));
            modelBuilder.Entity<Servicio>().Map<Encomienda>(m => m.Requires("Discriminator").HasValue("Encomienda"));



            modelBuilder.Entity<Cliente>().ToTable("Cliente");
            modelBuilder.Entity<Cliente>().HasKey(p => p.idCliente);
            modelBuilder.Entity<Cliente>().Property(p => p.NombreCliente).IsRequired();

            modelBuilder.Entity<Empleado>().ToTable("Empleado");
            modelBuilder.Entity<Empleado>().HasKey(p => p.idEmpleado);
            modelBuilder.Entity<Empleado>().Property(p => p.NombreEmpleado).IsRequired();
            modelBuilder.Entity<Empleado>().Map<Administrativo>(m => m.Requires("Discriminator").HasValue("Administrativo"));
            modelBuilder.Entity<Empleado>().Map<Tripulacion>(m => m.Requires("Discriminator").HasValue("Tripulacion"));


            modelBuilder.Entity<LugarViaje>().ToTable("LugarViaje");
            modelBuilder.Entity<LugarViaje>().HasKey(p => p.idLugarViaje);
            modelBuilder.Entity<LugarViaje>().Property(p => p.nombre).IsRequired();


            modelBuilder.Entity<Venta>().ToTable("Venta");
            modelBuilder.Entity<Venta>().HasKey(p => p.idVenta);
            modelBuilder.Entity<Venta>().HasRequired(p => p.servicio).WithMany(c => c.Listaventas).HasForeignKey(c => c.idServicio).WillCascadeOnDelete(false);
            modelBuilder.Entity<Venta>().HasRequired(p => p.cliente).WithMany(c => c.Listaventas).HasForeignKey(c => c.idCliente).WillCascadeOnDelete(false);
            //modelBuilder.Entity<Venta>().HasRequired(p => p.Empleado).WithMany(c => c.).HasForeignKey(c => c.idAdministrativo).WillCascadeOnDelete(false); 

            base.OnModelCreating(modelBuilder);
        }
    }
}
