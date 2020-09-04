using System;
using System.Text;

namespace BitmapGenerator
{
    public static class ArrayUtils
    {
        public static void SetArea(this string[ , ] array, string[ , ] area, int xPos, int yPos)
        {
            var sizeX = area.GetLength(0);
            var sizeY = area.GetLength(1);

            for (var x = 0; x < sizeX; x++)
                for (var y = 0; y < sizeY; y++)
                    array[x + xPos, y + yPos] = area[x, y];
        }

        public static string Unfold(this string [ , ] array)
        {
            var builder = new StringBuilder();

            var lenX = array.GetLength(0);
            var lenY = array.GetLength(1);

            for (var y = 0; y < lenY; y++)
                for (var x = 0; x < lenX; x++)
                    builder.Append(array[x, y]);

            return builder.ToString();
        }

        public static void PrintRows(this string[ , ] array)
        {
            var lenX = array.GetLength(0);
            var lenY = array.GetLength(1);

            for (var y = 0; y < lenY; y++)
            {
                for (var x = 0; x < lenX; x++)
                    Console.Write(array[x, y] == "1" ? "0" : " ");
                Console.WriteLine();
            }
        }
    }
}