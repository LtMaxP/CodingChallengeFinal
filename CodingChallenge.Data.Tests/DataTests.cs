using System;
using System.Collections.Generic;
using CodingChallenge.Data.Classes;
using NUnit.Framework;

namespace CodingChallenge.Data.Tests
{
    [TestFixture]
    public class DataTests
    {
        [TestCase]
        public void TestResumenListaVacia()
        {
            Assert.AreEqual("<h1>Lista vacía de formas!</h1>",
                FormaGeometrica.Imprimir(new List<FormasG>(), new Castellano()));

        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnIngles()
        {
            Assert.AreEqual("<h1>Empty list of shapes!</h1>",
                FormaGeometrica.Imprimir(new List<FormasG>(), new Ingles()));
        }

        [TestCase]
        public void TestResumenListaConUnCuadrado()
        {
            var cuadrados = new List<FormasG> { new Cuadrado(5) };

            var resumen = FormaGeometrica.Imprimir(cuadrados, new Castellano());

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Cuadrado | Area 25 | Perimetro 20 <br/>TOTAL:<br/>1 formas Perimetro 20 Area 25", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasCuadrados()
        {
            var cuadrados = new List<FormasG>
            {
                new Cuadrado(5),
                new Cuadrado(1),
                new Cuadrado(3)
            };

            var resumen = FormaGeometrica.Imprimir(cuadrados, new Ingles());

            Assert.AreEqual("<h1>Shapes report</h1>3 Squares | Area 35 | Perimeter 36 <br/>TOTAL:<br/>3 shapes Perimeter 36 Area 35", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTipos()
        {

            var formas = new List<FormasG>
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m)
            };

            var resumen = FormaGeometrica.Imprimir(formas, new Ingles());

            Assert.AreEqual(
                "<h1>Shapes report</h1>2 Squares | Area 29 | Perimeter 28 <br/>2 Circles | Area 13,01 | Perimeter 18,06 <br/>3 Triangles | Area 49,64 | Perimeter 51,6 <br/>TOTAL:<br/>7 shapes Perimeter 97,66 Area 91,65",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnCastellano()
        {
            var formas = new List<FormasG>
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m)
            };

            var resumen = FormaGeometrica.Imprimir(formas, new Castellano());

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>2 Cuadrados | Area 29 | Perimetro 28 <br/>2 Círculos | Area 13,01 | Perimetro 18,06 <br/>3 Triángulos | Area 49,64 | Perimetro 51,6 <br/>TOTAL:<br/>7 formas Perimetro 97,66 Area 91,65",
                resumen);
        }

        [TestCase(5, 2, 10, 14)]
        [TestCase(5, 6, 30, 22)]
        [TestCase(10, 5, 50, 30)]
        public void TestRectangulo(int baseR, int altura, int area, int perimetro)
        {
            var rectangulo = new List<FormasG> { new Rectangulo(baseR, altura)};

            var resumen = FormaGeometrica.Imprimir(rectangulo, new Castellano());

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Rectangulo | Area "+area +" | Perimetro "+perimetro+ " <br/>TOTAL:<br/>1 formas Perimetro " + perimetro + " Area " + area, resumen);

        }

        [TestCase(10, 5, 6, 4, 60, 54)]
        public void TestTrapeciosIngles(int lado, int lado2, int laterales, int altura, int area, int perimetro)
        {
            var trapecio = new List<FormasG> { new Trapecio(lado, lado2, laterales, altura), new Trapecio(lado, lado2, laterales, altura) };

            var resumen = FormaGeometrica.Imprimir(trapecio, new Ingles());

            Assert.AreEqual("<h1>Shapes report</h1>2 Trapezoids | Area " + area +" | Perimeter "+ perimetro +" <br/>TOTAL:<br/>2 shapes Perimeter "+ perimetro +" Area " + area, resumen);

        }
    }
}

