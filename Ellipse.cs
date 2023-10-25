// Eric Sällström .NET23

namespace Labb7PolymorphismOOP
{
    // Ellipse-klassen ärver från Geometry-klassen.
    internal class Ellipse : Geometry
    {
        /* För Ellipse-klassen krävs två egenskaper som representerar 
         * en ellips "halva storaxel" och "halva lillaxel" för att 
         * kunna beräkna arean. "MajorRadius" och "MinorRadius" är 
         * två publika egenskaper med set-funktionen satt till privat 
         * eftersom värdet bör ej kunna ändras efter instansiering 
         * av ett objekt. Men användaren skall fortfarande kunna 
         * erhålla och använda värdet, därav är get-funktionen 
         * publik, vilket också är standard. */
        public double MajorRadius { get; private set; } // Halva storaxel
        public double MinorRadius { get; private set; } // Halva lillaxel

        // Publik bas-konstruktor där respektive egenskap tilldelats ett defaultvärde.
        public Ellipse()
        {
            MajorRadius = 8;
            MinorRadius = 4;
        }

         /* Publik överlagrad konstruktor som gör det möjligt för 
          * användaren att mata in två egna värden, som sedan 
          * tilldelas till "MajorRadius", respektive "MinorRadius" 
          * vid instansieringen av ett Ellipse-objekt. */
        public Ellipse(double majorRadius, double minorRadius)
        {
            MajorRadius = majorRadius;
            MinorRadius = minorRadius;
        }

        // Publik överskuggad metod som returnerar arean av
        // en ellips och är disponibel även utanför klassen.
        public override double Area()
        {
            double area = _pi * MajorRadius * MinorRadius;
            return area;
        }

        /* Publik överskuggad metod i vilken en if-sats först kontrollerar 
         * om antingen "MajorRadius" eller "MinorRadius" är mindre eller 
         * lika med 0. Om så är fallet skrivs ett felmeddelande ut att
         * beräkningen ej kunde genomföras. Sen prövas om variablerna
         * har exakt likadant värde, vilket i sådana fall leder till att 
         * ett annat felmeddelande skrivs ut. Om inget av de två villkoren 
         * stämmer skrivs beräkningen av ellipsens area ut. */
        public override void PrintCalculation()
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