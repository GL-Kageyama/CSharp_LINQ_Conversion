using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections;

namespace Conversion
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var conversionClass = new ConversionClass();

            conversionClass.GetConv();
        }
    }

    class ConversionClass
    {
        public void GetConv()
        {
            ArrayList mix = new ArrayList
            {
                "Venezuela", "Ukraine", "Mexico", 123, "1", "abc", 2.22728
            };

            var weightAndHeight = new[]
            {
                new { Weight = 2, Height = 3 },
                new { Weight = 9, Height = 2 },
                new { Weight = 2, Height = 4 },
                new { Weight = 4, Height = 9 },
                new { Weight = 5, Height = 6 },
            };

            var collection = new[]
            {
                "Egypt", "Indonesia", "Monaco", "Paraguay", "Spain",
            };

            // OfType()
            // Convert each element to the specified type. Exclude those that cannot.
            IEnumerable<string> mixS = mix.OfType<string>();
            foreach (string n in mixS)
                Console.WriteLine(n);
            Console.WriteLine();

            // Cast()
            // Convert each element to the specified type. Throws an exception if not possible.
            // 
            // IEnumerable<string> mixSS = mix.Cast<string>();
            // foreach (string n in mixSS)
            //     Console.WriteLine(n);
            // Console.WriteLine();
            // 
            // Commented out because it would result in an exception and stop the process.

            // ToArray()
            // Create an array
            var weight = weightAndHeight.Select(e => e.Weight).ToArray();
            foreach (var n in weight)
                Console.Write("{0} ", n);
            Console.WriteLine();
            var height = weightAndHeight.Select(e => e.Height).ToArray();
            foreach (var n in height)
                Console.Write("{0} ", n);
            Console.WriteLine();
            Console.WriteLine();

            // ToDictionary()
            // Create an associative array (dictionary type)
            var dic = collection.ToDictionary(e => e.First());
            foreach (var n in dic)
                Console.WriteLine(n);
            Console.WriteLine();

            // ToList()
            // Create a list
            var lis = collection.ToList();
            foreach (var n in lis)
                Console.Write("{0} ", n);
            Console.WriteLine();
        }
    }
}