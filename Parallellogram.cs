// Eric Sällström .NET23

namespace Labb7PolymorphismOOP
{
    internal class Parallellogram : Geometry
    {
        public double Width { get; private set; }
        public double Height { get; private set; }

        public Parallellogram()
        {
            Width = 7;
            Height = 4;
        }

        public Parallellogram(double width, double height)
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
                                $"\nBase and height of {GetGeometricType()} {Name} " +
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