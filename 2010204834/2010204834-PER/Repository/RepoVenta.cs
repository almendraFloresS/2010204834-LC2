using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2010204834_ENT.Entities;
using _2010204834_ENT.IRepository;

namespace _2010204834_PER.Repository
{
    public class RepoVenta : Repository<Venta>, IRepoVenta
    {
        public RepoVenta(EmpresaTransporteDBContext context)
            : base(context)
        {
        }

    }
}
