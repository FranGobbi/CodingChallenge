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
                FormaGeometrica.Imprimir(new List<Cuadrado>(), new List<Triangulo>(), new List<Circulo>(), new List<Trapecio>(), new List<Rectangulo>(), "Castellano"));
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnIngles()
        {
            Assert.AreEqual("<h1>Empty list of shapes!</h1>",
                FormaGeometrica.Imprimir(new List<Cuadrado>(), new List<Triangulo>(), new List<Circulo>(), new List<Trapecio>(), new List<Rectangulo>(), "Ingles"));
        }
        [TestCase]
        public void TestResumenListaVaciaFormasEnFrances()
        {
            Assert.AreEqual("<h1>Liste vide de formes!</h1>",
                FormaGeometrica.Imprimir(new List<Cuadrado>(), new List<Triangulo>(), new List<Circulo>(), new List<Trapecio>(), new List<Rectangulo>(), "Frances"));
        }

        [TestCase]
        public void TestResumenListaConUnCuadrado()
        {
            var cuadrados = new List<Cuadrado> { new Cuadrado(5) };


            var resumen = FormaGeometrica.Imprimir(cuadrados, null, null, null, null, "Castellano");

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Cuadrado | Área 25 | Perímetro 20 <br/>TOTAL:<br/>1 Forma Perímetro 20 Área 25", resumen);
        }

        [TestCase]
        public void TestResumenListaConUnFrances()
        {
            var cuadrados = new List<Cuadrado> { new Cuadrado(5) };


            var resumen = FormaGeometrica.Imprimir(cuadrados, null, null, null, null, "Frances");

            Assert.AreEqual("<h1>Rapport de Formes</h1>1 Carré | Surface 25 | Périmètre 20 <br/>TOTAL:<br/>1 Forme Périmètre 20 Surface 25", resumen);
        }
        [TestCase]
        public void TestResumenListaConMasCuadrados()
        {
            var cuadrados = new List<Cuadrado>
            {
                new Cuadrado(5),
                new Cuadrado(1),
                new Cuadrado(3)
            };

            var resumen = FormaGeometrica.Imprimir(cuadrados, null, null, null, null, "Ingles");

            Assert.AreEqual("<h1>Shapes report</h1>3 Squares | Area 35 | Perimeter 36 <br/>TOTAL:<br/>3 shapes Perimeter 36 Area 35", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTipos()
        {
            var cuadrados = new List<Cuadrado>
            {
                new Cuadrado(5),
                new Cuadrado(2)
            };
            var triangulos = new List<Triangulo>
            {
                new Triangulo(4),
                new Triangulo(9),
                new Triangulo(4.2m),
            };
            var circulos = new List<Circulo>
            {
                new Circulo(3),
                new Circulo(2.75m)
            };

            var resumen = FormaGeometrica.Imprimir(cuadrados, triangulos, circulos, null, null, "Ingles");

            Assert.AreEqual(
                "<h1>Shapes report</h1>2 Squares | Area 29 | Perimeter 28 <br/>2 Circles | Area 13,01 | Perimeter 18,06 <br/>3 Triangles | Area 49,64 | Perimeter 51,6 <br/>TOTAL:<br/>7 shapes Perimeter 97,66 Area 91,65",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnCastellano()
        {
            var cuadrados = new List<Cuadrado>
            {
                new Cuadrado(5),
                new Cuadrado(2),
            };

            var circulos = new List<Circulo>
            {
                new Circulo(3),
                new Circulo(2.75m)
            };
            var triangulos = new List<Triangulo>
            {
                new Triangulo(4.2m),
                new Triangulo(9),
                new Triangulo(4)
            };

            var resumen = FormaGeometrica.Imprimir(cuadrados, triangulos, circulos, null, null, "Castellano");

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>2 Cuadrados | Área 29 | Perímetro 28 <br/>2 Círculos | Área 13,01 | Perímetro 18,06 <br/>3 Triángulos | Área 49,64 | Perímetro 51,6 <br/>TOTAL:<br/>7 Formas Perímetro 97,66 Área 91,65",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConTiposNuevosEnCastellano()
        {
            var cuadrados = new List<Cuadrado>
            {
                new Cuadrado(5),
                new Cuadrado(2),
            };

            var circulos = new List<Circulo>
            {
                new Circulo(3),
                new Circulo(2.75m)
            };
            var triangulos = new List<Triangulo>
            {
                new Triangulo(4.2m),
                new Triangulo(6,2,4,3),
                new Triangulo(4)
            };
            var trapecios = new List<Trapecio>
            {
                new Trapecio(6,1,3,4)
            };
            var rectangulo = new List<Rectangulo>
            {
                new Rectangulo(2,3)
            };
            var resumen = FormaGeometrica.Imprimir(cuadrados, triangulos, circulos, trapecios, rectangulo, "Castellano");

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>2 Cuadrados | Área 29 | Perímetro 28 <br/>2 Círculos | Área 13,01 | Perímetro 18,06 <br/>3 Triángulos | Área 20,57 | Perímetro 37,6 <br/>1 Trapecio | Área 4,5 | Perímetro 17 <br/>1 Rectángulo | Área 6 | Perímetro 10 <br/>TOTAL:<br/>9 Formas Perímetro 110,66 Área 73,07",
                resumen);
        }
    }
}
