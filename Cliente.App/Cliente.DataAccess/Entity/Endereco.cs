using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente.DataAccess.Entity
{
    public class Endereco
    {
        public int Tipo { get; set; }
        public string CEP { get; set; }
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public int Id_Cidade { get; set; }
        public int Id_Cliente { get; set; }
    }
}
