using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class Castellano : Idioma
    {
        Dictionary<String, String> mapa = new Dictionary<String, String>();

        public override string traducir(string leyenda)
        {
            string texto = mapa[leyenda];
            return texto;
        }

        public Castellano()
        {
            cargarPalabras();
        }
        private void cargarPalabras()
        {
            mapa.Add("Cabecera", "<h1>Reporte de Formas</h1>");
            mapa.Add("TOTAL", "TOTAL");
            mapa.Add("formas", "formas");
            mapa.Add("Perimetro", "Perimetro");
            mapa.Add("Area", "Area");
            mapa.Add("listaVacia", "<h1>Lista vacía de formas!</h1>");
            mapa.Add("Cuadrado", "Cuadrado");
            mapa.Add("Triangulo", "Triángulo");
            mapa.Add("Circulo", "Círculo");
            mapa.Add("Trapecio", "Trapecio");
            mapa.Add("Rectangulo", "Rectangulo");
            mapa.Add("Cuadrados", "Cuadrados");
            mapa.Add("Triangulos", "Triángulos");
            mapa.Add("Circulos", "Círculos");
            mapa.Add("Trapecios", "Trapecios");
            mapa.Add("Rectangulos", "Rectangulos");
        }
    }
}
