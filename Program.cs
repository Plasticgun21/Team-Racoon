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
                    Query(1,"Englisch", DeutschEng);

                }
                else if (string.Equals("Deutsch", Input, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Worked!");
                    Query(2,"Deutsch", DeutschEng);
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
                    Query(1,"Französisch", DeutschFranz);

                }
                else if (string.Equals("Deutsch", Input, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Worked!");
                    Query(2,"Deutsch", DeutschFranz);
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

        static void Query(int AnswerLanguage,string Sprache, string FilePath)
        {
            Console.Clear();

            //Sprache = "Englisch"; Sprache wurde schon eingestellt

            //string FilePath = @"C:\Users\nicla\Source\Repos\Team-Racoon\Excel\Deutsch Englisch.CSV";
            string[] Lines = File.ReadAllLines(FilePath);

            string[] EnglischFranz = new string[Lines.Length];
            string[] Deutsch = new string[Lines.Length];
            string[] Markieren = new string[Lines.Length];
            string[] System = new string[Lines.Length];

            int Count = 0;
            string[] Temp = new string[4];

            foreach (string z in Lines)
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

            bool LearningMode = false;
            bool DebugMode = false;

            int TrueCount=0;
            int FalseCount=0;
            int Runs = 0;
            Random random = new Random();

            if (LearningMode == false)
            {
                if (AnswerLanguage == 1)
                {
                    Console.WriteLine("Wie viele Wörter möchtest du lernen?");
                    try
                    {
                       Runs = Convert.ToInt32(Console.ReadLine()); //Error
                    }
                    catch
                    {
                        Console.WriteLine("Unerlaubte Aktion");
                    }

                    Console.Clear();
                    
                    for (int i = 0; i < Runs; i++)
                    {
                        int Rnd = random.Next(Lines.Length);
                        Console.WriteLine($"  Was ist das {Sprache}e Wort für {Deutsch[Rnd]}");
                        string Antwort = Console.ReadLine();

                        if (string.Equals(Antwort, EnglischFranz[Rnd], StringComparison.OrdinalIgnoreCase))
                        {
                            Console.WriteLine(" Richtig!");
                            TrueCount++;
                        }

                        else
                        {
                            Console.WriteLine($" Falsch! Richtig währe {EnglischFranz[Rnd]}");
                            FalseCount++;
                            Lines[Rnd] = $"{Deutsch[Rnd]};{EnglischFranz[Rnd]};{Markieren[Rnd]};x";
                        }
                    }

                    Console.Clear();
                    File.WriteAllLines(FilePath, Lines);
                    for (int i = 6; i >= 1; i--)
                    {
                        Console.WriteLine($"Du hattest {TrueCount} Richig und {FalseCount} Falsch. Nun kannst du die falschen Wörter üben! geht es in {i} sek weiter");
                        Thread.Sleep(1000);
                        Console.Clear();
                    }
                    LearningMode = true;
                }
                else if (AnswerLanguage == 2)
                {
                    Console.WriteLine("Wie viele Wörter möchtest du lernen?");
                    try
                    {
                        Runs = Convert.ToInt32(Console.ReadLine()); //Error
                    }
                    catch
                    {
                        Console.WriteLine("Unerlaubte Aktion");
                    }
                    
                    Console.Clear();

                    for (int i = 0; i < Runs; i++)
                    {
                        int Rnd = random.Next(Lines.Length);
                        Console.WriteLine($"  Was ist das {Sprache}e Wort für {EnglischFranz[Rnd]}");
                        string Antwort = Console.ReadLine();

                        if (string.Equals(Antwort, Deutsch[Rnd], StringComparison.OrdinalIgnoreCase))
                        {
                            Console.WriteLine(" Richtig!");
                            TrueCount++;
                        }

                        else
                        {
                            Console.WriteLine($" Falsch! Richtig währe {Deutsch[Rnd]}");
                            FalseCount++;
                            Lines[Rnd] = $"{Deutsch[Rnd]};{EnglischFranz[Rnd]};{Markieren[Rnd]};x";
                        }
                    }

                    Console.Clear();
                    File.WriteAllLines(FilePath, Lines);
                    for (int i = 6; i >= 1; i--)
                    {
                        Console.WriteLine($"Du hattest {TrueCount} Richig und {FalseCount} Falsch. Nun kannst du die falschen Wörter üben! geht es in {i} sek weiter");
                        Thread.Sleep(1000);
                        Console.Clear();
                    }
                    LearningMode = true;
                }
                
            }

            if(LearningMode)
            {
                Count = 0;
                string[] Lines2 = File.ReadAllLines(FilePath);

                foreach (string z in Lines2)
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
                            File.WriteAllLines(FilePath, Lines2);
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

                        if (AnswerLanguage == 1)
                        {
                            Console.WriteLine($"  Was ist das {Sprache}e Wort für {Deutsch[temp[i]]}");
                            string Antwort = Console.ReadLine();

                            if (string.Equals(Antwort, EnglischFranz[temp[i]], StringComparison.OrdinalIgnoreCase))
                            {
                                Console.WriteLine(" Richtig!");
                                TrueCount++;
                                //x von der liste entfernen
                                Lines2[temp[i]] = $"{Deutsch[temp[i]]};{EnglischFranz[temp[i]]};{Markieren[temp[i]]};";
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
                        else if (AnswerLanguage == 2)
                        {
                            Console.WriteLine($"  Was ist das {Sprache}e Wort für {EnglischFranz[temp[i]]}");
                            string Antwort = Console.ReadLine();

                            if (string.Equals(Antwort, Deutsch[temp[i]], StringComparison.OrdinalIgnoreCase))
                            {
                                Console.WriteLine(" Richtig!");
                                TrueCount++;
                                //x von der liste entfernen
                                Lines2[temp[i]] = $"{Deutsch[temp[i]]};{EnglischFranz[temp[i]]};{Markieren[temp[i]]};";
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

