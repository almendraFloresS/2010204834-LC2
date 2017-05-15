using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaTransporte.Entities
{
    public abstract class Empleado
    {
        public int idEmpleado { get; set; }
        public string NombreEmpleado { get; set; }
    }
}
