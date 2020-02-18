using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente.DataAccess.DataContext
{
    public class CidadeDataContext : BaseDataContext
    {
        public CidadeDataContext() : base()
        {
        }

        public void InserirCidade(Entity.Cidade cidade)
        {
            Connection.Execute("INSERT INTO CIDADE (NOME, SIGLA_ESTADO) VALUES(@NOME, @SIGLA_ESTADO)", new
            {
                cidade.Nome,
                cidade.Sigla_Estado
            });
        }

        public IList<Entity.Cidade> SelectCidades(string uf)
        {
            return Connection.Query<Entity.Cidade>("SELECT * FROM CIDADE WHERE SIGLA_ESTADO = @UF", new { uf }).ToList();
        }
    }
}
