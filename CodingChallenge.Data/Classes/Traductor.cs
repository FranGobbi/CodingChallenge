using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class Traductor
    {
        #region Idiomas

        #endregion


        #region Descripciones

        private string _descForma;
        private string _descFormasPlural;        
        private string _descArea;
        private string _descPerimetro;
        private string _descCuadrado;
        private string _descTriangulo;
        private string _descCirculo;
        private string _descTrapecio;
        private string _descRectangulo;
        private string _descCuadradoPlural;
        private string _descTrianguloPlural;
        private string _descCirculoPlural;
        private string _descTrapecioPlural;
        private string _descRectangulosPlural;
        private string _descListaVacia;
        private string _descReporte;
        #endregion


        #region Traductor
        public Traductor(string idioma)
        {
            switch (idioma)
            {
                case "Castellano":
                    _descForma = "Forma";
                    _descFormasPlural = "Formas";
                    _descArea = "Área";
                    _descPerimetro = "Perímetro";
                    _descCuadrado = "Cuadrado";
                    _descTriangulo = "Triángulo";
                    _descCirculo = "Círculo";
                    _descTrapecio = "Trapecio";
                    _descRectangulo = "Rectángulo";
                    _descReporte = "Reporte de Formas";
                    _descCuadradoPlural = "Cuadrados";
                    _descTrianguloPlural = "Triángulos";
                    _descCirculoPlural = "Círculos";
                    _descTrapecioPlural = "Trapecios";
                    _descRectangulosPlural = "Rectangulos";
                    _descListaVacia = "Lista vacía de formas!";
                    break;
                case "Ingles":
                    _descForma = "shape";
                    _descFormasPlural = "shapes";
                    _descArea = "Area";
                    _descPerimetro = "Perimeter";
                    _descCuadrado = "Square";
                    _descTriangulo = "Triangle";
                    _descCirculo = "Circle";
                    _descTrapecio = "Trapezoid";
                    _descRectangulo = "Rectangle";
                    _descReporte = "Shapes report";
                    _descCuadradoPlural = "Squares";
                    _descTrianguloPlural = "Triangles";
                    _descCirculoPlural = "Circles";
                    _descTrapecioPlural = "Trapezoids";
                    _descRectangulosPlural = "Rectangles";
                    _descListaVacia = "Empty list of shapes!";
                    break;
                case "Frances":
                    _descForma = "Forme";
                    _descFormasPlural = "Formes";
                    _descArea = "Surface";
                    _descPerimetro = "Périmètre";
                    _descCuadrado = "Carré";
                    _descTriangulo = "Triangle";
                    _descCirculo = "Cercle";
                    _descTrapecio = "Trapèze";
                    _descRectangulo = "Rectangle";
                    _descReporte = "Rapport de Formes";
                    _descCuadradoPlural = "carrés";
                    _descTrianguloPlural = "Triangles";
                    _descCirculoPlural = "Cercles";
                    _descTrapecioPlural = "Trapèzes";
                    _descRectangulosPlural = "Rectangles";
                    _descListaVacia = "Liste vide de formes!";
                    break;
                default:
                    throw new ArgumentOutOfRangeException(@"Idioma desconocido");
            }
        }
        #endregion


        #region Gets
        public string getDescForma()
        {
            return _descForma;
        }
        public string getDescFormasPlural()
        {
            return _descFormasPlural;
        }
        public string getDescArea()
        {
            return _descArea;
        }
        public string getDescPerimetro()
        {
            return _descPerimetro;
        }
        public string getDescCuadrado()
        {
            return _descCuadrado;
        }
        public string getDescTriangulo()
        {
            return _descTriangulo;
        }
        public string getDescCirculo()
        {
            return _descCirculo;
        }
        public string getDescTrapecio()
        {
            return _descTrapecio;
        }
        public string getDescRectangulo()
        {
            return _descRectangulo;
        }
        public string getDescCuadradoPlural()
        {
            return _descCuadradoPlural;
        }
        public string getDescTrianguloPlural()
        {
            return _descTrianguloPlural;
        }
        public string getDescCirculoPlural()
        {
            return _descCirculoPlural;
        }
        public string getDescTrapecioPlural()
        {
            return _descTrapecioPlural;
        }
        public string getDescRectangulosPlural()
        {
            return _descRectangulosPlural;
        }
        public string getDescListaVacia()
        {
            return _descListaVacia;
        }
        public string getDescReporte()
        {
            return _descReporte;
        }
        #endregion
    }
}
