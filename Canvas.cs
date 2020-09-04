namespace BitmapGenerator
{
    public static class Canvas
    {
        private static string[ , ] canvas;

        public static string[ , ] GetCanvas()
        {
            if (canvas == null)
                InitializeCanvas();

            return canvas.Clone() as string[ , ];
        }

        private static void InitializeCanvas()
        {
            canvas = new string[17, 5];

            // Fills it with zeroes
            for (var x = 0; x < 17; x++)
                for (var y = 0; y < 5; y++)
                    canvas[x, y] = "0";

            // Adds the semicolon
            canvas[8, 1] = "1";
            canvas[8, 3] = "1";
        }
    }
}