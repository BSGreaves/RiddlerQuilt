using System;
using riddlerQuiltC_.Models;

namespace riddlerQuiltC_
{
    class Program
    {
        static void Main(string[] args)
        {
            Random RandomGenerator = new Random();
            var FabricSquare1 = new FabricSquare(RandomGenerator);

            Console.WriteLine(FabricSquare1.Color);
        }
    }
}
