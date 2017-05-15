using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaTransporte.Entities.Repository
{
    public interface IRepoEmpleado
    {
        IEnumerable<Empleado> getEmpleadoporVenta(Venta Venta);
        IEnumerable<Empleado> getEmpleadoporBus(Bus Bus);
    }
}
