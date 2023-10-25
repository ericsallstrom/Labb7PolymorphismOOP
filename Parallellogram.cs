// Eric Sällström .NET23

namespace Labb7PolymorphismOOP
{
    // Parallellogram-klassen ärver från Geometry-klassen.
    internal class Parallellogram : Geometry
    {
        /* För Parallellogram-klassen krävs två egenskaper som representerar 
         * basen och höjden hos en parallellogram för att kunna beräkna dess
         * area. "Width" och "Height" är två publika egenskaper med 
         * set-funktionen satt till privat eftersom värdet bör ej kunna
         * ändras efter instansiering av ett objekt. Men användaren 
         * skall fortfarande kunna erhålla och använda värdet, därav är 
         * get-funktionen publik, vilket också är standard. */
        public double Width { get; private set; }
        public double Height { get; private set; }

        // Publik bas-konstruktor där respektive egenskap tilldelats ett defaultvärde.
        public Parallellogram()
        {
            Width = 7;
            Height = 4;
        }

        /* Publik överlagrad konstruktor som gör det möjligt för 
         * användaren att mata in två egna värden, som sedan 
         * tilldelas till "Width", respektive "Height" 
         * vid instansieringen av ett Parallellogram-objekt. */
        public Parallellogram(double width, double height)
        {
            Width = width;
            Height = height;
        }

        // Publik överskuggad metod som returnerar arean av en
        // parallellogram och är disponibel även utanför klassen.
        public override double Area()
        {
            double area = Width * Height;
            return area;
        }

        /* Publik överskuggad metod i vilken en if-sats först kontrollerar 
         * om antingen "Width" eller "Height" är mindre eller lika
         * med 0. Om så är fallet skrivs ett felmeddelande ut att
         * beräkningen ej kunde genomföras. Sen prövas om variablerna
         * har exakt likadant värde, vilket i sådana fall leder till att 
         * ett annat felmeddelande skrivs ut. Om inget av de två villkoren
         * stämmer skrivs beräkningen av parallellogrammens area ut. */
        public override void PrintCalculation()
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