using Cliente.Business.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente.Business
{
    public class CidadeBusiness
    {
        public void AdicionarCidade(DTO.Clientes.Cidade cidade)
        {
            using (var db = new DataAccess.DataContext.CidadeDataContext())
            {
                db.InserirCidade(Mappings.Mappers.Map<DTO.Clientes.Cidade, DataAccess.Entity.Cidade>(cidade));
            }
        }

        public IList<DTO.Clientes.Cidade> GetCidades(string uf)
        {
            using (var db = new DataAccess.DataContext.CidadeDataContext())
            {
                return Mappings.Mappers.Map<IList<DataAccess.Entity.Cidade>, IList<DTO.Clientes.Cidade>>(db.SelectCidades(uf));
            }
        }
    }
}
