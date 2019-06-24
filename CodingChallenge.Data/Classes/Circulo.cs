using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingChallenge.Data.Classes
{
    public class Circulo 
    {
        private readonly decimal _diametro;

        public Circulo(List<decimal> listaLados)
        {
            if (listaLados.Count == 1)
            {
                _diametro = listaLados[0];
            }
            else throw new ArgumentOutOfRangeException(@"Error al crear Circulo");
        }

        //public Circulo(decimal diametro)
        //{
        //    _diametro = diametro;
        //}

        public decimal Area()
        {
            return (decimal)Math.PI * (_diametro / 2) * (_diametro / 2);
        }

        public decimal Perimetro()
        {
            return (decimal)Math.PI * _diametro;
        }
    }
}
