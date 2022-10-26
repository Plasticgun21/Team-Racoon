using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VociTrainerLA1200
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Modus;

            Intro();
            Console.WriteLine("Möchten sie Wörter einlesen oder ausgeben?");
            while (true)
            {
                Modus = Console.ReadLine();
                if (Modus == "einlesen")
                {
                    Einlesen();
                    break;
                }
                else if (Modus == "ausgeben")
                {
                    Ausgeben();
                    break;
                }
                else
                {
                    Console.WriteLine("ungültige Aktion");
                }
            }
        }

        static void Intro()
        {
            Console.WriteLine("Intro Text");
        }

        static void Ausgeben()
        {
            string DateiPfad = @"C:\Sprachen\Franz.txt";
            string[] Zeilen = File.ReadAllLines(DateiPfad);

            for(int i = 0; i < Zeilen.Length; i++)
            {
                Console.WriteLine(Zeilen[i]);
            }
        }
        static void Einlesen()
        {
            string Französisch;
            string Deutsch;
            int ZeilenLänge;

            string DateiPfad = @"C:\Sprachen\Franz.txt";
            string[] Zeilen = File.ReadAllLines(DateiPfad);

            Console.Write("Französisches Wort: ");
            Deutsch = Console.ReadLine();
            //ZeilenLänge = Zeilen
            //Zeilen[] =
                
        }
    }
}
