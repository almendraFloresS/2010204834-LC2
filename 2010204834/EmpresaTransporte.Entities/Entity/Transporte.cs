using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaTransporte.Entities
{
    public class Transporte : Servicio
    {
        public String OrigenTransporte { set; get; }
        public String DestinoTransporte { set; get; }
        public String fecha { set; get; }
        public double monto { set; get; }
//
      
        public TipoViaje tipoviaje { set; get; }
        
        public Bus bus { set; get; }
        public int idBus { set; get; }

        

        public Cliente cliente{set;get; }
        public int idCliente { set; get; }
        



        
    }
}
