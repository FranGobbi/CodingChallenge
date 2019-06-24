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
        public List<Circulo> listaCirculos;
        public List<Cuadrado> listaCuadrados;
        public List<Rectangulo> listaRectangulos;
        public List<Trapecio> listaTrapecios;
        public List<Triangulo> listaTriangulos;
        public string Imprimir(List<Figura> listaFiguras, string idioma)
        {
            Traductor traductor = new Traductor(idioma);

            var sb = new StringBuilder();


            foreach (Figura figura in listaFiguras)
            {
                CrearFigura(figura);
            }
            int cantCuadrados = listaCuadrados != null ? listaCuadrados.Count : 0;
            int cantCirculos = listaCirculos != null ? listaCirculos.Count : 0;
            int cantTriangulos = listaTriangulos != null ? listaTriangulos.Count : 0;
            int cantTrapecios = listaTrapecios != null ? listaTrapecios.Count : 0;
            int cantRectangulos = listaRectangulos != null ? listaRectangulos.Count : 0;
            int cantFiguras = cantCuadrados + cantCirculos + cantTriangulos + cantTrapecios + cantRectangulos;

            if (cantFiguras == 0)
            {
                sb.Append("<h1>" + traductor.getDescListaVacia() + "</h1>");
            }
            else
            {
                sb.Append("<h1>" + traductor.getDescReporte() + "</h1>");

                decimal areaCuadrados = 0;
                decimal areaCirculos = 0;
                decimal areaTriangulos = 0;
                decimal areaTrapecios = 0;
                decimal areaRectangulos = 0;
                decimal areaTotal = 0;
                decimal perimetroCuadrados = 0;
                decimal perimetroCirculos = 0;
                decimal perimetroTriangulos = 0;
                decimal perimetroTrapecios = 0;
                decimal perimetroRectangulos = 0;
                decimal perimTotal = 0;

                if (cantCuadrados != 0)
                {
                    areaCuadrados = listaCuadrados.Sum(x => x.Area());
                    perimetroCuadrados = listaCuadrados.Sum(x => x.Perimetro());
                }
                if (cantCirculos != 0)
                {
                    areaCirculos = listaCirculos.Sum(x => x.Area());
                    perimetroCirculos = listaCirculos.Sum(x => x.Perimetro());
                }
                if (cantTriangulos != 0)
                {
                    areaTriangulos = listaTriangulos.Sum(x => x.Area());
                    perimetroTriangulos = listaTriangulos.Sum(x => x.Perimetro());
                }
                if (cantTrapecios != 0)
                {
                    areaTrapecios = listaTrapecios.Sum(x => x.Area());
                    perimetroTrapecios = listaTrapecios.Sum(x => x.Perimetro());
                }
                if (cantRectangulos != 0)
                {
                    areaRectangulos = listaRectangulos.Sum(x => x.Area());
                    perimetroRectangulos = listaRectangulos.Sum(x => x.Perimetro());
                }
                areaTotal = areaCuadrados + areaCirculos + areaRectangulos + areaTrapecios + areaTriangulos;
                perimTotal = perimetroCuadrados + perimetroCirculos + perimetroTriangulos + perimetroTrapecios + perimetroRectangulos;

                sb.Append(ObtenerLinea(cantCuadrados, areaCuadrados, perimetroCuadrados, "Cuadrado", traductor));
                sb.Append(ObtenerLinea(cantCirculos, areaCirculos, perimetroCirculos, "Circulo", traductor));
                sb.Append(ObtenerLinea(cantTriangulos, areaTriangulos, perimetroTriangulos, "Triangulo", traductor));
                sb.Append(ObtenerLinea(cantTrapecios, areaTrapecios, perimetroTrapecios, "Trapecio", traductor));
                sb.Append(ObtenerLinea(cantRectangulos, areaRectangulos, perimetroRectangulos, "Rectangulo", traductor));

                // FOOTER
                sb.Append("TOTAL:<br/>");
                sb.Append(cantFiguras + " " + (cantFiguras > 1 ? traductor.getDescFormasPlural() : traductor.getDescForma()) + " ");
                sb.Append((traductor.getDescPerimetro()) + " " + (perimTotal).ToString("#.##") + " ");
                sb.Append(traductor.getDescArea() + " " + (areaTotal).ToString("#.##"));
            }
            return sb.ToString();
        }

        private void CrearFigura(Figura figura)
        {
            switch (figura.getForma())
            {
                case Figura.Circulo:
                    if (listaCirculos == null)
                    {
                        listaCirculos = new List<Circulo>();
                    }
                    listaCirculos.Add(new Circulo(figura.getLados()));
                    break;
                case Figura.Cuadrado:
                    if (listaCuadrados == null)
                    {
                        listaCuadrados = new List<Cuadrado>();
                    }
                    listaCuadrados.Add(new Cuadrado(figura.getLados()));
                    break;
                case Figura.Rectangulo:
                    if (listaRectangulos == null)
                    {
                        listaRectangulos = new List<Rectangulo>();
                    }
                    listaRectangulos.Add(new Rectangulo(figura.getLados()));
                    break;
                case Figura.Trapecio:
                    if (listaTrapecios == null)
                    {
                        listaTrapecios = new List<Trapecio>();
                    }
                    listaTrapecios.Add(new Trapecio(figura.getLados()));
                    break;
                case Figura.Triangulo:
                    if (listaTriangulos == null)
                    {
                        listaTriangulos = new List<Triangulo>();
                    }
                    listaTriangulos.Add(new Triangulo(figura.getLados()));
                    break;
            }
        }

        private static string ObtenerLinea(int cantidad, decimal area, decimal perimetro, string figura, Traductor traductor)
        {
            if (cantidad > 0)
            {
                return $"{cantidad} {TraducirForma(figura, cantidad, traductor)} | {traductor.getDescArea()} {area:#.##} | {traductor.getDescPerimetro()} {perimetro:#.##} <br/>";
            }

            return string.Empty;
        }

        private static string TraducirForma(string figura, int cantidad, Traductor traductor)
        {
            switch (figura)
            {
                case "Cuadrado":
                    return cantidad == 1 ? traductor.getDescCuadrado() : traductor.getDescCuadradoPlural();
                case "Circulo":
                    return cantidad == 1 ? traductor.getDescCirculo() : traductor.getDescCirculoPlural();
                case "Triangulo":
                    return cantidad == 1 ? traductor.getDescTriangulo() : traductor.getDescTrianguloPlural();
                case "Trapecio":
                    return cantidad == 1 ? traductor.getDescTrapecio() : traductor.getDescTrapecioPlural();
                case "Rectangulo":
                    return cantidad == 1 ? traductor.getDescRectangulo() : traductor.getDescRectangulosPlural();
            }
            return string.Empty;
        }
    }
}
