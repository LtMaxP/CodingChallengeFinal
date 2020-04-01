/*
 * Refactorear la clase para respetar principios de programación orientada a objetos. Qué pasa si debemos soportar un nuevo idioma para los reportes, o
 * agregar más formas geométricas?
 *
 * Se puede hacer cualquier cambio que se crea necesario tanto en el código como en los tests. La única condición es que los tests pasen OK.
 *
 * TODO: Implementar Trapecio/Rectangulo, agregar otro idioma a reporting.
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingChallenge.Data.Classes
{
    public class FormaGeometrica
    {

        private readonly decimal _lado;

        public int Tipo { get; set; }

        public FormaGeometrica(int tipo, decimal ancho)
        {
            Tipo = tipo;
            _lado = ancho;
        }

        public static string Imprimir(List<FormasG> formas, Idioma idioma)
        {
            var sb = new StringBuilder();

            if (!formas.Any())
            {
                sb.Append(idioma.traducir("listaVacia"));
            }
            else
            {
                // Hay por lo menos una forma
                // HEADER
                sb.Append(idioma.traducir("Cabecera"));
                #region variablesFormas
                var numeroCuadrados = 0;
                var numeroCirculos = 0;
                var numeroTriangulos = 0;
                var numeroTrapecios = 0;
                var numeroRectangulos = 0;

                var areaCuadrados = 0m;
                var areaCirculos = 0m;
                var areaTriangulos = 0m;
                var areaTrapecios = 0m;
                var areaRectangulos = 0m;

                var perimetroCuadrados = 0m;
                var perimetroCirculos = 0m;
                var perimetroTriangulos = 0m;
                var perimetroTrapecios = 0m;
                var perimetroRectangulos = 0m;
                #endregion
                for (var i = 0; i < formas.Count; i++)
                {
                    if (formas[i].GetType().Equals(typeof(Cuadrado)))
                    {
                        numeroCuadrados++;
                        areaCuadrados += formas[i].area;
                        perimetroCuadrados += formas[i].perimetro;
                    }
                    if (formas[i].GetType().Equals(typeof(Circulo)))
                    {
                        numeroCirculos++;
                        areaCirculos += formas[i].area;
                        perimetroCirculos += formas[i].perimetro;
                    }
                    if (formas[i].GetType().Equals(typeof(TrianguloEquilatero)))
                    {
                        numeroTriangulos++;
                        areaTriangulos += formas[i].area;
                        perimetroTriangulos += formas[i].perimetro;
                    }
                    if (formas[i].GetType().Equals(typeof(Trapecio)))
                    {
                        numeroTrapecios++;
                        areaTrapecios += formas[i].area;
                        perimetroTrapecios += formas[i].perimetro;
                    }
                    if (formas[i].GetType().Equals(typeof(Rectangulo)))
                    {
                        numeroRectangulos++;
                        areaRectangulos += formas[i].area;
                        perimetroRectangulos += formas[i].perimetro;
                    }
                }

                //Arreglo por error en muchos decimales
                #region redondeo
                areaCuadrados = RedondearNumeroGrande(areaCuadrados);
                areaCirculos = RedondearNumeroGrande(areaCirculos);
                areaTriangulos = RedondearNumeroGrande(areaTriangulos);
                areaTrapecios = RedondearNumeroGrande(areaTrapecios);
                areaRectangulos = RedondearNumeroGrande(areaRectangulos);
                perimetroCuadrados = RedondearNumeroGrande(perimetroCuadrados);
                perimetroCirculos = RedondearNumeroGrande(perimetroCirculos);
                perimetroTriangulos = RedondearNumeroGrande(perimetroTriangulos);
                perimetroTrapecios = RedondearNumeroGrande(perimetroTrapecios);
                perimetroRectangulos = RedondearNumeroGrande(perimetroRectangulos);
                #endregion
                sb.Append(ObtenerLinea(numeroCuadrados, areaCuadrados, perimetroCuadrados, numeroCuadrados > 1 ? idioma.traducir("Cuadrados") : idioma.traducir("Cuadrado"), idioma));
                sb.Append(ObtenerLinea(numeroCirculos, areaCirculos, perimetroCirculos, numeroCirculos > 1 ? idioma.traducir("Circulos") : idioma.traducir("Circulo"), idioma));
                sb.Append(ObtenerLinea(numeroTriangulos, areaTriangulos, perimetroTriangulos, numeroTriangulos > 1 ? idioma.traducir("Triangulos") : idioma.traducir("Triangulo"), idioma));
                sb.Append(ObtenerLinea(numeroTrapecios, areaTrapecios, perimetroTrapecios, numeroTrapecios > 1 ? idioma.traducir("Trapecios") : idioma.traducir("Trapecio"), idioma));
                sb.Append(ObtenerLinea(numeroRectangulos, areaRectangulos, perimetroRectangulos, numeroRectangulos > 1 ? idioma.traducir("Rectangulos") : idioma.traducir("Rectangulo"), idioma));

                // FOOTER
                sb.Append(idioma.traducir("TOTAL") + ":<br/>");
                sb.Append(numeroCuadrados + numeroCirculos + numeroTriangulos + numeroTrapecios + numeroRectangulos + " " + (idioma.traducir("formas")) + " ");
                sb.Append(idioma.traducir("Perimetro") + " " + (perimetroCuadrados + perimetroTriangulos + perimetroCirculos + perimetroTrapecios + perimetroRectangulos).ToString("#.##") + " ");
                sb.Append(idioma.traducir("Area") + " " + (areaCuadrados + areaCirculos + areaTriangulos + areaTrapecios + areaRectangulos).ToString("#.##"));
            }

            return sb.ToString();
        }

        private static string ObtenerLinea(int cantidad, decimal area, decimal perimetro, string tipo, Idioma idioma)
        {
            if (cantidad > 0)
            {
                return $"{cantidad} {tipo} | " + idioma.traducir("Area") + " " + area + " | " + idioma.traducir("Perimetro") + " " + perimetro + " <br/>";
            }

            return string.Empty;
        }

        private static decimal RedondearNumeroGrande(decimal num)
        {
            string numero = num.ToString();
            if (numero.Contains(","))
            {
                string[] total = numero.Split(',');
                if (total[1].Length > 2)
                {
                    num = Decimal.Round(num, 2);
                }
            }
            return num;
        }

    }

}
