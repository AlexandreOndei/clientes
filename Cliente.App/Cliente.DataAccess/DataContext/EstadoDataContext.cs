using Cliente.DataAccess.Entity;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente.DataAccess.DataContext
{
    public class EstadoDataContext : BaseDataContext
    {
        public EstadoDataContext() : base()
        {   
        }

        public IList<Estado> SelectEstados()
        {
            return Connection.Query<Estado>("SELECT * FROM ESTADO").ToList();
        }
    }
}
