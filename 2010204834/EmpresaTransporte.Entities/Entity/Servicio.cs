using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaTransporte.Entities
{
    public abstract class Servicio
    {
        public int idServicio { get; set; }
        public string NombreServicio { get; set; }

        public ICollection<Venta> Listaventas { set; get; }

        public LugarViaje lugarviaje { set; get; }
        public int idLugarViaje { set; get; }

    }
}
