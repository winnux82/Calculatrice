using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculatrice
{
    class ExceptionCalcul : Exception
    {
        public ExceptionCalcul() { }

        public ExceptionCalcul(string message) : base(string.Format($"Calcul invalide !\n {message}")) 
            {
        }
    }
}
