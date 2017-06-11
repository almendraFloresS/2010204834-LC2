using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _2010204834_ENT.IRepository
{
    public interface IUnityofWork : IDisposable
    {

        IRepoBus Bus { get; }
        IRepoCliente Cliente { get; }
        IRepoEmpleado Empleado { get; }
        IRepoLugarViaje LugarViaje { get; }
        IRepoServicio Servicio { get; }
        IRepoVenta Venta { get; }

        int SaveChanges();

        void StateModified(object entity);
    }
}
