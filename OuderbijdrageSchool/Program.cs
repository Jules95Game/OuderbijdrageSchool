using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OuderbijdrageSchool
{
    class Program
    {
        static void Main(string[] args)
        {
            //Titel
            Console.WriteLine("Ouderbijdrage berekenen\n");

            //Constante waarde
            double basisBedrag = 50;
            double kindMin10Jaar = 25;
            double kindPlus10Jaar = 37;
            double maxBijdrage = 150;
            double eenOuderReductie = 0.75;

            //Gezinsgegevens bepalen
            //Aantal kinderen jonger dan 10
            Console.Write("Hoeveel kinderen jonger dan 10 jaar?: ");
            string rawAantalKinderenMin10 = Console.ReadLine();
            int aantalKinderenMin10 = 0;
            while (!int.TryParse(rawAantalKinderenMin10, out aantalKinderenMin10))
            {
                Console.Write("\n" +
                    "Dit is geen geldige invoer.\n" +
                    "Typ alstublieft een geheel getal: ");
                rawAantalKinderenMin10 = Console.ReadLine();
            }
            while (aantalKinderenMin10 < 1)
            {
                rawAantalKinderenMin10 = "Error";
                /*Console.Write("\n" +
                    "Dit is geen geldige invoer.\n" +
                    "Typ alstublieft een geheel getal(minimaal 1): ");*/
                while (!int.TryParse(rawAantalKinderenMin10, out aantalKinderenMin10))
                {
                    Console.Write("\n" +
                        "Dit is geen geldige invoer.\n" +
                        "Typ alstublieft een geheel getal(minimaal 1): ");
                    rawAantalKinderenMin10 = Console.ReadLine();
                }
            }
            //Aantal kinderen ouder dan 10
            Console.Write("Hoeveel kinderen ouder dan 10 jaar?: ");
            string rawAantalKinderenPlus10 = Console.ReadLine();
            int aantalKinderenPlus10 = 0;
            while (!int.TryParse(rawAantalKinderenPlus10, out aantalKinderenPlus10))
            {
                Console.Write("\n" +
                    "Dit is geen geldige invoer.\n" +
                    "Typ alstublieft een geheel getal: ");
                rawAantalKinderenPlus10 = Console.ReadLine();
            }
            while (aantalKinderenPlus10 < 1)
            {
                rawAantalKinderenPlus10 = "Error";
                /*Console.Write("\n" +
                    "Dit is geen geldige invoer.\n" +
                    "Typ alstublieft een geheel getal(minimaal 1): ");*/
                while (!int.TryParse(rawAantalKinderenPlus10, out aantalKinderenPlus10))
                {
                    Console.Write("\n" +
                        "Dit is geen geldige invoer.\n" +
                        "Typ alstublieft een geheel getal(minimaal 1): ");
                    rawAantalKinderenPlus10 = Console.ReadLine();
                }
            }

            //Leeftijd vergelijken en tussenbedrag
            //Kinderen jonger dan 10 jaar
            double bedragOuderbijdrage1 = 0;

            if (aantalKinderenMin10 <= 3)
            {
                bedragOuderbijdrage1 = kindMin10Jaar * aantalKinderenMin10;
            }
            else if (aantalKinderenMin10 > 3)
            {
                bedragOuderbijdrage1 = kindMin10Jaar * 3;
            }
            else
            {
                Console.WriteLine("Error");
            }
            //Kinderen ouder dan 10 jaar
            double bedragOuderbijdrage2 = 0;

            if (aantalKinderenPlus10 <= 2)
            {
                bedragOuderbijdrage2 = kindPlus10Jaar * aantalKinderenPlus10;
            }
            else if (aantalKinderenPlus10 > 2)
            {
                bedragOuderbijdrage2 = kindPlus10Jaar * 2;
            }
            else
            {
                Console.WriteLine("Error");
            }

            //Eénoudergezin?
            Console.Write("Is het gezin een éénoudergezin? y/n: ");
            string eenOuder = Console.ReadLine();

            //Bijdrage berekening
            double bedragOuderbijdrage = bedragOuderbijdrage =
                        basisBedrag
                        + bedragOuderbijdrage1
                        + bedragOuderbijdrage2;
            if (bedragOuderbijdrage > maxBijdrage)
            {
                bedragOuderbijdrage = maxBijdrage;
            }
            while (true)
            {
                if (eenOuder == "n")
                {
                    break;
                }
                else if (eenOuder == "y")
                {
                    bedragOuderbijdrage = bedragOuderbijdrage * eenOuderReductie;
                    break;
                }
                else
                {
                    Console.Write("\n" +
                    "Dit is geen geldige invoer.\n" +
                    "Kies y of n: ");
                    eenOuder = Console.ReadLine();
                }
            }
            //Prijs weergeven
            Console.WriteLine("\nDe totale ouderbijdrage is: {0:N} euro.",
                bedragOuderbijdrage);
            Console.Write("Druk op enter om af te sluiten.");
            Console.ReadLine();
        }
    }
}
