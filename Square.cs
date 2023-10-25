// Eric Sällström .NET23

namespace Labb7PolymorphismOOP
{
    // Square-klassen ärver från Geometry-klassen.
    internal class Square : Geometry
    {
        /* För Square-klassen krävs en egenskap som representerar 
         * en fyrkants alla sidor för att kunna beräkna arean.
         * "Sides" är en publik egenskap med set-funktionen satt till 
         * privat eftersom värdet bör ej kunna ändras efter
         * instansiering av ett objekt. Men användaren skall
         * fortfarande kunna erhålla och använda värdet, därav är
         * get-funktionen publik, vilket också är standard. */
        public double Sides { get; private set; }

        // Publik bas-konstruktor där "Sides" tilldelats ett defaultvärde.
        public Square()
        {
            Sides = 10;
        }

         /* Publik överlagrad konstruktor som gör det möjligt för 
          * användaren att mata in ett eget värde, som sedan tilldelas 
          * till "Sides", vid instansieringen av ett Square-objekt. */
        public Square(double sides)
        {
            Sides = sides;
        }

        // Publik överskuggad metod som returnerar arean av en 
        // fyrkant och är disponibel även utanför klassen.
        public override double Area()
        {
            double area = Sides * 2;
            return area;
        }

        /* Publik överskuggad metod i vilken en if-sats först kontrollerar 
         * om "Sides" är mindre eller lika med 0. Om så är fallet 
         * skrivs ett felmeddelande ut att beräkningen ej kunde 
         * genomföras. Annars skrivs beräkningen av fyrkantens area ut. */
        public override void PrintCalculation()
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