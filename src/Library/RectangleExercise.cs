using System.Text;

namespace Exercises;

/// <summary>
/// This class represents an rectangle, that can be printed in console.
/// </summary>
public class RectangleExercise
{
    public int Width { get; private set; }
    public int Length { get; private set; }

    /// <summary>
    /// Initializes an instance of <see cref="RectangleExercise"/> class.
    /// </summary>
    /// <param name="width">Rectangle's wide.</param>
    /// <param name="length">Rectangle's large.</param>
    public RectangleExercise(int width, int length)
    {
        this.Width = width;
        this.Length = length;
    }

    public string PrintRectangle()
    {
        StringBuilder resultToBePrinted = new StringBuilder();

        // Draw the top length of the rectangle.
        resultToBePrinted.Append('X', this.Width).AppendLine();

        // Draw the mid-part of the rectangle.
        for (int length = 0; length < this.Length; length++)
        {
            resultToBePrinted.Append("x").Append(' ', this.Length - 2).Append("x").AppendLine();
        }

        // Draw the bottom length of the rectangle.
        resultToBePrinted.Append('X', this.Width);

        return resultToBePrinted.ToString();
    }
}
