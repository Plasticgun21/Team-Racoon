using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Beispiel_Code
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string wordsPath = @"C:\Users\kochl\Desktop\IMS\BBB\Programmier Projekt\Datei.txt";
            string[] words = File.ReadAllLines(wordsPath);
          
            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i]);
                Thread.Sleep(1000);
            }
            
        }
    }
}