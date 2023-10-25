// Eric Sällström .NET23

namespace Labb7PolymorphismOOP
{
    // Square-klassen ärver från Geometry-klassen.
    internal class Square : Geometry
    {
        /* Publik egenskap med set-funktionen satt till privat
         * eftersom jag inte vill att värdet skall kunna ändras
         * efter instansiering av ett objekt. Men användaren skall
         * fortfarande kunna erhålla och använda värdet, därav är
         * get-funktionen publik, vilket också är standard.*/
        public double Sides { get; private set; }

        public Square()
        {
            Sides = 10;
        }

        public Square(double sides)
        {
            Sides = sides;
        }

        public override double Area()
        {
            double area = Sides * 2;
            return area;
        }

        public override void PrintCalculations()
        {
            if (Sides <= 0)
            {
                Console.WriteLine($"*** Calculation incomplete ***" +
                                $"\n===" +
                                $"\nThe sides of {GetGeometricType()} {Name} " +
                                $"\n cannot be less than or equal to 0!\n" +
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