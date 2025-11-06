namespace M009;

internal class Program
{
	/// <summary>
	/// Polymorphismus
	/// 
	/// -> Typkompatibilität
	/// Welche Typen sind mit welchen anderen Typen kompatibel?
	/// Welche Objekte können auf welche Variablen zugewiesen werden?
	/// </summary>
	static void Main(string[] args)
	{
		//Linke Seite: Variablentyp; bestimmt, welche Objekte hereinpassen
		//Rechte Seite: Laufzeittyp; bestimmt den Typen des Objektes selbst
		
		//Lebewesen ist kompatibel mit Mensch, Hund und Lebewesen selbst
		//Lebewesen l = new Lebewesen();
		Lebewesen m = new Mensch();
		Lebewesen h = new Hund();

		//object
		//object ist mit allem kompatibel, da es die Oberklasse von allen Typen in C# ist
		object o = new Mensch();
		o = new Hund();
		o = 123;
		o = true;
		o = new object();
		o = "Hallo Welt";

		//Polymorphismus gilt überall
		//Variablen, Parametern, Rückgabewerten, ...
		Test(123);
		Test("Hallo");
		//Test(new Lebewesen());

		////////////////////////////////////////////////////////////////////////

		//Typen
		//Jedes Objekt hat einen Typen
		//Dieser hängt mit der Klasse/dem Struct dahinter zusammen

		//Zwei Möglichkeiten um einen Type zu bekommen:
		//- GetType(): über ein Objekt/Variable
		//- typeof(...): über einen Klassennamen
		Type mt = m.GetType(); //Lebewesen
		Type t = typeof(Lebewesen); //Lebewesen
		
		//Typvergleiche
		//Feststellen, was in einer Variable wirklich enthalten ist

		//Genauer Typvergleich
		//Ist der Typ in dem Objekt genau der gesuchte Typ?
		if (m.GetType() == typeof(Lebewesen))
		{
			//false
		}

		if (m.GetType() == typeof(Mensch))
		{
			//true
		}

		if (m.GetType() == typeof(object))
		{
			//false
		}

		//Vererbungshierarchietypvergleich
		//Prüft auch Oberklassen
		if (m is Lebewesen)
		{
			//true
		}

		if (m is Mensch)
		{
			//true
		}

		if (m is object)
		{
			//immer true
		}
	}

	public static object Test(object o)
	{
		//...

		return 123;
		return "Hallo";
		//return new Lebewesen();
	}
}

/// <summary>
/// abstract
/// 
/// Klasse, welche nur eine Struktur vorgibt und generell keinen Code enthält
/// Definiert abstrakte Methoden und Properties
/// Wird ausschließlich für Vererbung verwendet
/// </summary>
public abstract class Lebewesen
{
	/// <summary>
	/// Alle Unterklassen müssen eine konkrete Implementation für diese definierten Methoden/Properties anlegen
	/// </summary>
	public abstract void Sprechen();
}

public class Mensch : Lebewesen
{
	public override void Sprechen()
	{
		Console.WriteLine("Hallo");
	}
}

public class Hund : Lebewesen
{
	public override void Sprechen()
	{
		Console.WriteLine("Wuff");
	}
}