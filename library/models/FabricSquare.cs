using System;
using System.Collections.Generic;

namespace riddlerQuiltC_.Models
{
    public class FabricSquare 
    {
        public string Color { get; }
        public int XCoordinate { get;} 
        public int YCoordinate { get; }
        public FabricSquare(Random randomGenerater, int xCoordinate, int yCoordinate)
        {
            Color = GenerateRandomColor(randomGenerater);
            XCoordinate = xCoordinate;
            YCoordinate = xCoordinate;
        }

        public string GenerateRandomColor(Random randomGenerater)
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

