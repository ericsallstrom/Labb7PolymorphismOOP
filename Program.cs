// Eric Sällström .NET23

using System.Reflection.Metadata;

namespace Labb7PolymorphismOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Nedan har jag skapat en lista kallad "shapes" av typen Geometry, i vilken jag
             * instansierar ett antal olika geometriska objekt från respektive klass. Första 
             * objektet av varje enskild underklass använder defaultvärdet som tilldelats 
             * egenskapen i bas-konstruktorn. I det andra objektet av varje underklass har 
             * jag själv matat in värdet. */
            List<Geometry> shapes = new()
            {
                new Circle(), new Circle(radius: 7),
                new Square(), new Square(sides: 9),
                new Ellipse(), new Ellipse(majorRadius: 6, minorRadius: 3),
                new Rectangle(), new Rectangle(width: 4, height: 5),
                new Parallellogram(), new Parallellogram(width: 5, height: 3),
            };

            /* Använder en foreach-loop som itererar över varje objekt i listan
             * med referens till Geometry-klassen. Med variabeln "shape" kan
             * jag sedan kalla på metoden PrintCalculation() som skriver ut 
             * respektive objekts area. */
            foreach (Geometry shape in shapes)
            {
                shape.PrintCalculation();
            }
        }
    }
}