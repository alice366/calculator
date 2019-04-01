using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class MathOperations
    {
        public static decimal Add(decimal inp1, decimal inp2)
        {
            return inp1 + inp2;
        }
        public static decimal Substract(decimal inp1, decimal inp2)
        {
            return inp1 - inp2;
        }
        public static decimal Multiply(decimal inp1, decimal inp2)
        {
            return inp1 * inp2;
        }
        public static decimal Divide(decimal inp1, decimal inp2)
        {
            return inp1 / inp2;
        }
        public static decimal Modulo(decimal inp1, decimal inp2)
        {
            return inp1 % inp2;
        }
    }
}
