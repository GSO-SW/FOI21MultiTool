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
            bool anziehungskraft_rechner = false;
            bool leave = false;
            string back;
            do
            {               
                Console.Clear();
                Console.Title = "Gravitation\n";

                Console.WriteLine("Das ist der Themenbereich Gravitation und ihre Kräfte.\n" +
                    "Hier können Sie lernen und oder Rechnungen aus diesem Themenbereich durchführen lassen.\n" +
                    "Viel Spaß:)\n\n");

                Console.WriteLine("Um zurück ins Untermenü Physik zu kommen geben Sie 'leave' ein.\n");

                Console.WriteLine("Wie wollen Sie fortfahren?");
                Console.WriteLine("1. Informationen");                                                          //Untermenü Gravitation
                Console.WriteLine("2. Rechner");
                Console.WriteLine("leave. Zurück zum Untermenü Physik\n");

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
                            Console.WriteLine("Informationen\n");

                            Console.WriteLine("-------------------------------------------------------\n");
                            Console.WriteLine("--   Was möchten Sie herausfinden?                   --\n");
                            Console.WriteLine("-------------------------------------------------------\n");
                            Console.WriteLine("--\t1. Was ist überhaupt Gravitation                 --\n");         //Untermenü Information (info)
                            Console.WriteLine("--\t2. Anziehungskraft unterschiedlicher Planeten    --\n");
                            Console.WriteLine("--\t3. Schwerelosigkeit = keine Gravitation?         --\n");
                            Console.WriteLine("--                                                   --\n");
                            Console.WriteLine("-------------------------------------------------------\n");

                            Console.WriteLine("Wenn Sie doch lieber den Rechner benutzen wollen dann geben Sie 'back' ein.\n");

                            Console.Write("Eingabe:");
                            string case1 = Console.ReadLine();
                            int info1;
                            if (case1 == "1" | case1 == "2" | case1 == "3")
                            {
                                info1 = int.Parse(case1);
                                switch (info1)
                                {
                                    case 1:
                                        //Was ist Gravitation
                                        Console.Clear();
                                        Console.WriteLine("Die Gravitation, auch Massenanziehung oder Gravitationskraft, ist eine der vier Grundkräfte der Physik.\n" +
                                                          " Sie äußert sich in der gegenseitigen Anziehung von Massen. Sie nimmt mit zunehmender Entfernung der Massen ab, besitzt \n" +
                                                          "aber unbegrenzte Reichweite. Im Gegensatz zu elektrischen oder magnetischen Kräften lässt sie sich nicht abschirmen.\n");

                                        Console.WriteLine("Auf der Erde bewirkt die Gravitation (Erdanziehungskraft), dass alle Körper nach „unten“, d. h. in Richtung Erdmittelpunkt,\n" +
                                                          "fallen, sofern sie nicht durch andere Kräfte daran gehindert werden. Im Sonnensystem bestimmt die Gravitation die Bahnen der Planeten, Monde,\n" +
                                                          "Satelliten und Kometen und im Kosmos die Bildung von Sternen und Galaxien sowie dessen Entwicklung im Großen.\n");

                                        Console.WriteLine("Gravitation wird oft mit Schwerkraft gleichgesetzt. Allerdings umfasst die vom lokal herrschenden Schwerefeld bestimmte Kraft \n" +
                                                          "auf einen Körper nicht nur die Gravitationskraft, sondern auch die auf den Körper wirkenden Trägheitswirkungen.\n");
                                        Console.WriteLine("Das sind so die wichtigsten Dinge, die man über die Gravitation wissen sollte.\n" +
                                                          "Wenn Sie weitere Dinge erfahren möchten kommen Sie automatisch wieder zum Informations-Menü, wenn Sie fertig mit lernen sind," +
                                                          " kommen Sie mit 'back' zum Untermenü Gravitation zurück.\n");
                                        break;

                                    case 2:
                                        //Anziehungskraft unterschiedlicher Planeten im Sonnensystem
                                        Console.Clear();
                                        Console.WriteLine("Hier ist die Anziehungskraft der verschiedenen Planeten des Sonnensystems aufgelistet, " +
                                                          "mit dem Maßstab der Anziehungskraft von der Erde, welche 1 beträgt.\n");

                                        Console.WriteLine("--------------------------------------");
                                        Console.WriteLine("-- Anziehungskraft im Sonnensystem  --");
                                        Console.WriteLine("--------------------------------------");
                                        Console.WriteLine("--  Merkur        --    0,37        --");
                                        Console.WriteLine("--  Venus         --    0,90        --");
                                        Console.WriteLine("--  Mond          --    0,16        --");
                                        Console.WriteLine("--  Mars          --    0,38        --");
                                        Console.WriteLine("--  Jupiter       --    2,53        --");
                                        Console.WriteLine("--  Saturn        --    1,07        --");
                                        Console.WriteLine("--  Uranus        --    0,91        --");
                                        Console.WriteLine("--  Neptun        --    1,14        --");
                                        Console.WriteLine("--  Pluto         --    0,08        --");
                                        Console.WriteLine("--------------------------------------\n");

                                        Console.WriteLine("Wenn Sie jetzt noch wissen wollen, wieviel Sie Wiegen würden, wenn Sie auf einen dieser Planeten auf einer Waage stehen würden," +
                                            " dann tippen Sie die 1 und wenn Sie zurück ins Untermenü Info wollen, dann geben Sie die zwei ein.\n");

                                        Console.WriteLine("--------------------------------------");
                                        string info2 = Console.ReadLine();
                                        
                                        if (info2 == "1" | info2 == "2")
                                        {
                                            int irechner = int.Parse(info2);
                                            switch (irechner)
                                            {
                                                case 1:
                                                    //Zum Rechner
                                                    Console.Clear();
                                                    anziehungskraft_rechner = true;
                                                    break;

                                                case 2:
                                                    //Zurück zum Untermenü Information
                                                    Console.Clear();
                                                    break;

                                            }
                                        }

                                        break;

                                    case 3:
                                        //Schwerelosigkeit = keine Gravitation?
                                        Console.Clear();
                                        Console.WriteLine("");
                                        break;

                                }
                            }
                            break;

                        case 2:
                            //Rechner
                            Console.Clear();
                            Console.WriteLine("");
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
