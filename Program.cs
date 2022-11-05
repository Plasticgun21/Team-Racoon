using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

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
            
            string Antwort0;
            string Antwortf;
            string Antwort = "Deusch";


            Console.WriteLine("Wollen sie französische Wörter oder englische Wörter lernen?");
                Antwort0 = Console.ReadLine();
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

            int RichitgCount=0;
            int FalseCount=0;
            Random random = new Random();

            
            if (Lernmodus)
            {
                while (true)
                {
                    int Zuf = random.Next(Zeilen.Length);
                    Console.WriteLine($"Was ist das {Sprache}e Wort für {Deutsch[Zuf]}");
                    string Antwort = Console.ReadLine();

                    if (string.Equals(Antwort, Englisch[Zuf], StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("Richtig!");
                        RichitgCount++;
                    }

                    else
                    {
                        Console.WriteLine($"Falsch! Richtig währe {Englisch[Zuf]}");
                        FalseCount++;
                    }
                }
            }
        }
    }

}

