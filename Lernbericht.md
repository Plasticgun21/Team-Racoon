# Lern-Bericht
Team Racoon Jeanneret Winsky, Erismann, Koch, Müller, Warnebold

## Einleitung
In unserem Projekt mussten wir einen Vocitrainer programmieren.

## Was habe ich gelernt?
Wir haben gelernt wie man Dateien ein und auslesen kann. Dazu habe wir auch Live-Share angewendet um gleichzeitig am Code arbeiten zu können. 

## Beschreibung
Mit dem Einlesen kann man Datei ohne grossen Aufwand in ein Programm einfügen und benutzen. So kann man den Benutzer Wörter abfragen und diese mit den richtigen Wörtern vergleichen. Wenn man eine Datei eingelesen hat kann man Wörter hinzufügen oder löschen, und sie werden automatisch gestrichen.


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


✍️ Verwenden Sie drei verschiedene Medien, um zu zeigen, was Sie gelernt haben. Zum Beispiel:


* Ein deutliches, aussagekräftiges Bild oder eine kommentierte Bildschirm-Aufnahme
* Ein gut dokumentierter Code-Fetzen
* Ein Link zu einem *selbst aufgenommenen* youtube-Video oder `.gif`.

## Verifikation
Text: Im Text wird erklärt wie eine Datei eingelesen wird. Code: Im Code wird eine eingelesene Datei dargestellt. Gif: Im Gif wird gezeigt welche Datei eingelesen wird und wie sie ausgegeben wird.
 

# Reflexion zum Arbeitsprozess

👍 Wir konnten unseren funktionierenden Code rechtzeitig fertigstellen, was uns schon ein bisschen stolz gemacht hat. 
👍 Wir konnten konzentriert arbeiten und kamen auch schnell voran.    

👎 Die Rollenverteilung war nicht ideal. Unser Teamchef war schlecht gewählt, da er nichts gemacht hat, keine Ahnung hatte was wir machen und nie mitgemacht hat. 
👎Wir haben zu viel Zeit mit der Projektdokumentation gebraucht. 
👎Unser Teamchef war Jeanneret Winsky

VBV: Am Anfang richtig besprechen wer ein guter und zuverlässiger Teamchef ist. Die Projektdokumentation muss laufend geändert werden.