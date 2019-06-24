using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingChallenge.Data.Classes
{
    public class Cuadrado

    {
        private readonly decimal _lado;

        public Cuadrado(List<decimal> listaLados)
        {
            if (listaLados.Count == 1)
            {
                _lado = listaLados[0];
            }
            else throw new ArgumentOutOfRangeException(@"Error al crear Cuadrado");
        }
        //public Cuadrado(decimal lado)
        //{
        //    _lado = lado;
        //}

        public decimal Area()
        {
            return _lado * _lado;
        }

        public decimal Perimetro()
        {
            return _lado * 4;
        }
    }
}
