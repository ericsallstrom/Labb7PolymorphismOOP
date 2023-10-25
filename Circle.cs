// Eric Sällström .NET23

using System.Text;
using System.Xml.Linq;

namespace Labb7PolymorphismOOP
{
    // Circle-klassen ärver från Geometry-klassen.
    internal class Circle : Geometry
    {
        /* Publik egenskap med set-funktionen satt till privat
         * eftersom jag inte vill att värdet skall kunna ändras
         * efter instansiering av ett objekt. Men användaren skall
         * fortfarande kunna erhålla och använda värdet, därav är
         * get-funktionen publik, vilket också är standard.*/
        public double Radius { get; private set; }

        // Publik bas-konstruktor där "Radius" tilldelas ett defaultvärde.        
        public Circle()
        {            
            Radius = 5;            
        }

        /* Publik överlagrad konstruktor som även gör det möjligt för 
         * användaren att mata in ett eget värde, som sedan tilldelas 
         * till "Radius", vid instansieringen av ett Circle-objekt.*/
        public Circle(double radius)
        {
            Radius = radius;           
        }

        // Publik överskuggad metod som returnerar arean av en cirkel.
        public override double Area()
        {
            double area = _pi * Math.Pow(Radius, 2);
            return area;
        }

        /* Publik överskuggad metod som först kollar om "Radius" är 
         * mindre än eller lika med 0. Om så är fallet skrivs ett 
         * felmeddelande ut att beräkningen ej kunde genomföras. 
         * Annars skrivs beräkningen av cirkelns area ut.*/
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