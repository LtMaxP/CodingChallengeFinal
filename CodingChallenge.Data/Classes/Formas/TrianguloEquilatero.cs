using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class TrianguloEquilatero : FormasG
    {
        public override decimal area { get; set; }
        public override decimal perimetro { get; set; }

        public TrianguloEquilatero(decimal _lado)
        {
            CalcularArea(_lado);
            CalcularPerimetro(_lado);
        }

        public void CalcularArea(decimal _lado)
        {
            area = ((decimal)Math.Sqrt(3) / 4) * _lado * _lado;
        }

        public void CalcularPerimetro(decimal _lado)
        {
            perimetro = _lado * 3;
        }
    }
}
