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
            Connection.Execute(
                @"INSERT INTO CLIENTE (NOME, CPF, TELEFONE, CELULAR, DATA_NASCIMENTO, SEXO, CEP, LOGRADOURO, NUMERO, COMPLEMENTO, BAIRRO, ID_CIDADE)
                  VALUES(@NOME, @CPF, @TELEFONE, @CELULAR, @DATA_NASCIMENTO, @SEXO, @CEP, @LOGRADOURO, @NUMERO, @COMPLEMENTO, @BAIRRO, @ID_CIDADE)",
                new
                {
                    cliente.Nome,
                    cliente.CPF,
                    cliente.Telefone,
                    cliente.Celular,
                    Data_Nascimento = Convert.ToDateTime(string.Join("/", cliente.Data_Nascimento.Split('/').Reverse())),
                    cliente.Sexo,
                    cliente.CEP,
                    cliente.Logradouro,
                    cliente.Numero,
                    cliente.Complemento,
                    cliente.Bairro,
                    cliente.Id_Cidade
                });
        }

        public void AlterarCliente(Entity.Cliente cliente)
        {
            Connection.Execute(
                @"UPDATE CLIENTE SET
                    NOME = @NOME,
                    CPF = @CPF,
                    TELEFONE = @TELEFONE,
                    CELULAR = @CELULAR,
                    DATA_NASCIMENTO = @DATA_NASCIMENTO,
                    SEXO = @SEXO,
                    CEP = @CEP,
                    LOGRADOURO = @LOGRADOURO,
                    NUMERO = @NUMERO,
                    COMPLEMENTO = @COMPLEMENTO,
                    BAIRRO = @BAIRRO,
                    ID_CIDADE = @ID_CIDADE
                 WHERE ID = @ID",
                new
                {
                    cliente.Nome,
                    cliente.CPF,
                    cliente.Telefone,
                    cliente.Celular,
                    Data_Nascimento = Convert.ToDateTime(string.Join("/", cliente.Data_Nascimento.Split('/').Reverse())),
                    cliente.Sexo,
                    cliente.CEP,
                    cliente.Logradouro,
                    cliente.Numero,
                    cliente.Complemento,
                    cliente.Bairro,
                    cliente.Id_Cidade,
                    cliente.Id
                });
        }

        public void DeletarCliente(int id)
        {
            Connection.Execute("DELETE FROM CLIENTE WHERE ID = @ID", new { id });
        }

        public Entity.Cliente SelectClienteById(int id)
        {
            return Connection.QueryFirstOrDefault<Entity.Cliente>("SELECT * FROM CLIENTE WHERE ID = @ID", new { id });
        }

        public IList<DTO.Clientes.ClienteViewModel> SelectClientes(string filtro)
        {
            return Connection.Query<DTO.Clientes.ClienteViewModel>(
                $@"SELECT
                        C.ID,
                        C.NOME,
                        C.CPF,
                        C.CELULAR,
                        CONCAT(C.LOGRADOURO, ', ', C.NUMERO, (CASE WHEN C.COMPLEMENTO IS NOT NULL AND LENGTH(C.COMPLEMENTO) > 0 THEN concat(' - ', C.COMPLEMENTO) ELSE '' END), ', ', CD.NOME, '/', CD.SIGLA_ESTADO) AS ENDERECO
                   FROM CLIENTE C
                   INNER JOIN CIDADE CD ON C.ID_CIDADE = CD.ID
                   {(!string.IsNullOrEmpty(filtro) ? $"WHERE C.NOME LIKE '%{filtro}%' OR C.CPF LIKE '%{filtro}%'" : "")}").ToList();
        }
    }
}
