using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaTransporte.Entities.Repository
{
    public interface IRepoVenta
    {
        IEnumerable<Venta> getVentaporServicio(Servicio Servicio);
        IEnumerable<Venta> getVentaporCliente(Cliente Cliente);
        IEnumerable<Venta> getVentaporEmpleado(Empleado Empleado);
    }
}
