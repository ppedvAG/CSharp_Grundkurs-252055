#region Schleifen
//While
//Enthält eine Bedingung; führt die Schleife so lange aus, wie die Bedingung zu true ausgewertet wird

int a = 0;
while (a < 10)
{
	Console.WriteLine($"while: {a}");
	a++;
}
//a ist 10

int b = 0;
do
{
	Console.WriteLine($"do-while: {b}");
	b++;
}
while (b < 10);
//b ist 10

//Wenn a und b 20 sind, wird die while-Schleife übersprungen, und die do-while genau einmal ausgeführt

//Endlosschleife
//Schleife, welche für immer läuft
int c = 0;
while (true)
{
	//Generell sollten Endlosschleifen abgebrochen werden können
	//Dafür kann das break Keyword verwendet werden
	//break: Beendet die Schleife
	//break wird generell mit einer if-Bedingung kombiniert
	Console.WriteLine($"while-true: {c}");
	c++;
	if (c >= 10)
		break;
}

//continue: Überspringe den Rest der Schleife und kehre zum Kopf zurück
//Wird vorallem für Fehlerbehandlung bei Daten verwendet
int[] zahlen = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
int z = 20;
while (z < zahlen.Length)
{
	z++;
	if (zahlen[z] % 2 != 0)
	{
		Console.WriteLine($"{zahlen[z]} ist nicht durch 2 teilbar");
		continue; //Überspringe Console.WriteLine von unten
	}

	Console.WriteLine($"Gerade Zahl: {zahlen[z]}");
}

//for-Schleife
//Schleife mit integriertem Zähler
for (int i = 0; i < 10; i++)
{
	Console.WriteLine($"for: {i}");
}

//forr
//Rückwärtsschleife
for (int i = 9; i >= 0; i--)
{
	Console.WriteLine($"forr: {i}");
}

//Liste mit einer Schleife durchgehen
for (int i = 0; i < zahlen.Length; i++)
{
	Console.WriteLine(zahlen[i]);
}

//Alternative: foreach
//Die foreach-Schleife muss immer mit einer Liste arbeiten
foreach (int x in zahlen)
{
	Console.WriteLine(x);
}
#endregion

#region Enums
//Eigener Datentyp
//Fixe Werte
//z.B.: Wochentage, Monate, HttpCodes, ...
//Werden generell in einer eigenen Datei angelegt
//Rechtsklick auf das Projekt -> Hinzufügen -> Klasse
//-> Name des Enums festlegen -> kompletten Inhalt herauslöschen -> Enum definieren
Wochentag wt = Wochentag.Di;

string heute = "Di"; //Problem: Kann Fehler enthalten
if (heute == "Dienstag")
{
	//Fehler
}

if (wt == Wochentag.Di) //Fest kodiert
{
	//keine Fehler
}

//Hinter jedem Enumwert steckt immer eine Zahl
//Der erste Enumwert enthält die Startzahl
//Alle weiteren Werte werden aufsteigend gezählt
wt++;
Console.WriteLine(wt);

int y = 5;
Wochentag tag = (Wochentag) y;
Console.WriteLine(tag);

//Die Enum Klasse
Wochentag parse = Enum.Parse<Wochentag>("1"); //Funktioniert mit Zahlen und Strings
Console.WriteLine(parse);

Wochentag[] tage = Enum.GetValues<Wochentag>(); //Packt alle Werte aus dem Enum aus
foreach (Wochentag t in tage)
	Console.WriteLine(t);

Wochentag m = Wochentag.So;
m++;
Console.WriteLine(m); //Ergebnis: 8 (Tag 8 existiert nicht)
if (Enum.IsDefined(m)) //Prüft, ob der gegebene Wert auch wirklich in den Enum existiert
{
	//...
}
#endregion

#region Switch
//Übersichtlichere if/else if Bäume
if (tag == Wochentag.Mo || tag == Wochentag.Di || tag == Wochentag.Mi || tag == Wochentag.Do || tag == Wochentag.Fr)
{
	Console.WriteLine("Wochentag");
}
else if (tag == Wochentag.Sa || tag == Wochentag.So)
{
	Console.WriteLine("Wochenende");
}
else
{
	Console.WriteLine("Fehler");
}

//automatisch Konvertiert
switch (tag)
{
	case Wochentag.Mo:
	case Wochentag.Di:
	case Wochentag.Mi:
	case Wochentag.Do:
	case Wochentag.Fr:
		Console.WriteLine("Wochentag");
		break;
	case Wochentag.Sa:
	case Wochentag.So:
		Console.WriteLine("Wochenende");
		break;
	default:
		Console.WriteLine("Fehler");
		break;
}

//generiert
//Strg + . -> Beides Hinzufügen
switch (tag)
{
	case Wochentag.Mo:
	case Wochentag.Di:
	case Wochentag.Mi:
	case Wochentag.Do:
	case Wochentag.Fr:
		Console.WriteLine("Wochentag");
		break;
	case Wochentag.Sa:
	case Wochentag.So:
		Console.WriteLine("Wochenende");
		break;
	default:
		Console.WriteLine("Fehler");
		break;
}

//Boolescher Switch
switch (tag)
{
	case >= Wochentag.Mo and <= Wochentag.Fr:
		Console.WriteLine("Wochentag");
		break;
	case Wochentag.Sa or Wochentag.So:
		Console.WriteLine("Wochenende");
		break;
	default:
		Console.WriteLine("Fehler");
		break;
}
#endregion