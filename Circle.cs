// Eric Sällström .NET23

using System.Xml.Linq;

namespace Labb7PolymorphismOOP
{
    internal class Circle : Geometry
    {
        public double Radius { get; private set; }

        public Circle()
        {            
            Radius = 5;            
        }

        public Circle(double radius)
        {
            Radius = radius;           
        }

        protected override string GetGeometricType()
        {
            return base.GetGeometricType();
        }

        public override double Area()
        {
            double area = _pi * Math.Pow(Radius, 2);
            return area;
        }

        public override void PrintCalculations()
        {
            if (Radius <= 0)
            {
                Console.WriteLine($"*** Calculation incomplete ***" +
                                $"\n===" +
                                $"\nThe radius of a {GetGeometricType()} {Name} cannot" +
                                $"\nbe less than or equal to 0!\n" +
                                $"\nPlease try again." +
                                $"\n===\n");
            }
            else
            {
                Console.WriteLine($"*** {GetGeometricType()} {Name} ***" +
                                $"\n===" +
                                $"\nArea:\t{Area():N2} cm²" +
                                $"\n===\n");
            }
        }
    }
}