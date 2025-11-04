#region Variablen
//Kommentar

/*
	Mehrzeilige
	Kommentar
*/

//Variable
//Muss immer mit Typ und Name definiert werden
int zahl;
zahl = 5; //Kann auch in der vorherigen Zeile definiert werden
Console.WriteLine(zahl);

//Ganzzahlige Datentypen
//byte, short, int, long
//Wir verwenden immer int

//Texttypen
//string und char
string text = "Hallo Welt"; //Benötigt immer doppelte Hochkomma
char c = 'A'; //Benötigt immer einzelne Hochkomma

//Kommazahlen Typen
//float, double, decimal
//Wir verwenden immer double

//Wahr-/Falschwert
bool b = false;
b = true;
#endregion

#region Strings
string hallo = "Hallo";
string welt = "Welt";
Console.WriteLine(hallo + " " + welt); //cw + Tab

//String Interpolation ($-String): Code in einen String einbinden
string halloWelt = $"{hallo} {welt}";
Console.WriteLine(halloWelt);

//Escape-Sequenzen: Untippbare Zeichen in String einbinden
//z.B.: Zeilenumbruch (\n)
//https://learn.microsoft.com/en-us/cpp/c-language/escape-sequences?view=msvc-170
Console.WriteLine("Hallo \"Welt\"");
Console.WriteLine("Hallo\nWelt");

//Verbatim String (@-String): String, welcher Escape-Sequenzen ignoriert
Console.WriteLine(@"Hallo ""Welt""");
Console.WriteLine("C:\\Program Files\\dotnet\\shared\\Microsoft.NETCore.App\\9.0.10\\System.Console.dll");
Console.WriteLine(@"C:\Program Files\dotnet\shared\Microsoft.NETCore.App\9.0.10\System.Console.dll");
#endregion

#region Eingabe
//string eingabe = Console.ReadLine(); //Wartet auf die Eingabe des Benutzers, mit Enter wird die Eingabe in die Variable geschrieben
//Console.WriteLine($"Du hast {eingabe} eingegeben");

//ConsoleKeyInfo cki = Console.ReadKey(); //Wartet auf eine einzelne Eingabe (ohne Enter)
//Console.WriteLine(cki.Key);
//Console.WriteLine(cki.KeyChar);
#endregion

#region Konvertierung
//Beliebiger Typ zu String
int x = 12;
string str = x.ToString();
Console.WriteLine(str);

//String zu beliebigem Typen
//Wird über die sog. Parse-Funktion gemacht
string s = "123";
int z = int.Parse(s);
//Console.WriteLine(s * 2); //Funktioniert nicht, da s ein string ist (und keine Zahl)
Console.WriteLine(z * 2);

//Typ zu Typ
//Typecast, Cast, Casting
double d = 3.9;
int i = 10;
i += (int) d; //Mit (<Typ>) kann eine Konvertierung erzwungen werden (explizite Konvertierung)
Console.WriteLine(i);

double h = i; //Implizite Konvertierung
h += d;
#endregion

#region Arithmetik
int zahl1 = 5;
int zahl2 = 8;

Console.WriteLine(zahl1 + zahl2); //Addition (zahl1 und zahl2 bleiben unverändert)
zahl1 += zahl2; //Addition (verändert zahl1)

//Modulo: Rest einer Division
Console.WriteLine(12 % 2); //0
Console.WriteLine(14 % 7); //0
Console.WriteLine(32 % 9); //5

Console.WriteLine(zahl1 % 2 == 0); //Ist die Zahl gerade?

zahl1++; //Erhöhe die Zahl um 1 (zahl1 += 1)
zahl1--; //Verringere die Zahl um 1

//Math: Klasse, mit mathematischen Funktionen
Math.Ceiling(3.5); //4
Math.Floor(3.5); //3
Math.Round(3.5); //4
double gerundet = Math.Round(4.5); //4 (.5 Werte werden zur nächsten geraden Zahl gerundet)

//Divisionsprobleme
Console.WriteLine(8 / 5); //1, weil zwei Integer miteinander dividiert werden
Console.WriteLine(8 / 5.0); //Eine der beiden Zahlen muss eine Kommazahl sein
Console.WriteLine(8.0 / 5);
Console.WriteLine(8 / 5f); //Schnelle Konvertierung zu float
Console.WriteLine(zahl1 / (float) zahl2); //Eine der Variablen umbenennen
#endregion