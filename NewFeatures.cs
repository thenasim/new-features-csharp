using System;

namespace new_features_csharp
{
    public enum Rainbow
    {
        Red,
        Orange,
        Yellow,
        Green,
        Blue,
        Indigo,
        Violet
    }

    class NewFeatures
    {
        // ? Readonly field can only be assigned in constructor and declaration time
        // ? After that it can not be changed
        public readonly string Name;

        // ? Const can only be assigned in declaration time
        public const double PI = 3.1416;

        public int X { set; get; }
        public int Y { set; get; }


        public NewFeatures(string name) {
            this.Name = name;
            Console.WriteLine($"{this.Name}, {PI}");
        }


        // ? Tuple
        public (int max, int min) MinMax(int a, int b) {
            if (a > b) {
                return (a, b);
            }
            return (b, a);
        }


        // ? Pattern Matching
        public (int r, int g, int b) FromRainbow(Rainbow colorBand) {
            return colorBand switch
            {
                Rainbow.Red => (255, 0, 0),
                Rainbow.Orange => (255, 165, 0),
                Rainbow.Yellow => (255, 255, 0),
                Rainbow.Green => (0, 128, 0),
                Rainbow.Blue => (0, 0, 255),
                Rainbow.Indigo => (75, 0, 130),
                Rainbow.Violet => (100, 100, 100),
                _ => (0, 0, 0),
            };
        }


        // ? Tuple Pattern
        public static string RockPaperScissors(string first, string second)
        => (first, second) switch
        {
            ("rock", "paper") => "rock is covered by paper. Paper wins.",
            ("rock", "scissors") => "rock breaks scissors. Rock wins.",
            ("paper", "rock") => "paper covers rock. Paper wins.",
            ("paper", "scissors") => "paper is cut by scissors. Scissors wins.",
            ("scissors", "rock") => "scissors is broken by rock. Rock wins.",
            ("scissors", "paper") => "scissors cuts paper. Scissors wins.",
            (_, _) => "tie"
        };


        // ? Positional patterns
        public void Point(int x, int y) => (X, Y) = (x, y); // sets X, Y to x, y


        // ? Indices and ranges
        public void IndicesAndRanges() {
            var words = new string[]
            {
                            // index from start    index from end
                "The",      // 0                   ^9
                "quick",    // 1                   ^8
                "brown",    // 2                   ^7
                "fox",      // 3                   ^6
                "jumped",   // 4                   ^5
                "over",     // 5                   ^4
                "the",      // 6                   ^3
                "lazy",     // 7                   ^2
                "dog"       // 8                   ^1
            };              // 9 (or words.Length) ^0

            Console.WriteLine($"Last word: {words[^1]}");

            var quickBrownFox = words[1..4]; // [Quick, Borwn, Fox]

            Range phrase = 6..8;
            var theLazyDog = words[phrase];
        }


        // ? Null-coalescing assignment
        public void NullCoalescing() {
            int? i = 18;
            int? ans = null;

            ans ??= i;

            Console.WriteLine($"Null coalescing: {ans}");
        }
    }
}
