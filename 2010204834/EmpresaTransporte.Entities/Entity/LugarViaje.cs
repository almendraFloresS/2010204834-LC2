using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaTransporte.Entities
{
    public class LugarViaje
    {
        public int idLugarViaje { set; get; }
        public String nombre { set; get; }
        public String direccion {set;get; }
        public TipoLugar tipolugar {set;get; }

        //public List<Transporte> listaTransporte { set; get; }
        //public List<Encomienda> listaEncomienda { set; get; }
        public ICollection<Servicio> ListaServicios { set; get; }
    }
}
