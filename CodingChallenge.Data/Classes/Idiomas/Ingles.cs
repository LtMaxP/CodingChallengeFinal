using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class Ingles : Idioma
    {
        Dictionary<String, String> mapa = new Dictionary<String, String>();

        public override string traducir(string leyenda)
        {
            string texto = mapa[leyenda];
            return texto;
        }

        public Ingles()
        {
            cargarPalabras();
        }

        private void cargarPalabras()
        {
            mapa.Add("Cabecera", "<h1>Shapes report</h1>");
            mapa.Add("TOTAL", "TOTAL");
            mapa.Add("formas", "shapes");
            mapa.Add("Perimetro", "Perimeter");
            mapa.Add("Area", "Area");
            mapa.Add("listaVacia", "<h1>Empty list of shapes!</h1>");
            mapa.Add("Cuadrado", "Square");
            mapa.Add("Triangulo", "Triangle");
            mapa.Add("Circulo", "Circle");
            mapa.Add("Trapecio", "trapeze");
            mapa.Add("Rectangulo", "Rectangle");
            mapa.Add("Cuadrados", "Squares");
            mapa.Add("Triangulos", "Triangles");
            mapa.Add("Circulos", "Circles");
            mapa.Add("Trapecios", "Trapezoids");
            mapa.Add("Rectangulos", "Rectangles");
        }
    }
}
