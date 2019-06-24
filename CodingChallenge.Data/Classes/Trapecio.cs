using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingChallenge.Data.Classes
{
    public class Trapecio
    {
        private readonly decimal _baseInferior;
        private readonly decimal _baseSuperior;
        private readonly decimal _altura;
        private readonly decimal _ladoLateralIzquierdo;
        private readonly decimal? _ladoLateralDerecho;

        public Trapecio(List<decimal> listaLados)
        {
            if (listaLados.Count == 4)
            {
                _baseInferior = listaLados[0];
                _altura = listaLados[1];
                _baseSuperior = listaLados[2];
                _ladoLateralIzquierdo = listaLados[3];
            }
            else if (listaLados.Count == 5)
            {
                _baseInferior = listaLados[0];
                _altura = listaLados[1];
                _baseSuperior = listaLados[2];
                _ladoLateralIzquierdo = listaLados[3];
                _ladoLateralDerecho = listaLados[4];
            }
            else throw new ArgumentOutOfRangeException(@"Error al crear Trapecio");
        }
        //public Trapecio(decimal baseInf, decimal altura, decimal baseSuperior, decimal ladoLateralIzquierdo)
        //{
        //    _baseInferior = baseInf;
        //    _altura = altura;
        //    _baseSuperior = baseSuperior;
        //    _ladoLateralIzquierdo = ladoLateralIzquierdo;
        //}


        //public Trapecio(decimal lado, decimal altura, decimal ladoOpuesto, decimal ladoLateralIzquierdo, decimal ladoLateralDerecho)
        //{
        //    _baseInferior = lado;
        //    _altura = altura;
        //    _baseSuperior = ladoOpuesto;
        //    _ladoLateralIzquierdo = ladoLateralIzquierdo;
        //    _ladoLateralDerecho = ladoLateralDerecho;
        //}

        public decimal Area()
        {
            return (_baseInferior + _baseSuperior) * _altura / 2;
        }

        public decimal Perimetro()
        {
            if (_ladoLateralDerecho.HasValue)
            {
                return _baseInferior + _ladoLateralIzquierdo + (decimal)_ladoLateralDerecho + _baseSuperior;
            }
            return _baseInferior + _ladoLateralIzquierdo * 2 + _baseSuperior;
        }
    }
}
