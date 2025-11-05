#region Arrays
//Array: Variable, welche mehrere Werte halten kann (statt einem Wert)
//Wird definiert mit Typ + []

int[] zahlen = new int[5]; //Array mit Größe erstellen
zahlen[0] = 1; //Schreibe an Position 0 die Zahl 1
zahlen[1] = 2;
zahlen[2] = 3;
zahlen[3] = 4;
zahlen[4] = 5; //Positionen (Indizes) von 0-4

Console.WriteLine(zahlen[2]); //Wert von Stelle 2 entnehmen

//Direkte Initialisierung
int[] zahlenDirekt1 = new[] { 1, 2, 3, 4, 5 };

int[] zahlenDirekt2 = { 1, 2, 3, 4, 5 };

int[] zahlenDirekt3 = [1, 2, 3, 4, 5];

Console.WriteLine(zahlen.Length); //Länge des Arrays (5)

Console.WriteLine(zahlen.Contains(2)); //Prüft, ob ein Element enthalten ist (True)
#endregion

#region Bedingungen
//Vergleichsoperatoren / Booleschen Operatoren
//Werden mit Werten verwendet
//==, !=: gleich, ungleich
//>, <=: größer, kleiner-gleich
//<, >=: kleiner, größer-gleich

//Logische Operatoren
//Werden mit gesamten Bedingungen angewandt
//&&: und
//||: oder
//^: exklusiv-oder
//!: nicht

int a = 5;
int b = 8;

if (a > b) //Wenn die Bedingung true zurückgibt, wird der if-Block ausgeführt
{
	Console.WriteLine("a ist größer als b");
}
else //a <= b //Wenn die Bedingung in der if-Anweisung nicht true zurückgibt
{
	Console.WriteLine("a ist nicht größer als b");
}

if (a == b)
{
	Console.WriteLine("a ist gleich b");
}

//Einzeilige if's/else's können ohne Klammern geschrieben werden
if (a > b)
	Console.WriteLine("a ist größer als b");
else if (a < b)
	Console.WriteLine("a ist kleiner als b");
else //a == b
	Console.WriteLine("a ist gleich b");

if (zahlen.Contains(2))
{
	Console.WriteLine("Zahlen enthält 2");
}

if (zahlen.Average() > 2)
{
	Console.WriteLine("Der Durchschnitt der Zahlen ist größer als 2");
}

//Ternary Operator (?-Operator): Kompakte if's + else's
Console.WriteLine(a > b ? "a ist größer als b" : "a ist kleiner als b");

//a > b ? Console.WriteLine("a ist größer als b") : Console.WriteLine("a ist nicht größer als b"); //Muss immer innerhalb von etwas anderem verwendet werden

string str = a > b ? "a ist größer als b" : "a ist kleiner als b";
Console.WriteLine(str);
#endregion