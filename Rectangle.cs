// Eric Sällström .NET23

namespace Labb7PolymorphismOOP
{
    internal class Rectangle : Geometry
    {
        public double Width { get; private set; }
        public double Height { get; private set; }

        public Rectangle()
        {
            Width = 5;
            Height = 7;
        }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        protected override string GetGeometricType()
        {
            return base.GetGeometricType();
        }

        public override double Area()
        {
            double area = Width * Height;
            return area;
        }

        public override void PrintCalculations()
        {
            if (Width <= 0 || Height <= 0)
            {
                Console.WriteLine($"*** Calculation incomplete ***" +
                                $"\n===" +
                                $"\nThe base and height of {GetGeometricType()} {Name} " +
                                $"\ncannot be less than or equal to 0!\n" +
                                $"\nPlease try again." +
                                $"\n===\n");
            }
            else if (Width == Height)
            {
                Console.WriteLine($"*** Calculation incomplete ***" +
                                $"\n===" +
                                $"\nThe base and height of {GetGeometricType()} {Name} " +
                                $"\ncannot be of the same size!\n" +
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