using System.Collections.Generic;

namespace BitmapGenerator.Shapes
{
    public class Point : IShape
    {
        private int[] position;
        public IReadOnlyList<int> Position => position;

        public Point(int x, int y)
        {
            position = new[] { x, y };
        }

        public void Draw(string[,] bitmap)
        {
            bitmap[position[0], position[1]] = "0";
        }
    }
}