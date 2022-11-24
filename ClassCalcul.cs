using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculatrice
{
    public class CalculPOO
    {
        public float Nb1 { get; set; }
        public float Nb2 { get; set; }

        public CalculPOO(float nb1, float nb2)
        {
            Nb1 = nb1;
            Nb2 = nb2;
        }
        public CalculPOO(string nb1, string nb2)
        {
            Nb1 = float.Parse(nb1);
            Nb2 = float.Parse(nb2);
        }

        public float Addition()
        { return Nb1 + Nb2;}
        public float Soustraction()
        { return Nb1 - Nb2;}
        public float Multiplication()
        { return Nb1 * Nb2;}
        public float Division()
        { float resultat =  Nb1 / Nb2;
          if(float.IsInfinity(resultat))
                throw new DivideByZeroException();
          return resultat;
        }



    }
}
