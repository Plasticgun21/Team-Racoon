using System;
using System.IO;
using System.Threading;

namespace Voci_Trainer
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            English();
        }

        static void Selector()
        {
            
            
            
            string Antwort = "Deusch";


            Console.WriteLine("Wollen sie französische Wörter oder englische Wörter lernen?");
            string Antwort0 = Console.ReadLine();
            switch(Antwort0)
            {
                case "englisch":
                    {
                        Console.WriteLine("Wollen sie mit Deutsch oder Englisch Antworten?");
                        try
                        {
                            Antwort = Console.ReadLine();

                        }
                        catch
                        {
                            Console.WriteLine("Falsche Eingabe.");
                            //ApplicationException.Exit();
                        }
                        switch (Antwort)
                        {

                            case "deutsch":
                                break;
                            case "englisch":
                                break;

                            case "Deutsch":
                                break;
                            case "Englisch":
                                break;
                            default:
                                throw new Exception();
                                
                        }
                        break;
                    }

                case "französisch":
                    { Console.WriteLine("Wollen sie mit Deutsch oder Französisch Antworten?");
                    
                        try
                        {
                            Antwort = Console.ReadLine();

                        }
                        catch
                        {
                            Console.WriteLine("Falsche Eingabe.");
                            //ApplicationException.Exit();
                        }
                        switch (Antwort)
                        {

                            case "deutsch":
                                break;
                            case "französisch":
                                break;

                            case "Deutsch":
                                break;
                            case "Französisch":
                                break;
                            default:
                                throw new Exception();
                                
                        }
                        break;
                    }
                case "Französisch":
                    {
                        Console.WriteLine("Wollen sie mit Deutsch oder Französisch Antworten?");

                        try
                        {
                            Antwort = Console.ReadLine();

                        }
                        catch
                        {
                            Console.WriteLine("Falsche Eingabe.");
                            //ApplicationException.Exit();
                        }
                        switch (Antwort)
                        {

                            case "deutsch":
                                break;
                            case "französisch":
                                break;

                            case "Deutsch":
                                break;
                            case "Französisch":
                                break;
                            default:
                                throw new Exception();
                                
                        }
                        break;
                    }
                case "Englisch":
                    {
                        Console.WriteLine("Wollen sie mit Deutsch oder Englisch Antworten?");
                        try
                        {
                            Antwort = Console.ReadLine();

                        }
                        catch
                        {
                            Console.WriteLine("Falsche Eingabe.");
                            //ApplicationException.Exit();
                        }
                        switch (Antwort)
                        {

                            case "deutsch":
                                break;
                            case "englisch":
                                break;

                            case "Deutsch":
                                break;
                            case "Englisch":
                                break;
                            default:
                                throw new Exception();
                                
                        }
                    }
                    break;
            }
           
            
        }

        static void English()
        {
            
            string Sprache = "Englisch";

            string DateiPfad = @"C:\Users\nicla\Source\Repos\Team-Racoon\Excel\Deutsch Englisch.CSV";
            string[] Zeilen = File.ReadAllLines(DateiPfad);

            string[] Englisch = new string[Zeilen.Length];
            string[] Deutsch = new string[Zeilen.Length];
            string[] Markieren = new string[Zeilen.Length];
            string[] System = new string[Zeilen.Length];

            int Count = 0;
            string[] Temp = new string[4];

            foreach (string z in Zeilen)
            {
                Temp = z.Split(';');
                Deutsch[Count] = Temp[0];
                Englisch[Count] = Temp[1];
                Markieren[Count] = Temp[2];
                System[Count] = Temp[3];
                Count++;

            }

            foreach (string z in Englisch)
            {
                //Console.WriteLine(z);
            }

            bool Lernmodus = false;
            bool DebugMode = false;

            int RichitgCount=0;
            int FalseCount=0;
            Random random = new Random();

            
            
            if (Lernmodus == false)
            {
                Console.WriteLine("Wie viele Wörter möchtest du lernen?");
                int Durchläufe = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                for (int i = 0; i < Durchläufe; i++)
                {
                    int Zuf = random.Next(Zeilen.Length);
                    Console.WriteLine($"  Was ist das {Sprache}e Wort für {Deutsch[Zuf]}");
                    string Antwort = Console.ReadLine();

                    if (string.Equals(Antwort, Englisch[Zuf], StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine(" Richtig!");
                        RichitgCount++;
                    }

                    else
                    {
                        Console.WriteLine($" Falsch! Richtig währe {Englisch[Zuf]}");
                        FalseCount++;
                        Zeilen[Zuf] = $"{Deutsch[Zuf]};{Englisch[Zuf]};{Markieren[Zuf]};x";
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

            if(Lernmodus)
            {
                Count = 0;
                string[] Zeilen2 = File.ReadAllLines(DateiPfad);

                foreach (string z in Zeilen2)
                {
                    Temp = z.Split(';');
                    Deutsch[Count] = Temp[0];
                    Englisch[Count] = Temp[1];
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

                        Console.WriteLine($"  Was ist das {Sprache}e Wort für {Deutsch[temp[i]]}");
                        string Antwort = Console.ReadLine();

                        if (string.Equals(Antwort, Englisch[temp[i]], StringComparison.OrdinalIgnoreCase))
                        {
                            Console.WriteLine(" Richtig!");
                            RichitgCount++;
                            //x von der liste entfernen
                            Zeilen2[temp[i]] = $"{Deutsch[temp[i]]};{Englisch[temp[i]]};{Markieren[temp[i]]};";
                            //wenn es richtig war im Array den wert mit -1 ersetzen, damit es überspringt wird.
                            temp[i] = -1;
                        }

                        else
                        {
                            Console.WriteLine($" Falsch! Richtig währe {Englisch[temp[i]]}");
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

                foreach (int te in temp)
                {
                    //Console.WriteLine(te);
                }
            }
            
        }
    }

}

