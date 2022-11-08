# LA1200


Team Racoon 
Jeanneret Winsky, Erismann, Müller, Warnebold, Koch

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
|       | 0.0.1   | Die User Stories wurden erstellt                             |
|       | 0.0.2   | Testfälle erstellt                                           |
|       | 0.0.3   | Planen und entscheiden wurde erstellt                        |
|       | 0.0.4   | Realisieren                                                  |






## 1 Informieren

### 1.1 Ihr Projekt

[Projektbeschreibung](https://youtu.be/dQw4w9WgXcQ)

### 1.2 User Stories
| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1    |    muss   |  funktional  | Als ein Benutzer möchte ich auswählen ob ich mit Deutsch oder Englisch antworte, damit man selber entscheiden kann wie man antworten will |
| 2  |    kann             | funktional      | Als Benutzer möchte ich verschiedene Schwierigkeitsgrade haben, damit ich nicht mit den schwierigsten Wörter beginnen muss                                 |
| 3 | muss |funktional|Als Benutzer möchte ich das meine falschen Antworten gespeichert werden, damit ich die Wörter in der nächsten Runde wieder lernen kann.|
|  4  |    muss             |   funktional   |               Als Benutzer möchte ich das bei einer falschen Eingabe Fehler ausgeben wird, damit  man weiss wann man etwas falsches eingeben hat.                     |
|  5  |        kann      |   funktional   |               Als Benutzer möchte ich das für jede richtige Antwort mir ein Punkt geben wird und die Zeit gespopt wird, damit ich einen Highscores machen kann.|
|  6  |     kann            |   funktional   | Als Benutzer möchte ich, dass mir nach einem Fehler ein kleiner Tipp für das gesuchte Wort gibt, damit es einfacher ist das Wort zu erraten                                   |
|  7  |            muss     |    funktional  |    Als Benutzer möchte zwischen mehreren Sprachen wählen können, damit ich mehrere Sprachen kann lernen.                                |
|  8  |       muss          | funktional     | Als Benutzer möchte ich Wörter automatisch ausgeben lassen, damit man nicht die ganze Zeit das Textdokument öffnen muss      |
| 9 | muss | funktional | Als benutzer möchte ich auswählen können wie viele Wörter man lernen muss |




### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1  | Programm ist gestartet und fragt mit welcher Sprache man antworten will | Englisch | Englisch wurde ausgewählt. |
| 2.1  | Programm läuft und fragt nach schwierigkeit.| einfach | Einfach wurde ausgewählt. |
| 3.1  | Programm läuft und fragt nach Auto. |  Car       |   Richtig!                |
| 4.1  | Programm läuft und fragt ob man noch ein Wort will  |  y      | Programm sucht nächstes Wort            |
| 5.1  | Programm läuft und fragt nach Autobahn  | Carroad |   Falsch !  |
| 6.1  | Programm läuft und fragt ob man noch ein Wort will. |   n      | Programm rechnet prozent aus. |
| 7.1  | Programm läuft und zeigt das man 50% richtig hat.    |   Enter      | Congratulation Sie haben gut gemacht.                 |
| 8.1  | Programm läuft und fragt ob man noch mal lernen will.             |   n      | Programm schliesst.                   |



### 1.4 Diagramme



## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A | 15.11.2022 | Koch | Den benutzer nach der SPrache zum antworten fragen. | 45 |
| 2.A | 15.11.2022 | Erismann | Verschiedene Schwierigkeitsgrade für einfachere und schwierigere Wörter.  | 45 |
| 3.A | 15.11.2022 | Jeanneret Winsky | Falsche antworten speichern und beim nächsten mak nochmal abfragen.  | 45 |
| 4.A | 15.11.2022 | Warnebold | Bei einer falschen Antwort soll eine Fehlerausgabe erscheinen. | 45 | 
| 5.A | 15.11.2022 | Müller | Eine Auswahl bei der man aussuchen kann ob man auf Deutshc oder Englisch antwortet. | 45 | 
| 6.A | 15.11.2022 | Warnebold | Bei fehleingaben soll ein Tipp für das nächste mal gegeben werden | 45 | 
| 7.A | 15.11.2022 | Koch | Andere Sprachen können auch benutzt werden | 45 |
| 8.A | 15.11.2022 | Erismann | Der Benutzer kann Wörter einlesen oder lernen | 45 |
| 9.A | 15.11.2022 | Müller | Der benutzer kann auswählen wie viele Wörter er lernen muss | 45 |



Total: 405


## 3 Entscheiden

Jeder nur so wie er kann.

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
|| 1.A | 01.11.2022 | Koch | 45 | 20 |
| 2.A | 01.11.2022 | Erismann | 45 |70 |
| 3.A | 01.11.2022 | Jeanneret Winsky | 45 | 80|
| 4.A | 01.11.2022 | Warnebold | 45 | 45 |
| 5.A | 01.11.2022 | Müller | 45 | 45|
| 6.A | 08.11.2022 | Warnebold | 45 | 20 |
| 7.A | 08.11.2022 | Koch | 45 | 90 |
| 8.A | 08.11.2022 | Erismann | 45 | 100 |
| 9.A | 08.11.2022 | Müller | 45 | 30 |




## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  |    08.11.2022   |    Stimmt      |   Niclas     |
| 2.A  |    08.11.2022    |          |        |

✍️ Vergessen Sie nicht, ein Fazit hinzuzufügen, welches das Test-Ergebnis einordnet.

### 5.2 Exploratives Testen

| BR-№ | Ausgangslage | Eingabe | Erwartete Ausgabe | Tatsächliche Ausgabe |
| ---- | ------------ | ------- | ----------------- | -------------------- |
| I    |              |         |                   |                      |
| ...  |              |         |                   |                      |

✍️ Verwenden Sie römische Ziffern für Ihre Bug Reports, also I, II, III, IV etc.

## 6 Auswerten
 
✍️ Fügen Sie hier eine Verknüpfung zu Ihrem Lern-Bericht ein..
