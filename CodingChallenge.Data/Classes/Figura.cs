using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingChallenge.Data.Classes
{
    public class Figura
    {
        public const int Cuadrado = 1;
        public const int Triangulo = 2;
        public const int Circulo = 3;
        public const int Trapecio = 4;
        public const int Rectangulo = 5;

        private List<decimal> _lados;
        private int _forma;

        public List<decimal> getLados()
        {
            return _lados;
        }
        public int getForma()
        {
            return _forma;
        }

        public Figura(List<decimal> lados, int forma)
        {
            _lados = lados;
            _forma = forma;
        }
    }
}
