using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaTransporte.Entities
{
    public class Encomienda : Servicio
    {

        public String OrigenEncomienda { set; get; }
        public String DestinoEncomienda { set; get; }
        public double monto { set; get; }
        public String descripcion { set; get; }


        
       
    }
}
