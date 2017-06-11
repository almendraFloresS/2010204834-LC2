using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2010204834_ENT.Entities
{
    public class Venta
    {
        public int idVenta { set; get; }

        public String fecha_registro { set; get; }

        public TipoComprobante tipocomprobante { set; get; }

        public TipoPago tipopago { set; get; }


        public Servicio servicio { set; get; }
        public int idServicio { set; get; }

        public double monto { set; get; }

        //public Empleado Empleado { set; get; }
        //public int idEmpleado { set; get; }

        public Cliente cliente { set; get; }
        public int idCliente { set; get; }




    }
}
