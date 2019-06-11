using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingChallenge.Data.Classes
{
    public class Rectangulo : Figura

    {
        private readonly decimal _base;
        private readonly decimal _altura;

        public Rectangulo(decimal lado, decimal altura)
        {
            _base = lado;
            _altura = altura;
        }

        public override decimal Area()
        {
            return _base * _altura;
        }

        public override decimal Perimetro()
        {
            return _base * 2 + _altura * 2;
        }
    }
}
