using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._11._4856
{
    class MinMax
    {
        public void GetMinMax(int[] arr, out int max, out int min)
        {
            max = arr[0];
            min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
        }
    }
}
