using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public static class InputValidation
    {
        private static bool CheckNull(string inputStr)
        {
            return string.IsNullOrEmpty(inputStr) ? true : false;
        }

        private static bool IsNumeric(string inputStr)
        {
            return (inputStr.All(char.IsNumber)) ? true : false;
        }

        private static bool CheckIfZero(string inputStr)
        {
            return decimal.Parse(inputStr) == 0 ? true : false;
        }

        public static bool CheckAll(string inputStr)
        {
            return (IsNumeric(inputStr) && !CheckNull(inputStr) && !CheckIfZero(inputStr)) ? true : false;
        }
    }
}
