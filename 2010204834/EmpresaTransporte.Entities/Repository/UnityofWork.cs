using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaTransporte.Entities.Repository
{
    interface IUnityofWork : IDisposable
    {

        Bus Bus { get; }
        Cliente Cliente { get; }
        Empleado Empleado { get; }
        LugarViaje LugarViaje { get; }
        Servicio Servicio { get; }
        Venta Venta { get; }

        int SaveChanges();

    }
}
