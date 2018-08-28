using System;
using System.Collections.Generic;

namespace riddlerQuiltC_.Models
{
    public class Quilt
    {
        public Quilt (Random random)
        {
            CreateQuilt(random, 100, 100);
        }

        private void CreateQuilt(Random random, int width, int height)
        {
            int row = 1;
            int column = 1;
            while (row <= width)
            {
                while (column <= height)
                {
                    Squares.Add(new FabricSquare(random, row, column));
                    column++;
                }
                row++;
                column = 1;
            }
        }

        public ICollection<FabricSquare> Squares { get; };
    }
}
