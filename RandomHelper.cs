using System;
using System.Collections.Generic;

namespace Selection
{
    public static class RandomHelper
    {
        public static Random Random = new Random();

        public static int Value(int max) => Random.Next(max);

        public static bool Chance(double percentage) => percentage * 100 > Random.Next(100);
    }
}
