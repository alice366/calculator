using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            decimal output = 0;
            DataContainer dc = new DataContainer();
            Console.WriteLine("Write your number");
            dc.FirstInput = Input.createInput();
            Console.WriteLine("Write your number");
            dc.SecondInput = Input.createInput();

            if (InputValidation.CheckAll(dc.FirstInput) && InputValidation.CheckAll(dc.SecondInput))
            {
                
                dc.FirstNumber = dc.ConvertToDec(dc.FirstInput);
                dc.SecondNumber = dc.ConvertToDec(dc.SecondInput);
                Console.WriteLine("Write your operator [+,-,*,/,%]");
                dc.Command = Input.createInput();
            }
            switch (dc.Command)
            {
                case "+":
                    output = MathOperations.Add(dc.FirstNumber, dc.SecondNumber);
                    break;
                case "-":
                    output = MathOperations.Substract(dc.FirstNumber, dc.SecondNumber);
                    break;
                case "*":
                    output = MathOperations.Multiply(dc.FirstNumber, dc.SecondNumber);
                    break;
                case "/":
                    output = MathOperations.Divide(dc.FirstNumber, dc.SecondNumber);
                    break;
                case "%":
                    output = MathOperations.Modulo(dc.FirstNumber, dc.SecondNumber);
                    break;
            }
            Console.WriteLine("Your result equals " + output);
            Console.ReadKey();
        }
    }
}
