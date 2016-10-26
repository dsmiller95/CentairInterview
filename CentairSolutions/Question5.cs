using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentairSolutions
{
    public class Digitizer
    {
        public string GetDigits(string input)
        {
            if (input == null)
                return null;
            var digits = new StringBuilder();

            foreach (var chr in input)
            {
                if (chr >= '0' && chr <= '9')
                {
                    digits.Append(chr);
                }
            }
            return digits.ToString();
        }
    }
}
