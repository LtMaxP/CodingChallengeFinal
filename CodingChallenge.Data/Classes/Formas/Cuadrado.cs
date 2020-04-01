using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class Cuadrado : FormasG
    {
        public override decimal area { get; set; }
        public override decimal perimetro { get; set; }

        public Cuadrado(decimal _lado)
        {
            CalcularArea(_lado);
            CalcularPerimetro(_lado);
        }

        void CalcularArea(decimal _lado)
        {
            area = _lado * _lado;
        }

        void CalcularPerimetro(decimal _lado)
        {
            perimetro = _lado * 4;
        }
    }
}
