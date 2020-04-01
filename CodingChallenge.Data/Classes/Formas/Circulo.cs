using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class Circulo : FormasG
    {
        public override decimal area { get; set; }
        public override decimal perimetro { get; set; }

        public Circulo(decimal _lado)
        {
            CalcularArea(_lado);
            CalcularPerimetro(_lado);
        }

        public void CalcularArea(decimal _lado)
        {

            area = (decimal)Math.PI * (_lado / 2) * (_lado / 2);
        }

        public void CalcularPerimetro(decimal _lado)
        {
            perimetro = (decimal)Math.PI * _lado;
        }
    }
}
