using AutoMapper;
using Cliente.Business.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente.Business
{
    public class EstadoBusiness
    {
        public IList<DTO.Clientes.Estado> GetEstados()
        {
            using (var dc = new DataAccess.DataContext.EstadoDataContext())
            {
                return Mappings.Mappers.Map<IList<DataAccess.Entity.Estado>, IList<DTO.Clientes.Estado>>(dc.SelectEstados());
            }
        }
    }
}
