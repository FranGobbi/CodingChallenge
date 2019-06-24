using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingChallenge.Data.Classes
{
    public class Triangulo

    {
        private readonly decimal _base;
        private readonly decimal? _ladoIzquierdo;
        private readonly decimal? _ladoDerecho;
        private readonly decimal? _altura;

        public Triangulo(List<decimal> listaLados)
        {
            if (listaLados.Count == 1)
            {
                _base = listaLados[0];
            }
            else if (listaLados.Count == 4)
            {
                _base = listaLados[0];
                _altura = listaLados[1];
                _ladoIzquierdo = listaLados[2];
                _ladoDerecho = listaLados[3];
            }
            else throw new ArgumentOutOfRangeException(@"Error al crear Triangulo");
        }

        //public Triangulo(decimal lado)
        //{
        //    _base = lado;
        //}
        //public Triangulo(decimal baseTr, decimal altura, decimal ladoIzquierdo, decimal ladoDerecho)
        //{
        //    _base = baseTr;
        //    _ladoIzquierdo = ladoIzquierdo;
        //    _ladoDerecho = ladoDerecho;
        //    _altura = altura;
        //}

        public decimal Area()
        {
            if (_altura.HasValue)
            {
                return _base * (decimal)_altura / 2;
            }
            return ((decimal)Math.Sqrt(3) / 4) * _base * _base;
        }

        public decimal Perimetro()
        {
            if (_altura.HasValue)
            {
                return _base + (decimal)_ladoIzquierdo + (decimal)_ladoDerecho;
            }
            return _base * 3;
        }
    }
}
