using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente.DTO.Municipios
{
    public class Municipio
    {
        public string nome { get; set; }
        public MicroRegiao microrregiao { get; set; }
    }
}
