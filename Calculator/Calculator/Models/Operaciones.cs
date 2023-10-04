using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Models
{
    class Operaciones
    {
        public Decimal numberOne { get; set; }
        public Decimal numberTwo { get; set; }


        public Decimal addition (Decimal a, Decimal b)
        {
            return a + b;
        }

        public Decimal substraction (Decimal a, Decimal b )
        {
            return a - b;
        }

        public Decimal multiplication (Decimal a, Decimal b)
        {
            return a * b;
        }

        public Decimal division (Decimal a, Decimal b)
        {
            Decimal result = a / b;
            return result;
        }
    }
}
