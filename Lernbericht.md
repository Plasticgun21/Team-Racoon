# Lern-Bericht
Team Racoon Jeanneret Winsky, Erismann, Koch, Müller, Warnebold

## Einleitung
In unserem Projekt mussten wir einen Vocitrainer programmieren.

## Was habe ich gelernt?
Wir haben gelernt wie man Dateien ein und auslesen kann. Dazu habe wir auch Live-Share angewendet um gleichzeitig am Code arbeiten zu können. 

## Beschreibung
Mit dem Einlesen kann man Dateien ohne grossen Aufwand in ein Programm einfügen und benutzen. So kann man den Benutzer Wörter abfragen und diese mit den richtigen Wörtern vergleichen. Wenn man eine Datei eingelesen hat, kann man Wörter hinzufügen oder löschen, und sie werden automatisch gestrichen oder hinzugefügt. Wie man unten beim Code sieht, wird die Datei eingelesen und dann in ein Array konvertiert. Danach wird die Datei mit for ausgeben und mit Thread.Sleep gibt man die Zeit an wie lange das Programm dauern soll.
 
![Example](https://github.com/Plasticgun21/Team-Racoon/blob/main/ExaplesLernbericht/Example.gif?raw=true)

```CSHARP
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
```

## Verifikation
Text: Im Text wird beschrieben was man mit dem Einlesen ererichen kann und was im Code danach passiert.
Gif: Im Video wird gezeigt was eine eingelesene Datei im Code macht.
Code: Im Code wird eine eingelesene Datei gezeigt.

# Reflexion zum Arbeitsprozess

👍 Wir konnten unseren funktionierenden Code rechtzeitig fertigstellen, was uns schon ein bisschen stolz gemacht hat. 

👍 Wir konnten konzentriert arbeiten und kamen auch schnell voran.


👎 Die Rollenverteilung war nicht ideal. Unser Teamchef war schlecht gewählt, da er nichts gemacht hat, keine Ahnung hatte was wir machen und nie mitgemacht hat.

👎Wir haben zu viel Zeit mit der Projektdokumentation gebraucht. 

👎Unser Teamchef war Jeanneret Winsky

**VBV**: Am Anfang richtig besprechen wer ein guter und zuverlässiger Teamchef ist. Die Projektdokumentation muss laufend geändert werden.
