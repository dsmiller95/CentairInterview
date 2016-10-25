using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentairSolutions
{
    public class Sorter
    {
        public int[] SortArray(int[] input)
        {
            //using coctail sort because the example given was small, so a simple sort will be most efficient
            //and avoiding a need to instantiate any new data structures
            return new int[0];
        }

        public int[] NiaveSort(int[] input)
        {
            return input.ToList().OrderBy(num => num).ToArray();
        }
    }
}
