using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2010204834_ENT.IRepository;
using _2010204834_ENT.Entities;

namespace _2010204834_PER.Repository
{
    public class UnityofWork : IUnityofWork
    {

        private readonly EmpresaTransporteDBContext _Context;
        private static UnityofWork _Instance;
        private static readonly object _Lock = new object();



        public IRepoBus Bus { get; set; }
        public IRepoCliente Cliente { get; set; }
        public IRepoEmpleado Empleado { get; set; }
        public IRepoLugarViaje LugarViaje { get; set; }
        public IRepoServicio Servicio { get; set; }
        public IRepoVenta Venta { get; set; }



        public UnityofWork()
        {
            _Context = new EmpresaTransporteDBContext();

            Bus = new RepoBus(_Context);
            Cliente = new RepoCliente(_Context);
            Empleado = new RepoEmpleado(_Context);
            LugarViaje = new RepoLugarViaje(_Context);
            Servicio = new RepoServicio(_Context);
            Venta = new RepoVenta(_Context);
        }

        public static UnityofWork Instance
        {
            get
            {
                lock (_Lock)
                {
                    if (_Instance == null)
                        _Instance = new UnityofWork();
                }
                return _Instance;
            }
        }



        //public UnityOfWork(DBContext context)
        //{
        //    //Se crea un unico contexto de base de datos
        //    //para apuntar todos los repositorios a la misma base de datos
        //    _Context = context;

        //    Almacen = new AlmacenRepository(_Context);
        //    Area = new AreaRepository(_Context);
        //    Empleado = new EmpleadoRepository(_Context);
        //    Incidencia = new IncidenciaRepository(_Context);
        //    OrdenCompra = new OrdenCompraRepository(_Context);
        //    Producto = new ProductoRepository(_Context);
        //    Proveedor = new ProveedorRepository(_Context);
        //    Solucion = new SolucionRepository(_Context);
        //    Usuario = new UsuarioRepository(_Context);


        //}
        public void Dispose()
        {
            _Context.Dispose();
        }

        public int SaveChanges()
        {
            return _Context.SaveChanges();
        }

        public void StateModified(object Entity)
        {
            _Context.Entry(Entity).State = System.Data.Entity.EntityState.Modified;
        }

    }
}
