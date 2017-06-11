using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2010204834_ENT.Entities
{
    public class Transporte : Servicio
    {
        public String OrigenTransporte { set; get; }
        public String DestinoTransporte { set; get; }
        public String fecha { set; get; }
        public double montoTransporte { set; get; }
        //

        public TipoViaje tipoviaje { set; get; }

        public Bus bus { set; get; }
        public int idBus { set; get; }







    }
}
