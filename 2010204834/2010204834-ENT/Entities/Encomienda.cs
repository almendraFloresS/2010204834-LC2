using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2010204834_ENT.Entities
{
   public class Encomienda : Servicio
    {

        public String OrigenEncomienda { set; get; }
        public String DestinoEncomienda { set; get; }
        public double montoEncomienda { set; get; }
        public String descripcion { set; get; }


        
       
    }
}
