﻿// Eric Sällström .NET23

using System.Text;
using System.Xml.Linq;

namespace Labb7PolymorphismOOP
{
    // Circle-klassen ärver från Geometry-klassen.
    internal class Circle : Geometry
    {
        /* För Circle-klassen krävs en egenskap som representerar 
         * en cirkels radie för att kunna beräkna arean.
         * "Radius" är en publik egenskap med set-funktionen satt till 
         * privat eftersom värdet bör ej kunna ändras efter
         * instansiering av ett objekt. Men användaren skall
         * fortfarande kunna erhålla och använda värdet, därav är
         * get-funktionen publik, vilket också är standard. */
        public double Radius { get; private set; }

        // Publik bas-konstruktor där "Radius" tilldelas ett defaultvärde.        
        public Circle()
        {            
            Radius = 5;            
        }

        /* Publik överlagrad konstruktor som gör det möjligt för 
         * användaren att mata in ett eget värde, som sedan tilldelas 
         * till "Radius", vid instansieringen av ett Circle-objekt. */
        public Circle(double radius)
        {
            Radius = radius;           
        }

        // Publik överskuggad metod som returnerar arean av en 
        // cirkel och är disponibel även utanför klassen.
        public override double Area()
        {
            double area = _pi * Math.Pow(Radius, 2);
            return area;
        }

        /* Publik överskuggad metod i vilken en if-sats först kontrollerar 
         * om "Radius" är mindre eller lika med 0. Om så är fallet 
         * skrivs ett felmeddelande ut att beräkningen ej kunde 
         * genomföras. Annars skrivs beräkningen av cirkelns area ut. */
        public override void PrintCalculation()
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