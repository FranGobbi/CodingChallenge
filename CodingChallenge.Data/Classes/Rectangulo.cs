using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingChallenge.Data.Classes
{
    public class Rectangulo 

    {
        private readonly decimal _base;
        private readonly decimal _altura;
        public Rectangulo(List<decimal> listaLados)
        {
            if (listaLados.Count == 2)
            {
                _base = listaLados[0];
                _altura = listaLados[1];
            }
            else throw new ArgumentOutOfRangeException(@"Error al crear Rectangulo");
        }

        //public Rectangulo(decimal lado, decimal altura)
        //{
        //    _base = lado;
        //    _altura = altura;
        //}

        public decimal Area()
        {
            return _base * _altura;
        }

        public decimal Perimetro()
        {
            return _base * 2 + _altura * 2;
        }
    }
}
