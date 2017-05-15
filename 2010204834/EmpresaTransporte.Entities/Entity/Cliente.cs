using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaTransporte.Entities
{
    public class Cliente
    {
        public int idCliente { set; get; }
        public String NombreCliente { set; get; }
        public String direccion { set; get; }
        public String telefono { set; get; }

        public ICollection<Venta> Listaventas { set; get; }
        public ICollection<Transporte> listaTransporte { set; get; }
       

    }
}
