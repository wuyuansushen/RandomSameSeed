using System;

namespace RandomSameSeed
{
    class Program
    {
        static void Main(string[] args)
        {
            var seedRan = new Random();
            int seed = seedRan.Next();
            var r1 = new Random(seed);
            var r2 = new Random(seed);

            Random ran;

            int[] output = new int[30];
            for (int o = 0; o < 2; o++)
            {
                if (o == 0)
                    ran = r1;
                else
                    ran = r2;
                for (int i = 0; i < output.Length; i++)
                {
                    output[i] = ran.Next(30);
                    Console.Write($"{output[i]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
