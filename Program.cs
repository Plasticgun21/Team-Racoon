using System;
using System.ComponentModel.Design.Serialization;
using System.IO;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;

namespace Voci_Trainer
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Selector();
        }


        static void Selector()
        {
            //string DeutschEng = @"C:\Users\nicla\Source\Repos\Team-Racoon\Excel\Deutsch Englisch.CSV";
            //string DeutschFranz = @"C:\Users\nicla\Source\Repos\Team-Racoon\Excel\Deutsch Französisch.CSV";

            string DeutschEng = "Deutsch Englisch.CSV";
            string DeutschFranz = "Deutsch Französisch.CSV";


            Console.WriteLine("Wollen sie französische Wörter oder englische Wörter lernen?");
            string Input = Console.ReadLine();

            if (string.Equals("Englisch", Input, StringComparison.OrdinalIgnoreCase))
            {

                Console.WriteLine("Wollen sie auf englisch oder deutsch Antworten?");
                Input = Console.ReadLine();

                if (string.Equals("Englisch", Input, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Worked!");
                    Abfragen(1,"Englisch", DeutschEng);

                }
                else if (string.Equals("Deutsch", Input, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Worked!");
                    Abfragen(2,"Deutsch", DeutschEng);
                }
                else
                {
                    Console.WriteLine("Sie haben eine falsche Eingabe eingeben.");
                    Console.WriteLine("Das Programm wird beendet.");
                    Environment.Exit(1);
                }
            }
            else if (string.Equals("Französisch", Input, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Wollen sie auf französisch oder deutsch Antworten?");
                Input = Console.ReadLine();

                if (string.Equals("Französisch", Input, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Worked!");
                    Abfragen(1,"Französisch", DeutschFranz);

                }
                else if (string.Equals("Deutsch", Input, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Worked!");
                    Abfragen(2,"Deutsch", DeutschFranz);
                }
                else
                {
                    Console.WriteLine("Sie haben eine falsche Eingabe eingeben.");
                    Console.WriteLine("Das Programm wird beendet.");
                    Environment.Exit(1);
                }

            }
            else
            {
                Console.WriteLine("Sie haben eine falsche Eingabe eingeben.");
                Console.WriteLine("Das Programm wird beendet.");
                Environment.Exit(1);
            }

          


        }

        static void Abfragen(int AntwortSprache,string Sprache, string DateiPfad)
        {
            Console.Clear();

            //Sprache = "Englisch"; Sprache wurde schon eingestellt

            //string DateiPfad = @"C:\Users\nicla\Source\Repos\Team-Racoon\Excel\Deutsch Englisch.CSV";
            string[] Zeilen = File.ReadAllLines(DateiPfad);

            string[] EnglischFranz = new string[Zeilen.Length];
            string[] Deutsch = new string[Zeilen.Length];
            string[] Markieren = new string[Zeilen.Length];
            string[] System = new string[Zeilen.Length];

            int Count = 0;
            string[] Temp = new string[4];

            foreach (string z in Zeilen)
            {
                Temp = z.Split(';');
                Deutsch[Count] = Temp[0];
                EnglischFranz[Count] = Temp[1];
                Markieren[Count] = Temp[2];
                System[Count] = Temp[3];
                Count++;

            }

            foreach (string z in EnglischFranz)
            {
                //Console.WriteLine(z);
            }

            bool Lernmodus = false;
            bool DebugMode = false;

            int RichitgCount=0;
            int FalseCount=0;
            int Durchläufe = 0;
            Random random = new Random();

            if (Lernmodus == false)
            {
                if (AntwortSprache == 1)
                {
                    Console.WriteLine("Wie viele Wörter möchtest du lernen?");
                    try
                    {
                       Durchläufe = Convert.ToInt32(Console.ReadLine()); //Error
                    }
                    catch
                    {
                        Console.WriteLine("Unerlaubte Aktion");
                    }

                    Console.Clear();
                    
                    for (int i = 0; i < Durchläufe; i++)
                    {
                        int Zuf = random.Next(Zeilen.Length);
                        Console.WriteLine($"  Was ist das {Sprache}e Wort für {Deutsch[Zuf]}");
                        string Antwort = Console.ReadLine();

                        if (string.Equals(Antwort, EnglischFranz[Zuf], StringComparison.OrdinalIgnoreCase))
                        {
                            Console.WriteLine(" Richtig!");
                            RichitgCount++;
                        }

                        else
                        {
                            Console.WriteLine($" Falsch! Richtig währe {EnglischFranz[Zuf]}");
                            FalseCount++;
                            Zeilen[Zuf] = $"{Deutsch[Zuf]};{EnglischFranz[Zuf]};{Markieren[Zuf]};x";
                        }
                    }

                    Console.Clear();
                    File.WriteAllLines(DateiPfad, Zeilen);
                    for (int i = 6; i >= 1; i--)
                    {
                        Console.WriteLine($"Du hattest {RichitgCount} Richig und {FalseCount} Falsch. Nun kannst du die falschen Wörter üben! geht es in {i} sek weiter");
                        Thread.Sleep(1000);
                        Console.Clear();
                    }
                    Lernmodus = true;
                }
                else if (AntwortSprache == 2)
                {
                    Console.WriteLine("Wie viele Wörter möchtest du lernen?");
                    try
                    {
                        Durchläufe = Convert.ToInt32(Console.ReadLine()); //Error
                    }
                    catch
                    {
                        Console.WriteLine("Unerlaubte Aktion");
                    }
                    
                    Console.Clear();

                    for (int i = 0; i < Durchläufe; i++)
                    {
                        int Zuf = random.Next(Zeilen.Length);
                        Console.WriteLine($"  Was ist das {Sprache}e Wort für {EnglischFranz[Zuf]}");
                        string Antwort = Console.ReadLine();

                        if (string.Equals(Antwort, Deutsch[Zuf], StringComparison.OrdinalIgnoreCase))
                        {
                            Console.WriteLine(" Richtig!");
                            RichitgCount++;
                        }

                        else
                        {
                            Console.WriteLine($" Falsch! Richtig währe {Deutsch[Zuf]}");
                            FalseCount++;
                            Zeilen[Zuf] = $"{Deutsch[Zuf]};{EnglischFranz[Zuf]};{Markieren[Zuf]};x";
                        }
                    }

                    Console.Clear();
                    File.WriteAllLines(DateiPfad, Zeilen);
                    for (int i = 6; i >= 1; i--)
                    {
                        Console.WriteLine($"Du hattest {RichitgCount} Richig und {FalseCount} Falsch. Nun kannst du die falschen Wörter üben! geht es in {i} sek weiter");
                        Thread.Sleep(1000);
                        Console.Clear();
                    }
                    Lernmodus = true;
                }
                
            }

            if(Lernmodus)
            {
                Count = 0;
                string[] Zeilen2 = File.ReadAllLines(DateiPfad);

                foreach (string z in Zeilen2)
                {
                    Temp = z.Split(';');
                    Deutsch[Count] = Temp[0];
                    EnglischFranz[Count] = Temp[1];
                    Markieren[Count] = Temp[2];
                    System[Count] = Temp[3];
                    Count++;

                }

                //Counter wird auf 0 gesetzt und es wird ein Array namens temp erstellt.
                Count = 0;
                
                int[] temp;

                //Es wird im Array System gesucht, ob das zeichen "x" vorhanden ist wenn ja, wird der counter +1 gerechnet.
                foreach (string Mar in System)
                {
                    if(Mar == "x")
                    {
                        Count++;
                    }
                    
                }

                if(Count == 0)
                {
                    Console.WriteLine("Nichts zu Wiederhohlen :)");
                    Environment.Exit(1);
                }

                //Nun wird der Counterwert dem Array zugewisen, der counter auf 0
                //um ihn wieder zu verwenden und es wird noch ein zusätzlicher Counter erstellt.
                temp = new int[Count];
                Count = 0;
                int Count2 = 0;

                //Es wird zuerst im Array System gesucht, ob das zeichen "x" vorhanden ist wenn ja,
                //wird der wert des counters in das Array temp eingeschrieben um bei den anderen arrays das Wort auszulesen.
                foreach (string Mar in System)
                {

                    if (Mar == "x")
                    {
                        temp[Count2] = Count;
                        if (DebugMode)
                        {
                            Console.WriteLine($"{temp[Count2]} Rohe Zahl: {Count} Das Wort dahinter: {Deutsch[Count]}");
                        }
                        Count2++;
                    }
                    Count++;
                }

                Count = 0;
                while (true)
                {
                    //führe solange aus wie das array temp lang ist.
                    for (int i = 0; i < temp.Length; i++)
                    {
                        //überprüfen, ob alle die person alle wörter kennt.
                        foreach (int te in temp)
                        {
                            if(te == -1)
                            {
                                Count++;
                            }
                        }

                        //Ist der Wert Count gleichlang
                        if (Count == temp.Length)
                        {
                            Console.Clear();
                            File.WriteAllLines(DateiPfad, Zeilen2);
                            Console.WriteLine($"Du kannst nun alle {temp.Length} wörter! Sie wurden von der wiederhohl Liste entfernt.");
                            Environment.Exit(1);
                        }
                        Count = 0;

                        //wenn im Array temp der wert -1 gefunden wird, soll es diesen überspringen.
                        while (temp[i] == -1)
                        {
                            i++;
                            if(i == temp.Length)
                            {
                                i = 0;
                            }
                        }

                        if (AntwortSprache == 1)
                        {
                            Console.WriteLine($"  Was ist das {Sprache}e Wort für {Deutsch[temp[i]]}");
                            string Antwort = Console.ReadLine();

                            if (string.Equals(Antwort, EnglischFranz[temp[i]], StringComparison.OrdinalIgnoreCase))
                            {
                                Console.WriteLine(" Richtig!");
                                RichitgCount++;
                                //x von der liste entfernen
                                Zeilen2[temp[i]] = $"{Deutsch[temp[i]]};{EnglischFranz[temp[i]]};{Markieren[temp[i]]};";
                                //wenn es richtig war im Array den wert mit -1 ersetzen, damit es überspringt wird.
                                temp[i] = -1;
                            }

                            else
                            {
                                Console.WriteLine($" Falsch! Richtig währe {EnglischFranz[temp[i]]}");
                                FalseCount++;

                            }
                            if (DebugMode)
                            {
                                foreach (int z in temp)
                                {
                                    Console.WriteLine($" DEBUG {z} -_- {temp[i]}");
                                }
                            }
                        }
                        else if (AntwortSprache == 2)
                        {
                            Console.WriteLine($"  Was ist das {Sprache}e Wort für {EnglischFranz[temp[i]]}");
                            string Antwort = Console.ReadLine();

                            if (string.Equals(Antwort, Deutsch[temp[i]], StringComparison.OrdinalIgnoreCase))
                            {
                                Console.WriteLine(" Richtig!");
                                RichitgCount++;
                                //x von der liste entfernen
                                Zeilen2[temp[i]] = $"{Deutsch[temp[i]]};{EnglischFranz[temp[i]]};{Markieren[temp[i]]};";
                                //wenn es richtig war im Array den wert mit -1 ersetzen, damit es überspringt wird.
                                temp[i] = -1;
                            }

                            else
                            {
                                Console.WriteLine($" Falsch! Richtig währe {Deutsch[temp[i]]}");
                                FalseCount++;

                            }
                            if (DebugMode)
                            {
                                foreach (int z in temp)
                                {
                                    Console.WriteLine($" DEBUG {z} -_- {temp[i]}");
                                }
                            }
                        }
                    }
                    
                    
                }

            }
            
        }
    }

}

