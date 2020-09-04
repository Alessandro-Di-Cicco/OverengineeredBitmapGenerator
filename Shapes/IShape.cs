namespace BitmapGenerator.Shapes
{
    public interface IShape
    {
        /// <summary>
        /// Draws the given shape onto the given bitmap matrix
        /// </summary>
        void Draw(string[ , ] bitmap);
    }
}