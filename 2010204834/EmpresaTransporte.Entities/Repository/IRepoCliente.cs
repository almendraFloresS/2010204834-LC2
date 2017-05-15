using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaTransporte.Entities.Repository
{
    public interface IRepoCliente
    {
        IEnumerable<Cliente> getCLienteporVenta(Venta Venta);
        IEnumerable<Cliente> getClienteporTransporte(Transporte Transporte);
    }
}
