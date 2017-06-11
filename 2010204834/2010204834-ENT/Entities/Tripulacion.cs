using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2010204834_ENT.Entities
{
    public class Tripulacion : Empleado
    {
        public TipoTripulacion tipotripulacion { set; get; }
        public String licencia { set; get; }
        public String fec_ingreso { set; get; }
    }
}
