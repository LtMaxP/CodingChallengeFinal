using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class Rectangulo : FormasG
    {
        public override decimal area { get; set; }
        public override decimal perimetro { get; set; }

        public Rectangulo(decimal _lado1, decimal _lado2)
        {
            CalcularArea(_lado1, _lado2);
            CalcularPerimetro(_lado1, _lado2);
        }

        void CalcularArea(decimal _lado1, decimal _lado2)
        {

            area = _lado1 * _lado2;
        }

        void CalcularPerimetro(decimal _lado1, decimal _lado2)
        {
            perimetro = (_lado1 * 2) + (_lado2 * 2);
        }
    }
}
