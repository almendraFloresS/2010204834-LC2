using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaTransporte.Entities.Repository
{
    public interface IRepoBus
    {
        IEnumerable<Bus> getBusporServicio(Servicio Servicio);
        IEnumerable<Bus> getBusporTransporte(Transporte Transporte);
        IEnumerable<Bus> getBusporEncomienda(Encomienda Encomienda);
    }
}
