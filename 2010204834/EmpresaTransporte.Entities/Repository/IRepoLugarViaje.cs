using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaTransporte.Entities.Repository
{
    public interface IRepoLugarViaje
    {
        IEnumerable<LugarViaje> getLugarViajeporServicio(Servicio Servicio);
        IEnumerable<LugarViaje> getLugarViajeporTransporte(Transporte Transporte);
        IEnumerable<LugarViaje> getLugarViajeporEncomienda(Encomienda Encomienda);
    }
}
