namespace BitmapGenerator.Shapes
{
    public class HorizontalLine : IShape
    {
        public int YPos {get; private set;}
        public int StartingX {get; private set;}
        public int Length {get; private set;}

        public HorizontalLine(int yPos, int startingX, int length)
        {
            YPos = yPos;
            StartingX = startingX;
            Length = length;
        }

        public void Draw(string[,] bitmap)
        {
            for (var x = StartingX; x < StartingX + Length; x++)
                bitmap[x, YPos] = "0";
        }
    }
}