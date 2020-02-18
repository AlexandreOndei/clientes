using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente.DataAccess.DataContext
{
    public class MunicipioDataContext : BaseDataContext
    {
        public MunicipioDataContext() : base()
        {
        }

        public void InserirMunicipio(Entity.Municipio municipio)
        {
            Connection.Execute("INSERT INTO MUNICIPIO (NOME, SIGLA_ESTADO) VALUES(@NOME, @SIGLA_ESTADO)", municipio);
        }

        public IList<Entity.Municipio> SelectMunicipios(string uf)
        {
            return Connection.Query<Entity.Municipio>("SELECT * FROM MUNICIPIO WHERE SIGLA_ESTADO = @UF", uf).ToList();
        }
    }
}
