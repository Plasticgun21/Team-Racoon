using System;
using System.Collections.Generic;
using System.Text;

namespace VociTrainerLA1200
{
    internal class DatenEinlesen
    {
        string Englisch;
        string Deutsch;
        int ZeilenLänge;

        string DateiPfad = @"C:\Sprachen\Franz.txt";
        string[] Zeilen = File.ReadAllLines(DateiPfad);
    }
}
