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
            FormaGeometrica formaGeometrica = new FormaGeometrica();
            Assert.AreEqual("<h1>Lista vacía de formas!</h1>",
                formaGeometrica.Imprimir(new List<Figura>(), "Castellano"));
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnIngles()
        {
            FormaGeometrica formaGeometrica = new FormaGeometrica();
            Assert.AreEqual("<h1>Empty list of shapes!</h1>",
                formaGeometrica.Imprimir(new List<Figura>(), "Ingles"));
        }
        [TestCase]
        public void TestResumenListaVaciaFormasEnFrances()
        {
            FormaGeometrica formaGeometrica = new FormaGeometrica();
            Assert.AreEqual("<h1>Liste vide de formes!</h1>",
                formaGeometrica.Imprimir(new List<Figura>(), "Frances"));
        }

        [TestCase]
        public void TestResumenListaConUnCuadrado()
        {
            FormaGeometrica formaGeometrica = new FormaGeometrica();

            List<Figura> listaFiguras = new List<Figura>();

            listaFiguras.Add(new Figura(new List<decimal> { 5 }, 1));

            var resumen = formaGeometrica.Imprimir(listaFiguras, "Castellano");

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Cuadrado | Área 25 | Perímetro 20 <br/>TOTAL:<br/>1 Forma Perímetro 20 Área 25", resumen);
        }

        [TestCase]
        public void TestResumenListaConUnFrances()
        {
            FormaGeometrica formaGeometrica = new FormaGeometrica();
            List<Figura> listaFiguras = new List<Figura>();

            listaFiguras.Add(new Figura(new List<decimal> { 5 }, 1));


            var resumen = formaGeometrica.Imprimir(listaFiguras, "Frances");

            Assert.AreEqual("<h1>Rapport de Formes</h1>1 Carré | Surface 25 | Périmètre 20 <br/>TOTAL:<br/>1 Forme Périmètre 20 Surface 25", resumen);
        }
        [TestCase]
        public void TestResumenListaConMasCuadrados()
        {
            FormaGeometrica formaGeometrica = new FormaGeometrica();

            var listaFiguras = new List<Figura>
            {
                new Figura(new List<decimal> { 5 }, 1),
                new Figura(new List<decimal> { 1 }, 1),
                new Figura(new List<decimal> { 3 }, 1)
            };

            var resumen = formaGeometrica.Imprimir(listaFiguras, "Ingles");

            Assert.AreEqual("<h1>Shapes report</h1>3 Squares | Area 35 | Perimeter 36 <br/>TOTAL:<br/>3 shapes Perimeter 36 Area 35", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTipos()
        {
            FormaGeometrica formaGeometrica = new FormaGeometrica();

            var listaFiguras = new List<Figura>
            {
                new Figura(new List<decimal> { 5 }, 1),
                new Figura(new List<decimal> { 2 }, 1),
                new Figura(new List<decimal> { 4 } , 2),
                new Figura(new List<decimal> { 9 }, 2),
                new Figura(new List<decimal> { 4.2m }, 2),
                new Figura(new List<decimal> { 3 } , 3),
                new Figura(new List<decimal> { 2.75m } , 3)
            };

            var resumen = formaGeometrica.Imprimir(listaFiguras, "Ingles");

            Assert.AreEqual(
                "<h1>Shapes report</h1>2 Squares | Area 29 | Perimeter 28 <br/>2 Circles | Area 13,01 | Perimeter 18,06 <br/>3 Triangles | Area 49,64 | Perimeter 51,6 <br/>TOTAL:<br/>7 shapes Perimeter 97,66 Area 91,65",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnCastellano()
        {
            FormaGeometrica formaGeometrica = new FormaGeometrica();

            var listaFiguras = new List<Figura>
            {
                new Figura(new List<decimal> { 5 },1),
                new Figura(new List<decimal> { 2 }, 1),
                new Figura(new List<decimal> { 3 } , 3),
                new Figura(new List<decimal> { 2.75m } , 3),
                new Figura(new List<decimal> { 4.2m }, 2),
                new Figura(new List<decimal> { 9 }, 2),
                new Figura(new List<decimal> { 4 }, 2)
            };

            var resumen = formaGeometrica.Imprimir(listaFiguras, "Castellano");

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>2 Cuadrados | Área 29 | Perímetro 28 <br/>2 Círculos | Área 13,01 | Perímetro 18,06 <br/>3 Triángulos | Área 49,64 | Perímetro 51,6 <br/>TOTAL:<br/>7 Formas Perímetro 97,66 Área 91,65",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConTiposNuevosEnCastellano()
        {
            FormaGeometrica formaGeometrica = new FormaGeometrica();

            var listaFiguras = new List<Figura>
            {
                new Figura(new List<decimal> {5 } , 1 ),
                new Figura(new List<decimal> {2 } , 1 ),
                new Figura(new List<decimal> { 4.2m }, 2),
                new Figura(new List<decimal> { 6,2,4,3 }, 2),
                new Figura(new List<decimal> { 4}, 2),
                new Figura(new List<decimal> { 3 } , 3),
                new Figura(new List<decimal> { 2.75m } , 3),
                new Figura(new List<decimal> { 6,1,3,4}, 4),
                new Figura(new List<decimal> { 2,3}, 5)
            };
            var resumen = formaGeometrica.Imprimir(listaFiguras, "Castellano");

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>2 Cuadrados | Área 29 | Perímetro 28 <br/>2 Círculos | Área 13,01 | Perímetro 18,06 <br/>3 Triángulos | Área 20,57 | Perímetro 37,6 <br/>1 Trapecio | Área 4,5 | Perímetro 17 <br/>1 Rectángulo | Área 6 | Perímetro 10 <br/>TOTAL:<br/>9 Formas Perímetro 110,66 Área 73,07",
                resumen);
        }
    }
}
