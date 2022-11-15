# Lern-Bericht
Team Racoon Jeanneret Winsky, Erismann, Müller, Warnebold, Koch

## Einleitung
In unserem Projekt mussten wir einen Vocitrainer programmieren.

## Was habe ich gelernt?
Wir haben gelernt wie man Live-Share funktion auf Visual Studios benuzt,
damit wir alle zusammen auf Visual Studios programmieren können.

## Beschreibung

```CSHARP
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
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
            }
            Console.Read();

 


        }
    }
}
 
```


✍️ Verwenden Sie drei verschiedene Medien, um zu zeigen, was Sie gelernt haben. Zum Beispiel:


* Ein deutliches, aussagekräftiges Bild oder eine kommentierte Bildschirm-Aufnahme
* Ein gut dokumentierter Code-Fetzen
* Ein Link zu einem *selbst aufgenommenen* youtube-Video oder `.gif`.

## Verifikation

✍️ Erklären Sie kurz und bündig, inwiefern die von Ihnen verwendeten Medien zeigen, was Sie gelernt haben.
Im Gif sieht man gut

# Reflexion zum Arbeitsprozess

👍 Wir konnten unseren funktionierenden Code rechtzeitig fertigstellen, was uns schon ein bisschen stolz gemacht hat. 
👍 Wir konnten konzentriert arbeiten und kamen auch schnell voran.    

👎 Die Rollenverteilung war nicht ideal. Unser Teamchef war schlecht gewählt, da er nichts gemacht hat, keine Ahnung hatte was wir machen und nie mitgemacht hat. 
👎Wir haben zu viel Zeit mit der Projektdokumentation gebraucht. 
👎Unser Teamchef war Jeanneret Winsky

**VBV**: ✍️ Formulieren Sie davon ausgehend einen *handelbaren* Verbesserungsvorschlag.
