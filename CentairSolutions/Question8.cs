using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentairSolutions
{
    public class Diamondeer
    {

        private TextWriter output;

        public Diamondeer()
        {
            this.output = System.Console.Out;
        }

        public Diamondeer(TextWriter writer)
        {
            this.output = writer;
        }

        private void PrintSpaces(int num)
        {
            for (int j = 0; j < num; j++)
            {
                output.Write(' ');
            }
        }

        public void PrintDiamond(int width, bool filled = true)
        {
            output.WriteLine();
            for (int line = -width + 1; line < width; line++)
            {
                PrintSpaces(Math.Abs(line));
                output.Write('*');
                for (int j = width - Math.Abs(line); j > 1; j -= 1)
                {
                    output.Write(
                        (j == 2 || filled) ?
                            " *" : "  ");
                }
                PrintSpaces(Math.Abs(line));
                output.WriteLine();
            }
        }
    }
}
