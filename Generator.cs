using System.Collections.Generic;
using BitmapGenerator.Shapes;

namespace BitmapGenerator
{
    public class Generator
    {
        private string[ , ] blueprint;

        public Generator()
        {
            GenerateBlueprint();
        }

        public string[ , ] GenerateDigit(IEnumerable<IShape> shapes)
        {
            var digit = GetBlank();

            foreach (var shape in shapes)
                shape.Draw(digit);

            return digit;
        }

        private void GenerateBlueprint()
        {
            blueprint = new string[3, 5];

            for (var x = 0; x < 3; x++)
            {
                for (var y = 0; y < 5; y++)
                {
                    blueprint[x, y] = "1";
                }
            }
        }

        private string[ , ] GetBlank()
        {
            return blueprint.Clone() as string[ , ];
        }
    }
}