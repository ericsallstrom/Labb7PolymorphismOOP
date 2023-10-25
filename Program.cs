// Eric Sällström .NET23

using System.Reflection.Metadata;

namespace Labb7PolymorphismOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Alla enheter anges i centimeter.
            List<Geometry> shapes = new()
            {
                new Circle(), new Circle(radius: 7),
                new Square(), new Square(sides: 9),
                new Ellipse(), new Ellipse(majorRadius: 5, minorRadius: 3),
                new Rectangle(), new Rectangle(width: 4, height: 5),
                new Parallellogram(), new Parallellogram(width: 5, height: 3)
            };

            foreach (Geometry shape in shapes)
            {
                shape.PrintCalculations();
            }
        }
    }
}