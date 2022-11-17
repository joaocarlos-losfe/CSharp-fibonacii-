using System;
using System.Collections.Generic;


namespace fibonacii
{
    public class Fib
    {
        public static List<int> Random()
        {
            var random = new Random();
            return Generate(random.Next(20));
        }

        public static List<int> Generate(int maximum_sequence)
        {
            var fib_seq = new List<int> { 1, 1 };

            while (fib_seq.Count < maximum_sequence)
            {
                var last = fib_seq[^1];
                var previus = fib_seq[^2];

                fib_seq.Add(last + previus);
            }

            return fib_seq;
        }

    }
}
