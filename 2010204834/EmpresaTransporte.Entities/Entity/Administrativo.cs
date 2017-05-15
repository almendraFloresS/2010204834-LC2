using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaTransporte.Entities
{
    public class Administrativo : Empleado
    {


        public ICollection<Venta> Listaventas { set; get; }

       

    }
}
