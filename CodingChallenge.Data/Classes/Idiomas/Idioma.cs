using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public abstract class Idioma
    {
        public const int Castellano = 1;
        public const int Ingles = 2;

        Dictionary<String, String> mapa = new Dictionary<String, String>();
        public abstract String traducir(string leyenda);
    }
}
