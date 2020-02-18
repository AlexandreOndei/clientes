using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente.DataAccess.Entity
{
    public class Cidade : Base
    {
        public string Nome { get; set; }
        public string Sigla_Estado { get; set; }
    }
}
