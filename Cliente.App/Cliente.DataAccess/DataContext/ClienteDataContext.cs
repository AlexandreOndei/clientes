using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente.DataAccess.DataContext
{
    public class ClienteDataContext : BaseDataContext
    {
        public ClienteDataContext() : base()
        {
        }

        public void InserirCliente(Entity.Cliente cliente)
        {
            Connection.Execute(@"INSERT INTO CLIENTE (NOME, CPF, TELEFONE, CELULAR, DATA_NASCIMENTO, SEXO)
            VALUES(@NOME, @CPF, @TELEFONE, @CELULAR, @DATA_NASCIMENTO, @SEXO)", cliente);
        }

        public IList<Entity.Cliente> SelectClientes(string filtro)
        {
            return Connection.Query<Entity.Cliente>($"SELECT * FROM CLIENTE WHERE NOME LIKE '%{filtro}%' OR CPF LIKE '%{filtro}%'").ToList();
        }
    }
}
