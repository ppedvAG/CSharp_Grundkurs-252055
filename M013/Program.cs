using System.Diagnostics;

namespace M013;

internal class Program
{
	static void Main(string[] args)
	{
		#region Einfaches Linq
		var x = Enumerable.Range(0, 1_000_000_000); //Nur eine Anleitung zur Erstellung von den Daten

		//List<int> zahlen = x.ToList(); //Mit einer Iterierung wird die Anleitung ausgeführt, und Daten werden erzeugt

		////////////////////////////
		
		List<int> zahlen = Enumerable.Range(1, 20).ToList();

		Console.WriteLine(zahlen.Sum()); //Alle Linq Methoden sind Erweiterungsmethoden (Würfel + Pfeil)
		Console.WriteLine(zahlen.Average());
		Console.WriteLine(zahlen.Min());
		Console.WriteLine(zahlen.Max());

		Console.WriteLine(zahlen.First()); //Geben das erste/letzte Element zurück
		Console.WriteLine(zahlen.Last()); //Wenn keine Elemente in der Liste enthalten sind, Absturz

		Console.WriteLine(zahlen.FirstOrDefault()); //Geben das erste/letzte Element zurück
		Console.WriteLine(zahlen.LastOrDefault()); //Wenn keine Elemente in der Liste enthalten sind, default(int): 0

		//Console.WriteLine(zahlen.First(e => e % 50 == 0)); //Absturz
		Console.WriteLine(zahlen.FirstOrDefault(e => e % 50 == 0)); //0
		#endregion

		#region Linq mit Objekten
		List<Fahrzeug> fahrzeuge = new List<Fahrzeug>
		{
			new Fahrzeug(251, FahrzeugMarke.BMW),
			new Fahrzeug(274, FahrzeugMarke.BMW),
			new Fahrzeug(146, FahrzeugMarke.BMW),
			new Fahrzeug(208, FahrzeugMarke.Audi),
			new Fahrzeug(189, FahrzeugMarke.Audi),
			new Fahrzeug(133, FahrzeugMarke.VW),
			new Fahrzeug(253, FahrzeugMarke.VW),
			new Fahrzeug(304, FahrzeugMarke.BMW),
			new Fahrzeug(151, FahrzeugMarke.VW),
			new Fahrzeug(250, FahrzeugMarke.VW),
			new Fahrzeug(217, FahrzeugMarke.Audi),
			new Fahrzeug(125, FahrzeugMarke.Audi)
		};

		//Alle VWs finden
		fahrzeuge.Where(e => e.Marke == FahrzeugMarke.VW); //Linq-Funktionen fangen immer mit e => an

		//Alle Fahrzeuge finden, welche mind. 250km/h fahren können
		fahrzeuge.Where(e => e.MaxV >= 250);

		//Alle VWs finden, welche mind. 250km/h fahren können
		fahrzeuge.Where(e => e.MaxV >= 250 && e.Marke == FahrzeugMarke.VW);
		fahrzeuge.Where(e => e.MaxV >= 250).Where(e => e.Marke == FahrzeugMarke.VW);

		//Nach Marke sortieren
		fahrzeuge.OrderBy(e => e.Marke); //Bedingung benötigt keine Operatoren (==, !=, <, >, ...)

		//Nach Marke und Geschwindigkeit sortieren
		fahrzeuge.OrderBy(e => e.Marke).ThenBy(e => e.MaxV);
		fahrzeuge.OrderByDescending(e => e.Marke).ThenByDescending(e => e.MaxV);

		//Fahren alle Fahrzeuge mind. 250km/h?
		if (fahrzeuge.All(e => e.MaxV >= 250))
		{
			//...
		}

		//Fährt mind. ein Fahrzeug mind. 250km/h?
		if (fahrzeuge.Any(e => e.MaxV >= 250))
		{
			//...
		}

		fahrzeuge.Any(); //Prüft, ob die Liste Elemente hat

		//Wieviele VWs haben wir?
		fahrzeuge.Count(e => e.Marke == FahrzeugMarke.VW); //4
		fahrzeuge.Where(e => e.Marke == FahrzeugMarke.VW).Count();

		//Was ist das langsamste Fahrzeug?
		fahrzeuge.MinBy(e => e.MaxV); //Fahrzeug
		fahrzeuge.Min(e => e.MaxV); //int

		//Was ist die Durchschnittsgeschwindigkeit aller Fahrzeuge?
		fahrzeuge.Average(e => e.MaxV); //208.41666666666666

		//Was ist die Durchschnittsgeschwindigkeit aller BMWs?
		fahrzeuge.Where(e => e.Marke == FahrzeugMarke.BMW).Average(e => e.MaxV); //243.75

		//Skip, Take
		fahrzeuge.Skip(5);
		fahrzeuge.Take(3);
		fahrzeuge.Skip(3).Take(3); //[3]-[5]

		//Was sind die 3 schnellsten Fahrzeuge?
		fahrzeuge
			.OrderByDescending(e => e.MaxV)
			.Take(3);

		//Select
		//Transformation einer Liste
		//-> Wandelt die Liste in eine andere Form um

		//1. Fall (80%): Einzelnes Feld aus der Liste entnehmen
		fahrzeuge.Select(e => e.Marke); //Nur die Marken
		fahrzeuge.Select(e => e.MaxV); //Nur die Geschwindigkeiten

		//Welche Marken gibt es?
		fahrzeuge
			.Select(e => e.Marke)
			.Distinct()
			.Order();

		//Was ist die Durchschnittsgeschwindigkeit?
		fahrzeuge.Select(e => e.MaxV).Average(); //fahrzeuge.Average(e => e.MaxV);

		//Was sind die Geschwindigkeiten aller BMWs?
		fahrzeuge.Where(e => e.Marke == FahrzeugMarke.BMW).Select(e => e.MaxV);

		//2. Fall (20%): Transformation

		//Liste von 0 bis 10 mit 0.1 Schritten
		Enumerable.Range(0, 101).Select(e => e / 10.0);

		//Liste von 0 bis 99 mit doubles
		Enumerable.Range(0, 100).Select(e => (double) e);

		string[] str = ["1", "2", "3"];
		str.Select(e => int.Parse(e));

		List<int> z = [];
		foreach (string s in str)
			z.Add(int.Parse(s));
		#endregion

		#region Erweiterungsmethoden
		//Erweiterungsmethoden
		//Methoden, welche an beliebige Typen angehängt werden können
		int y = 134589;
		Console.WriteLine(y.Quersumme());
		Console.WriteLine(124875.Quersumme());

		fahrzeuge.Shuffle(); //Eigene Linq-Methode
		#endregion
	}
}

[DebuggerDisplay("Marke: {Marke}, MaxV: {MaxV}")]
public class Fahrzeug
{
	public int MaxV;

	public FahrzeugMarke Marke;

	public Fahrzeug(int v, FahrzeugMarke fm)
	{
		MaxV = v;
		Marke = fm;
	}
}

public enum FahrzeugMarke
{
	Audi, BMW, VW
}

public static class ExtensionMethods
{
	public static int Quersumme(this int x) //mit dem this Parameter, kann der Typ angegeben werden, auf welchen sich die Methode bezieht
	{
		//int summe = 0;
		//string zahlAlsString = x.ToString();
		//for (int i = 0; i < zahlAlsString.Length; i++)
		//{
		//	summe += (int) char.GetNumericValue(zahlAlsString[i]);
		//}
		//return summe;

		//1247 -> "1247" -> foreach -> '1' => 1
		return (int) x.ToString().Sum(e => char.GetNumericValue(e));
	}

	public static IEnumerable<T> Shuffle<T>(this IEnumerable<T> source)
	{
		return source.OrderBy(e => Random.Shared.Next());
	}
}