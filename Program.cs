using System;

namespace new_features_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            NewFeatures nf = new("Nasim Uddin");

            (int max, int min) = nf.MinMax(5, 2);

            Console.WriteLine($"Max: {max}, Min: {min}");
            Console.WriteLine($"{nf.FromRainbow(Rainbow.Red)}");

            Console.WriteLine($"{NewFeatures.RockPaperScissors("rock", "paper")}");
            Console.WriteLine($"{NewFeatures.RockPaperScissors("scissors", "rock")}");
            Console.WriteLine($"{NewFeatures.RockPaperScissors("rock", "rock")}");

            nf.IndicesAndRanges();
            nf.NullCoalescing();
        }
    }
}
