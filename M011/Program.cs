namespace M011;

/// <summary>
/// Debugging
/// 
/// Breakpoints setzen, Programm bleibt in der Zeile stehen
/// Debug -> Fenster -> Lokal
/// 
/// Step Over, Step Into, Step Out
/// Generell: Step Over benutzen
/// </summary>
internal class Program
{
	static void Main(string[] args)
	{
		//try: Code, welcher Abstürzen könnte
		try
		{
			//Code markieren -> Rechtsklick -> Ausschnitt -> Umschließen mit -> try(f)
			int x = int.Parse(Console.ReadLine()); //Wenn keine Zahl eingegeben wird, gibt es hier einen Absturz
		}
		//catch: Codeblock, welcher bei einem Absturz, statt dem Absturz, ausgeführt wird
		catch (FormatException e)
		{
			Console.WriteLine("Der eingegebene Text ist keine Zahl");
		}
		catch (OverflowException e)
		{
			Console.WriteLine("Die eingegebene Zahl ist zu klein/groß");
		}
		catch //Alle anderen Exceptions
		{
			Console.WriteLine("Anderer Fehler");
			throw; //Verursacht einen Absturz
		}
		finally //Wird immer ausgeführt
		{
			Console.WriteLine("Parsen beendet"); //Auch bei throw; wird diese Anweisung ausgeführt
		}

		//throw: Verursacht eine Exception
		throw new InvalidOperationException("Hallo");

		//Warum das Programm abstürzen lassen?
		//Wenn es ein Szenario gibt, bei dem ein Wert fehlt, wollen wir nicht für die Fehlerbehandlung verantwortlich sein,
		// weil der User selbst entscheiden soll, wie die Fehlerbehandlung stattfinden soll
		//Innerhalb unseres Codes verwenden wir throw
		//Der User kann dann try-catch benutzen, um den Fehler zu verhindern
		//Vorteil: Der User kann im catch-Block den Fehler selbst an einer beliebigen Stelle anzeigen
		//z.B.: Konsole, Log, GUI, Webseite, Datenbank, Handybenachrichtigung, ...
	}
}
