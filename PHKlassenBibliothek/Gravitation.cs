using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHKlassenBibliothek
{
    internal class Gravitation
    {
        internal static void Feature1_Gravitation()
        {
            bool leave = false;
            do
            {
                Console.Clear();
                Console.Title = "Gravitation\n";
                Console.WriteLine("Das ist der Themenbereich Gravitation und ihre Kräfte.\n" +
                    "Hier können Sie lernen und oder Rechnungen aus diesem Themenbereich durchführen lassen.\n" +
                    "Viel Spaß:)\n\n");
                Console.WriteLine("Um zurück ins Untermenü Physik zu kommen geben Sie 'leave' ein.\n");
                Console.WriteLine("Wie wollen Sie fortfahren?");
                Console.WriteLine("1. Informationen");
                Console.WriteLine("2. Rechner");
                Console.WriteLine("leave. Zurück zum Untermenü Physik");
                Console.WriteLine("-------------------------------------------------------------------");
                Console.WriteLine("Geben Sie eine der angegebenen Zahlen an");
                string eingabe_1 = Console.ReadLine();
                if (eingabe_1 == "1" | eingabe_1 == "2")
                {
                    int ieingabe_1 = int.Parse(eingabe_1);
                    switch (ieingabe_1)
                    {
                        case 1:
                            //Informationen Gravitation
                            break;
                        case 2:
                            //Rechner
                            break;
                    }
                }
                else if (eingabe_1 == "leave")
                {
                    //Zurück ins Untermenü PH
                    Console.WriteLine("Ich hoffe es hat ihnen gefallen\nTschüss");
                    leave = true;
                    Console.ReadKey();
                }
                else
                {
                    //Erneute Eingabeaufforderung, wegen falscher Eingabe
                    Console.WriteLine("Falsche Eingabe erkannt.\nBitte eine der Angegebenen Zahlen eingeben um fortfahren zu können\n");
                    Console.ReadKey();
                }
            } while (!leave);
        }
    }
}
