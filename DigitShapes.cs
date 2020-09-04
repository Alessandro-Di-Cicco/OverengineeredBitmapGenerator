using BitmapGenerator.Shapes;
using System.Collections.Generic;
using System;

namespace BitmapGenerator
{
    public static class DigitShapes
    {
        private static IShape[][] digits = {
            // Zero
            new[] { new VerticalLine(1, 1, 3) },

            // One
            new IShape[] {
                new Point(0, 0),
                new VerticalLine(2, 0, 4),
                new VerticalLine(0, 2, 2)
            },

            // Two
            new[] {
                new HorizontalLine(1, 0, 2),
                new HorizontalLine(3, 1, 2)
            },

            // Three
            new[] {
                new HorizontalLine(1, 0, 2),
                new HorizontalLine(3, 0, 2)
            },

            // Four
            new IShape[] {
                new VerticalLine(1, 0, 2),
                new Rectangle(0, 3, 2, 2)
            },

            // Five
            new[] {
                new HorizontalLine(1, 1, 2),
                new HorizontalLine(3, 0, 2)
            },

            // Six
            new IShape[] {
                new Point(1, 3),
                new Rectangle(1, 0, 2, 2)
            },

            // Seven
            new[] {
                new Rectangle(0, 1, 2, 4)
            },

            // Eight
            new[] {
                new Point(1, 1),
                new Point(1, 3)
            },

            // Nine
            new IShape[] {
                new Point(1, 1),
                new Rectangle(0, 3, 2, 2)
            }
        };

        public static IEnumerable<IShape> GetDigitShapes(int digit)
        {
            return digits[digit];
        }
    }
}