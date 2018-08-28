using System;
using System.Collections.Generic;

namespace riddlerQuiltC_.Models
{
    public class FabricSquare 
    {
        public string Color { get; }
        public FabricSquare(Random randomGenerater)
        {
            Color = GetRandomColor(randomGenerater);
        }

        public string GetRandomColor(Random randomGenerater)
        {
             return PossibleColors[randomGenerater.Next(PossibleColors.Count)];
        }

        public List<string> PossibleColors = new List<string>()
        {
            "Midnight Green",
            "Silver",
            "White"
        };
    }
}

