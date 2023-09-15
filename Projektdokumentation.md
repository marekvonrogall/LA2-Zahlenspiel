# Projekt-Dokumentation

Mitglied: Marek von Rogall

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
| 18.08.23      | 0.0.1   |   Dokumentation angefangen und über OOP informiert.                  |
| 25.08.23      | 0.0.2   |   Realisieren                         |
| 01.09.23      | 0.0.3   |   Realisieren                   |
| 08.09.23      | 1.0.0   |   Realisieren abgeschlossen. Dokumentation / Portfolioeintrag begonnen.   |
| 15.09.23      | 1.0.0   |   Dokumentation / Portfolioeintrag abgeschlossen. |

## 1 Informieren

### 1.1 Ihr Projekt

In diesem Projekt möchte ich ein Zahlenspiel erstellen, in welchem der Benutzer eine zufällig generierte Zahl erraten muss. Das Zahlenspiel soll einen Einzel- und Mehrspielermodus enthalten, sowie eine Rangliste.
Ich habe mir vorgenommen eine grafische Benutzeroberfläche zu erstellen, um das Spiel ansprechender zu gestalten.

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ----- | ------- | ----------- |------------------------------------|
| 1  |  muss  |  Funktional  | Als ein Benutzer möchte ich eine Rangliste haben, damit ich mich mit anderen Spielern vergleichen kann. |
| 2  |  muss  |  Funktional  | Als Benutzer möchte ich eine grafische Benutzeroberfläche haben, damit das Spiel ansprechender ist.     |
| 3  |  muss  |  Funktional  | Als Benutzer möchte ich einen Mehrspielermodus haben, damit ich gegen einen Freund spielen kann.        |
| 4  |  kann  |  Qualität    | Als Benutzer möchte ich die Zahlenspannweite der Zufallszahl selber wählen können, um das Spiel schwieriger zu gestalten. |


### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1  |  Spiel gestartet.          | Schaltfläche "Leaderboard" wird gedrückt.        |   Die Rangliste wird angezeigt.               |
| 2.1  |  Spiel gestartet.       | /        |   Das Spiel besitzt eine grafische Benutzeroberfläche.   |
| 3.1  |  Spiel gestartet.            | Schaltfläche "Optionen" wird gedrückt.    |   Die Optionen werden geöffnet und der Benutzer kann auf den Modus "Mehrspieler" wechseln. |
| 4.1  |  Spiel gestartet.            | Schaltfläche "Optionen" wird gedrückt.    |   Die Optionen werden geöffnet und der Benutzer kann auf den Modus "Eigene Zahlenspannweite selber wählen" wechseln und seine eigene Zahlenspannweite eingeben. |

### 1.4 Medien & Diagramme

![Zahlenspiel](https://github.com/marekvonrogall/LA2-Zahlenspiel/assets/110893394/3e638521-fd48-4ac0-bc06-9cc83862aae7)

https://github.com/marekvonrogall/LA2-Zahlenspiel/assets/110893394/b362e3af-e23b-48f2-8b65-dc1cc2e1cfb6

Verifikation:

Das PAP dient zur Veranschaulichung des Ablaufs des Programms.
Das Video dient als Demonstration des Programms.

## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit (min) |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A  |   18.08.23    |  von Rogall         |  Über OOP informieren  |      200         |
| 2.A  |   25.08.23    |  von Rogall         |  Klassen erstellen      |      10        |
| 3.A  |   25.08.23    |  von Rogall         |  Form designen     |     90          |
| 4.A  |   25.08.23    |  von Rogall         |  Elemente benennen & Events hinzufügen       |     30          |
| 5.A  |   25.08.23    |  von Rogall         |  Generieren der Zufallszahl implementieren          |     10          |
| 6.A  |   25.08.23    |  von Rogall         |  UserInput überprüfen: = / < / > als Zufallszahl / Falsche Eingaben abfangen    |   45            |
| 7.A  |   25.08.23    |  von Rogall         |  Ein- und ausblenden der Form-Elemente (Optionen deaktiviert wenn Spiel gestartet usw.)	|   40            |
| 8.A  |   01.09.23    |  von Rogall         |  Spielernamen implementieren     |     60          |
| 9.A  |   01.09.23    |  von Rogall         |  Ranglistenpunkte implementieren      |   20            |
| 10.A  |   01.09.23    |  von Rogall         |  Spielresultat der Rangliste hinzufügen und diese aktualisieren   |   60            |
| 11.A  |   01.09.23    |  von Rogall         |  "Spiel Beenden"-Funktion hinzufügen     |   5            |
| 12.A  |   01.09.23    |  von Rogall         |  Reset() Funktion implementieren, um das Spiel erneut spielen zu können    |   30            |
| 13.A  |   01.09.23    |  von Rogall         |  Bereits geratene Zahlen werden dem Benutzer in zwei Feldern angezeigt  |     30 |
| 14.A  |   01.09.23    |  von Rogall         |  Der aktuelle Spieler & die gesetzte Zahlenspanne werden auch während dem Spiel angezeigt.   |  20             |
| 15.A  |   08.09.23    |  von Rogall         |  Wurde das Spiel gewonnen, zeigt es den Namen des Spielers der gewonnen hat an, sowie die Anzahl gebrauchter Versuche an. |20|
| 16.A  |   08.09.23    |  von Rogall         |  Projektdokumentation & Portfolioeintrag |225|

Total: 895 min

## 4 Realisieren

| AP-№ | Datum | Zuständig   | geplante Zeit | tatsächliche Zeit |
|------|-------|-------------|---------------|-------------------|
| 1.A   | 18.08.23 | von Rogall  |    200        |   200                |
| 2.A   | 25.08.23 | von Rogall  |    10        |        5           |
| 3.A   | 25.08.23 | von Rogall  |     90       |       90            |
| 4.A   | 25.08.23 | von Rogall  |     30       |       30            |
| 5.A   | 25.08.23 | von Rogall  |     10       |      10             |
| 6.A   | 25.08.23 | von Rogall  |   45         |       45            |
| 7.A   | 25.08.23 | von Rogall  |     40       |       40            |
| 8.A   | 01.09.23 | von Rogall  |   60         |      60             |
| 9.A   | 01.09.23 | von Rogall  |    20        |     20              |
| 10.A  | 01.09.23 | von Rogall  |   60         |     60              |
| 11.A  | 01.09.23 | von Rogall  |    5        |       2            |
| 12.A  | 01.09.23 | von Rogall  |    30        |     30              |
| 13.A  | 01.09.23 | von Rogall  |    30        |      30             |
| 14.A  | 01.09.23 | von Rogall  |   20         |     20              |
| 15.A  | 08.09.23 | von Rogall  |   20         |     20              |
| 16.A  | 08.09.23 | von Rogall  |   225         |     225             |
| 16.B  | 15.09.23 | von Rogall  |   0        |     75             |

Total: 962 min

## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  |    15.09.23  |     Funktioniert     |  von Rogall      |
| 2.1  |    15.09.23  |     Funktioniert     |  von Rogall      |
| 3.1  |    15.09.23  |     Funktioniert     |  von Rogall      |
| 4.1  |    15.09.23  |     Funktioniert     |  von Rogall      |

`Fazit:`

Ich konnte meine gesetzten Ziele erfolgreich umsetzen.
