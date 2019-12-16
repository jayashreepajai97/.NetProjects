using System;
using System.Collections.Generic;
using System.Text;

namespace Mathematics
{
    
    public static class InputConverter
    {
        public static string ConvertInput(string input)
        {
            int[] arr = Array.ConvertAll(input.Split(' '), int.Parse);
            Array.Sort(arr);
            return string.Join(" ", arr);
        }
    }
}
