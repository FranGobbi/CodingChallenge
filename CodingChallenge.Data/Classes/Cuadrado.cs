using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingChallenge.Data.Classes
{
    public class Cuadrado : Figura

    {
        private readonly decimal _lado;

        public Cuadrado(decimal lado)
        {
            _lado = lado;
        }
        
        public override decimal Area()
        {
            return _lado * _lado;
        }

        public override decimal Perimetro()
        {
            return _lado * 4;
        }
    }
}
