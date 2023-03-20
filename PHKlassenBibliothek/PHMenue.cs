﻿using Figgle;

namespace PHKlassenBibliothek
{
    public class PHMenue
    {
        public static void PH_Menue()
        {
            bool Exit = false;

            do
            {

                (int, int) cPosBM = Console.GetCursorPosition();

                Console.WriteLine();

                //ASCII art Logo wird erzeugt.
                Console.WriteLine
                    (FiggleFonts.Slant.Render("FOIMultiTool"));

                //Konsolentitel wird geändert.
                Console.Title = "FOIMultiTool";

                Console.WriteLine("------------------------------------------------------------------------------------\n" +
                                  "                              >>> Hauptmenü <<<\n" +
                                  "------------------------------------------------------------------------------------\n\n");

                Console.WriteLine("Eingabe: exit\t->\tbeendet das Programm");

                //Beschreibung der Software.
                Console.WriteLine("\n\nMit der Software 'FOIMulti-Tool' sollen wiederkehrende oder besonders aufwendige\n" +
                                  "Aufgabenaus dem schulischen Kontext erleichtert oder gelöst werden. Diese Aufgaben\n" +
                                  "ergeben sich aus den Problemstellungen aus dem Unterricht der Berufsfachschule für Technik.\n\n");

                string HauptAusw;


                //Eingabeaufforderung 
                Console.WriteLine("Wählen Sie eine der folgenden Themenbereiche:\n");
                Console.WriteLine("\te - Elektrotechnik");
                Console.WriteLine("\ti - Informatik");
                Console.WriteLine("\tm - Mathematik");
                Console.WriteLine("\tp - Physik");
                Console.WriteLine("\tw - Wirtschaft\n");
                Console.Write("Eingabe:");
                HauptAusw = Console.ReadLine().ToLower();

                switch (HauptAusw)
                {
                    case "e":
                        Console.Clear();
                        //Hier das Etechnikmenü aufrufen
                        break;

                    case "i":
                        Console.Clear();
                        //Hier das Informationstechnikmenü aufrufen
                        break;

                    case "m":
                        Console.Clear();
                        //Hier das Mathematikmenü aufrufen
                        break;

                    case "p":
                        Console.Clear();
                        //Hier das Physikmenü aufrufen
                        bool subexit = false;
                        bool neu = true;
                        do
                        {

                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("----------------------------------------------------------------------------------------------------------\n");
                            Console.WriteLine("----             -----      ---      --     -------      ---          ----      ----      ----      ------\n");
                            Console.WriteLine("----     -------   ----    -----    -----     ----     ----    ------------    ------    ----     --------\n");
                            Console.WriteLine("----     -------   ----    -----    ------     --     ----     ------------    ------    --     ----------\n");
                            Console.WriteLine("----     ------   -----    -----    --------       --------      ----------    ------         ------------\n");
                            Console.WriteLine("----            -------             ---------     ------------      ------     ------         ------------\n");
                            Console.WriteLine("----     --------------    -----    ---------     ---------------     ----     ------    --     ----------\n");
                            Console.WriteLine("----     --------------    -----    ---------     -------------      -----     ------    ----     --------\n");
                            Console.WriteLine("----     -------------      ---      --------     -------          ------      ----      ----      -------\n");
                            Console.WriteLine("----------------------------------------------------------------------------------------------------------\n");

                            Console.WriteLine("Willkommen im Themenbereich Physik :)\n" +
                                "Hier bist du genau richtig, wenn du hilfe beim lösen deiner Aufgaben in den unten Aufgelisteten Themenbereichen brauchst.\n" +
                                "Wenn du hier raus willst, kannst du jeder Zeit mit dem Befehl 'subexit' ins Hauptmenü zurückkehrern.\n");

                            Console.WriteLine("----------------------------------------------------");
                            Console.WriteLine("--   Themenbereiche:                              --");
                            Console.WriteLine("----------------------------------------------------");
                            Console.WriteLine("--\t1: Gravitation                            --");                                                        //Untermenü Physik
                            Console.WriteLine("--\t2: Lichtbrechung                          --");
                            Console.WriteLine("--\t3: Lautstärke und Schall                  --");
                            Console.WriteLine("--\t4: Geschwindigkeit                        --");
                            Console.WriteLine("--                                                --");
                            Console.WriteLine("--\tsubexit: Zurück ins Hauptmenü             --");
                            Console.WriteLine("----------------------------------------------------");

                            Console.WriteLine("Eingabe: ");
                            string eingabe = Console.ReadLine();
                            Console.Clear();
                            do
                            {

                                if (eingabe == "1" | eingabe == "2" | eingabe == "3" | eingabe == "4")
                                {
                                    int feature = int.Parse(eingabe);
                                    switch (feature)
                                    {
                                        case 1:
                                            //Feature 1 Danny CallmeBabygirl
                                            break;

                                        case 2:
                                            //Feature 2 Shehan nahehs
                                            break;

                                        case 3:
                                            //Feature 3 Cihan Nextsuki
                                            break;

                                        case 4:
                                            //Feature 4 Simon simqn
                                            break;
                                    }

                                }
                                if (eingabe == "subexit")
                                {
                                    //Zurück zum Hauptmenü
                                    Console.Clear();
                                    Console.WriteLine("Sie kehren jetzt zum Hauptmenü zurück.\nViel Erfolg weiterhin.");
                                    subexit = true;
                                    Console.ReadKey();
                                }

                                else
                                {
                                    //Falsche Eingabe
                                    Console.WriteLine("Das hat nicht geklappt...\nUm fortfahren zu können, geben Sie bitte eine der vier vorgegebenen Zahlen an oder 'subexit' um ins Hauptmenü zurück zu kehren.:)");
                                    neu = false;
                                    Console.ReadKey();
                                }
                            } while (!neu);

                        } while (!subexit);

                        break;

                    case "w":
                        Console.Clear();
                        //Hier das Wirtschaftsmenü aufrufen
                        break;

                    case "exit":
                        Exit = true;
                        break;
                    default:

                        Console.WriteLine("Ungültige Eingabe");
                        Console.ReadKey();

                        (int, int) cPosAM = Console.GetCursorPosition();

                        KonsolenExtrasBibliothek.ConsoleExtras.ClearCurrentConsoleLine(cPosBM.Item2, cPosAM.Item2);

                        break;
                }

            } while (!Exit);
        }
    }
}
