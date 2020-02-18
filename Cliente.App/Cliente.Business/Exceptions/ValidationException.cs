using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente.Business.Exceptions
{
    [Serializable]
    public class ValidationException : Exception
    {
        public ValidationException(string mensagem) : base(string.Format("Falha na validação: {0}", mensagem))
        {
        }
    }
}
