using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaTransporte.Entities.Repository
{
    public interface IRepoServicio
    {
        IEnumerable<Servicio> getServicioporVenta(Venta Venta);
        IEnumerable<Servicio> getServicioporLugarViaje(LugarViaje LugarViaje);
        IEnumerable<Servicio> getServicioporCliente(Cliente Cliente);
        IEnumerable<Servicio> getServicioporBus(Bus Bus);
    }
}
