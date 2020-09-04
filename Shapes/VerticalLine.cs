namespace BitmapGenerator.Shapes
{
    public class VerticalLine : IShape
    {
        public int XPos {get; private set;}
        public int StartingY {get; private set;}
        public int Length {get; private set;}

        public VerticalLine(int xPos, int startingY, int length)
        {
            XPos = xPos;
            StartingY = startingY;
            Length = length;
        }

        public void Draw(string[,] bitmap)
        {
            for (var y = StartingY; y < StartingY + Length; y++)
                bitmap[XPos, y] = "0";
        }
    }
}