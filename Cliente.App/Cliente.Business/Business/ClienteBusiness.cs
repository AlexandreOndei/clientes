using Cliente.Business.Exceptions;
using Cliente.Business.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente.Business
{
    public class ClienteBusiness
    {
        private void ValidarCliente(DTO.Clientes.Cliente cliente)
        {
            DateTime dateTime;

            if (string.IsNullOrWhiteSpace(cliente.Nome))
                throw new ValidationException("Campo Nome não foi informado.");
            else if (string.IsNullOrWhiteSpace(cliente.CPF))
                throw new ValidationException("Campo CPF não foi informado.");
            else if (string.IsNullOrWhiteSpace(cliente.Data_Nascimento) || !DateTime.TryParse(string.Join("/", cliente.Data_Nascimento?.Split('/')?.Reverse()), out dateTime))
                throw new ValidationException("Campo Data de Nascimento não foi informado ou é inválido.");
            else if (string.IsNullOrWhiteSpace(cliente.Sexo))
                throw new ValidationException("Campo Sexo não foi informado.");
            else if (string.IsNullOrWhiteSpace(cliente.Logradouro))
                throw new ValidationException("Campo Endereço não foi informado.");
            else if (cliente.Numero == 0)
                throw new ValidationException("Campo Número não foi informado.");
            else if (string.IsNullOrWhiteSpace(cliente.Telefone) && string.IsNullOrWhiteSpace(cliente.Celular))
                throw new ValidationException("Campo Telefone/Celular não foi informado.");
        }

        public void SalvarCliente(DTO.Clientes.Cliente cliente)
        {
            using (var db = new DataAccess.DataContext.ClienteDataContext())
            {
                var mapped = Mappings.Mappers.Map<DTO.Clientes.Cliente, DataAccess.Entity.Cliente>(cliente);

                ValidarCliente(cliente);

                if (cliente.Id == 0)
                    db.InserirCliente(mapped);
                else
                    db.AlterarCliente(mapped);
            }
        }

        public void ExcluirCliente(int id)
        {
            using (var db = new DataAccess.DataContext.ClienteDataContext())
            {
                db.DeletarCliente(id);
            }
        }

        public DTO.Clientes.Cliente GetCliente(int id)
        {
            using (var db = new DataAccess.DataContext.ClienteDataContext())
            {
                return Mappings.Mappers.Map<DataAccess.Entity.Cliente, DTO.Clientes.Cliente>(db.SelectClienteById(id));
            }
        }

        public IList<DTO.Clientes.ClienteViewModel> GetClientes(string filtro)
        {
            using (var db = new DataAccess.DataContext.ClienteDataContext())
            {
                return db.SelectClientes(filtro);
            }
        }
    }
}
