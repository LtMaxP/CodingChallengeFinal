using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class Trapecio : FormasG
    {
        public override decimal area { get; set; }
        public override decimal perimetro { get; set; }

        public Trapecio(decimal _lado1, decimal _lado2, decimal _laterales, decimal _h)
        {
            CalcularArea(_lado1, _lado2, _h);
            CalcularPerimetro(_lado1, _lado2, _laterales);
        }

        void CalcularArea(decimal _lado1, decimal _lado2, decimal _h)
        {
            area = ((_lado1 + _lado2) * _h) / 2;
        }

        void CalcularPerimetro(decimal _lado1, decimal _lado2, decimal _laterales)
        {
            perimetro = _lado1 + _lado2 + (_laterales * 2);
        }
    }
}
