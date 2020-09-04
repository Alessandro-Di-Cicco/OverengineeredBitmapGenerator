using System.Collections.Generic;

namespace BitmapGenerator.Shapes
{
    public class Rectangle : IShape
    {
        private int[] startingPos;
        private int[] size;

        public IReadOnlyList<int> StartingPos => startingPos;
        public IReadOnlyList<int> Size => size;

        public Rectangle(int startingX, int startingY, int sizeX, int sizeY)
        {
            startingPos = new[]{ startingX, startingY };
            size = new[]{ sizeX, sizeY };
        }

        public void Draw(string[,] bitmap)
        {
            for (var x = startingPos[0]; x < startingPos[0] + size[0]; x++)
            {
                for (var y = startingPos[1]; y < startingPos[1] + size[1]; y++)
                {
                    bitmap[x, y] = "0";
                }
            }
        }
    }
}