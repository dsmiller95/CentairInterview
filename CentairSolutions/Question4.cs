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
            if (input == null)
                return null;

            //using coctail sort because the example given was small, so a simple sort will be most efficient
            //and avoiding a need to instantiate any new data structures
            int top = input.Length - 1, bottom = 0;

            while (top > bottom)
            {
                for (int i = bottom; i < top; i++)
                {
                    if (input[i+1] < input[i])
                    {
                        swap(i+1, i, input);
                    }
                }
                top -= 1;
                for (int i = top - 1; i >= bottom; i--)
                {
                    if (input[i + 1] < input[i])
                    {
                        swap(i + 1, i, input);
                    }
                }
                bottom += 1;
            }

            return input;
        }

        private void swap(int first, int second, int[] arr)
        {
            int x = arr[first];
            arr[first] = arr[second];
            arr[second] = x;
        }

        public int[] ProductionSort(int[] input)
        {
            return input.ToList().OrderBy(num => num).ToArray();
        }
    }
}
