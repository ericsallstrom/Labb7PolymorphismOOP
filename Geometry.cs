// Eric Sällström .NET23

namespace Labb7PolymorphismOOP
{
    /* Geometry-klassen är abstrakt eftersom jag inte vill
     * att man skall kunna instansiera ett objekt av klassen.
     * Dessutom är den basklass åt de övriga underklasserna. */
    internal abstract class Geometry
    {
        /* Ett skyddat fält som endast kan nås i denna 
         * klass och underklasserna. Fältet har tilldelats 
         * värdet av Math.PI och är även satt till "const" 
         * eftersom värdet ej skall kunna ändras. */
        protected const double _pi = Math.PI;

        /* Privat statiskt fält som tilldelats första
         * bokstaven i alfabetet som värde. Detta fält
         * nås endast inom denna klass. */
        private static char _name = 'a';

        /* Skyddad statisk egenskap som returnerar värdet till
         * den privata _name-variabeln och samtidigt ökar värdet av 
         * char-variabeln successivt vid varje nytt objekt som skapas, 
         * dvs. a => b => c osv. Egenskapen har ingen set-funktion
         * eftersom objektets namn skall ej gå att ändra.
         * Värdet tilldelas objektet automatiskt vid instansiering. */
        protected static char Name { get { return _name++; } }

        /* En skyddad metod som används för att bort 
         * "Labb7PolymorphismOOP." från klassnamnet och 
         * endast generera namnet för det geometriska objekt
         * som skapas från respektive klass. Används endast 
         * för estetiskt skäl när programmet skriver till 
         * konsolen och för att jag ville testa att leka runt 
         * med olika sträng-metoder. */
        protected string GetGeometricType()
        {
            string type = GetType().ToString();
            string geometricType = type.Remove(0, 21);
            return geometricType;
        }

        /* Två publika abstrakta metoder utan kropp som 
         * underklasserna måste tillämpa och dess åtkomst 
         * är även nåbar utanför bas- och underklasserna. */
        public abstract double Area();

        public abstract void PrintCalculation();
    }
}