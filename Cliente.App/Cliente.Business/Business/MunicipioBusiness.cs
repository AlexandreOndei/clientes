using Cliente.Business.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente.Business
{
    public class MunicipioBusiness
    {
        public void AdicionarMunicipio(DTO.Clientes.Municipio municipio)
        {
            using (var db = new DataAccess.DataContext.MunicipioDataContext())
            {
                db.InserirMunicipio(Mappings.Mappers.Map<DTO.Clientes.Municipio, DataAccess.Entity.Municipio>(municipio));
            }
        }

        public IList<DTO.Clientes.Municipio> GetMunicipios(string uf)
        {
            using (var db = new DataAccess.DataContext.MunicipioDataContext())
            {
                return Mappings.Mappers.Map<IList<DataAccess.Entity.Municipio>, IList<DTO.Clientes.Municipio>>(db.SelectMunicipios(uf));
            }
        }
    }
}
