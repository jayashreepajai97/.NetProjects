using System;

namespace Mathematics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var input = Console.ReadLine();
            var output = InputConverter.ConvertInput(input);
            Console.WriteLine(output);

          
        }
    }
}
