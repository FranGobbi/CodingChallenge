using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingChallenge.Data.Classes
{
    public class Trapecio : Figura
    {
        private readonly decimal _baseInferior;
        private readonly decimal _baseSuperior;
        private readonly decimal _altura;
        private readonly decimal _ladoLateralIzquierdo;
        private readonly decimal? _ladoLateralDerecho;

        public Trapecio(decimal baseInf, decimal altura, decimal baseSuperior, decimal ladoLateralIzquierdo)
        {
            _baseInferior = baseInf;
            _altura = altura;
            _baseSuperior = baseSuperior;
            _ladoLateralIzquierdo = ladoLateralIzquierdo;
        }


        public Trapecio(decimal lado, decimal altura, decimal ladoOpuesto, decimal ladoLateralIzquierdo, decimal ladoLateralDerecho)
        {
            _baseInferior = lado;
            _altura = altura;
            _baseSuperior = ladoOpuesto;
            _ladoLateralIzquierdo = ladoLateralIzquierdo;
            _ladoLateralDerecho = ladoLateralDerecho;
        }

        public override decimal Area()
        {
            return (_baseInferior + _baseSuperior) * _altura / 2;
        }

        public override decimal Perimetro()
        {
            if (_ladoLateralDerecho.HasValue)
            {
                return _baseInferior + _ladoLateralIzquierdo + (decimal)_ladoLateralDerecho + _baseSuperior;
            }
            return _baseInferior + _ladoLateralIzquierdo * 2 + _baseSuperior;
        }
    }
}
