using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingChallenge.Data.Classes
{
    public class Circulo : Figura
    {
        private readonly decimal _diametro;

        public Circulo(decimal diametro)
        {
            _diametro = diametro;
        }
        
        public override decimal Area()
        {
            return (decimal)Math.PI * (_diametro / 2) * (_diametro / 2);
        }

        public override decimal Perimetro()
        {
            return (decimal)Math.PI * _diametro;
        }
    }
}
