//Funktionen
//Code wiederverwenden
//-> Code in Funktionen ablegen, und diese Funktionen an mehreren Stellen verwenden

//Aufbau
//Modifier: Liste von Keywords, mit verschiedenen Effekten
//Rückgabewert: Bestimmt das Ergebnis der Funktion. Kann ein beliebiger Datentyp oder void sein
//Name: Der Name
//Parameter: Daten, welche beim Aufruf der Funktion mitgegeben werden können. Werden wie Variablen definiert (Datentyp + Name)
//Body: Code der Funktion

internal class Program
{
	private static void Main(string[] args)
	{
		int summe = Addiere(1, 2); //Wenn eine Funktion einen Rückgabewert hat, sollte dieser in einer Variable gefangen werden

		PrintGleichung(1, 2); //void kann nicht in einer Variable gefangen werden

		KeineParameter();

		//Überladung
		Addiere(1, 2, 3);

		Addiere(2.5, 1);

		//Params
		Addiere(1, 2, 3, 4, 5, 6, 7, 8);
		Addiere(1, 2, 3, 4);
		Addiere(1);
		Addiere(); //Keine Daten auch möglich

		//Optionale Parameter
		Subtrahiere(1, 2); //z = 0
		Subtrahiere(1, 2, 3); //z = 3

		//Nur die Parameter übergeben, welche auch wirklich benötigt werden
		Test(anzahl: 1);
		Test(freq: 10);
		Test(pfad: "...", freq: 5);

		//out
		//int.Parse("x"); //Absturz
		//Alternative: TryParse
		int ergebnis = -1; //x: Ergebnis des Parsens
		bool funktioniert = int.TryParse("x", out ergebnis); //b: Hat das Parsen funktioniert?
		if (funktioniert)
		{
			Console.WriteLine($"Ergebnis: {ergebnis}");
		}
		else
		{
			Console.WriteLine("Parsen gescheitert");
		}
	}

	//Funktion mit Rückgabewert
	static int Addiere(int x, int y)
	{
		return x + y;
	}

	//Funktion ohne Rückgabewert
	static void PrintGleichung(int x, int y)
	{
		Console.WriteLine($"{x} + {y} = {x + y}");
	}

	//Funktion ohne Parameter
	static void KeineParameter() { }

	///////////////////////////////////////////////////////////////////////////////////////

	//Überladung
	//Mehrere Methoden mit dem gleichen Namen definieren
	//Müssen unterschiedliche Parameter haben
	static int Addiere(int x, int y, int z)
	{
		return x + y + z;
	}

	static double Addiere(double x, double y)
	{
		return x + y;
	}

	///////////////////////////////////////////////////////////////////////////////////////

	//params
	//Ein Parameter, welcher beliebig viele Werte akzeptiert
	//Maximal einer pro Methode
	static double Addiere(params double[] x)
	{
		return x.Sum();
	}

	///////////////////////////////////////////////////////////////////////////////////////
	
	//Optionale Parameter
	//Parameter mit einem Standardwert, welcher überschrieben werden kann
	//Wird für konfigurierbare Methoden verwendet
	static int Subtrahiere(int x, int y, int z = 0)
	{
		return x - y - z;
	}

	static void Test(string pfad = "", int anzahl = 0, double freq = 0)
	{
		//...
	}
}