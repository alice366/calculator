using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class DataContainer
    {
        public string FirstInput { get; set; }
        public string SecondInput { get; set; }
        public decimal FirstNumber { get; set; }
        public decimal SecondNumber { get; set; }
        public string Command { get; set; }

        public decimal ConvertToDec(string inp)
        {
            return decimal.Parse(inp);
        }
    }
}
