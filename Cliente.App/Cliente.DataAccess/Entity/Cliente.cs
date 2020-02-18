using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente.DataAccess.Entity
{
    public class Cliente : Base
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string Data_Nascimento { get; set; }
        public char Sexo { get; set; }
        public List<Endereco> ListaEnderecos { get; set; }
    }
}
