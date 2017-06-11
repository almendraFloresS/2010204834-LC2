namespace _2010204834_PER.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Empleado",
                c => new
                    {
                        idEmpleado = c.Int(nullable: false, identity: true),
                        NombreEmpleado = c.String(nullable: false),
                        fechaContratacion = c.String(),
                        tipotripulacion = c.Byte(),
                        licencia = c.String(),
                        fec_ingreso = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.idEmpleado);
            
            CreateTable(
                "dbo.Bus",
                c => new
                    {
                        idBus = c.Int(nullable: false, identity: true),
                        placa = c.String(nullable: false),
                        nroAsientos = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.idBus);
            
            CreateTable(
                "dbo.Cliente",
                c => new
                    {
                        idCliente = c.Int(nullable: false, identity: true),
                        DNI = c.String(),
                        NombreCliente = c.String(nullable: false),
                        direccion = c.String(),
                        telefono = c.String(),
                    })
                .PrimaryKey(t => t.idCliente);
            
            CreateTable(
                "dbo.Venta",
                c => new
                    {
                        idVenta = c.Int(nullable: false, identity: true),
                        fecha_registro = c.String(),
                        tipocomprobante = c.Byte(nullable: false),
                        tipopago = c.Byte(nullable: false),
                        idServicio = c.Int(nullable: false),
                        monto = c.Double(nullable: false),
                        idCliente = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.idVenta)
                .ForeignKey("dbo.Cliente", t => t.idCliente)
                .ForeignKey("dbo.Servicio", t => t.idServicio)
                .Index(t => t.idServicio)
                .Index(t => t.idCliente);
            
            CreateTable(
                "dbo.Servicio",
                c => new
                    {
                        idServicio = c.Int(nullable: false, identity: true),
                        NombreServicio = c.String(nullable: false),
                        idLugarViaje = c.Int(nullable: false),
                        OrigenEncomienda = c.String(),
                        DestinoEncomienda = c.String(),
                        montoEncomienda = c.Double(),
                        descripcion = c.String(),
                        OrigenTransporte = c.String(),
                        DestinoTransporte = c.String(),
                        fecha = c.String(),
                        montoTransporte = c.Double(),
                        tipoviaje = c.Byte(),
                        idBus = c.Int(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.idServicio)
                .ForeignKey("dbo.LugarViaje", t => t.idLugarViaje, cascadeDelete: true)
                .ForeignKey("dbo.Bus", t => t.idBus, cascadeDelete: true)
                .Index(t => t.idLugarViaje)
                .Index(t => t.idBus);
            
            CreateTable(
                "dbo.LugarViaje",
                c => new
                    {
                        idLugarViaje = c.Int(nullable: false, identity: true),
                        nombre = c.String(nullable: false),
                        direccion = c.String(),
                        tipolugar = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.idLugarViaje);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Venta", "idServicio", "dbo.Servicio");
            DropForeignKey("dbo.Servicio", "idBus", "dbo.Bus");
            DropForeignKey("dbo.Servicio", "idLugarViaje", "dbo.LugarViaje");
            DropForeignKey("dbo.Venta", "idCliente", "dbo.Cliente");
            DropIndex("dbo.Servicio", new[] { "idBus" });
            DropIndex("dbo.Servicio", new[] { "idLugarViaje" });
            DropIndex("dbo.Venta", new[] { "idCliente" });
            DropIndex("dbo.Venta", new[] { "idServicio" });
            DropTable("dbo.LugarViaje");
            DropTable("dbo.Servicio");
            DropTable("dbo.Venta");
            DropTable("dbo.Cliente");
            DropTable("dbo.Bus");
            DropTable("dbo.Empleado");
        }
    }
}
