// Eric Sällström .NET23

namespace Labb7PolymorphismOOP
{
    internal class Ellipse : Geometry
    {
        public double MajorRadius { get; set; }
        public double MinorRadius { get; set; }

        public Ellipse()
        {
            MajorRadius = 8;
            MinorRadius = 4;
        }

        public Ellipse(double majorRadius, double minorRadius)
        {
            MajorRadius = majorRadius;
            MinorRadius = minorRadius;
        }

        public override double Area()
        {
            double area = _pi * MajorRadius * MinorRadius;
            return area;
        }

        public override void PrintCalculations()
        {
            if (MajorRadius <= 0 || MinorRadius <= 0)
            {
                Console.WriteLine($"*** Calculation incomplete ***" +
                              $"\n===" +
                              $"\nThe major and minor radius of {GetGeometricType()} {Name} " +
                              $"\n cannot be less than or equal to 0!\n" +
                              $"\nPlease try again." +
                              $"\n===\n");
            }
            else if (MajorRadius == MinorRadius)
            {
                Console.WriteLine($"*** Calculation incomplete ***" +
                               $"\n===" +
                               $"\nThe major and minor radius of {GetGeometricType()} {Name} " +
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