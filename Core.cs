using System;

namespace BitmapGenerator
{
    class Core
    {
        public static void Main(string[] args)
        {
            var generator = new Generator();
            var bitmap = Canvas.GetCanvas();
            var digits = new int[4];

            var num = Console.ReadLine();

            for (var i = 0; i < 4; i++)
                digits[i] = (int) char.GetNumericValue(num[i]);

            // Digits setting
            bitmap.SetArea(generator.GenerateDigit(DigitShapes.GetDigitShapes(digits[0])), 0, 0);
            bitmap.SetArea(generator.GenerateDigit(DigitShapes.GetDigitShapes(digits[1])), 4, 0);
            bitmap.SetArea(generator.GenerateDigit(DigitShapes.GetDigitShapes(digits[2])), 10, 0);
            bitmap.SetArea(generator.GenerateDigit(DigitShapes.GetDigitShapes(digits[3])), 14, 0);

            bitmap.PrintRows();
            
            Console.WriteLine("\nnon-formatted version:");
            Console.WriteLine(bitmap.Unfold());
        }
    }
}
