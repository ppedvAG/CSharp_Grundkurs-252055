namespace M008;

/// <summary>
/// Vererbung
/// 
/// Definition einer Basisklasse mit beliebig vielen Unterklassen
/// Jede Unterklasse übernimmt alle Member der Basisklasse
/// Jede Unterklasse stellt eine Spezifizierung von der Oberklasse dar
/// 
/// Beispiele:
/// - Pflanzen
/// - Früchte
/// - Lebewesen
/// - ...
/// </summary>
internal class Program // : Object
{
	static void Main(string[] args)
	{
		Mensch m = new Mensch(20, "Max");
		Console.WriteLine(m.Alter); //Vererbt von Lebewesen
		Console.WriteLine(m.Name);
		m.Bewegen(10); //Vererbt von Lebewesen

		Lebewesen l = new Lebewesen(0);
		//l.Name //Kein Zugriff auf Name, da keine Vererbung nach oben
		l.Bewegen(10);
	}
}

public class Lebewesen // : Object
{
	public int Alter { get; set; }

	/// <summary>
	/// virtual
	/// 
	/// Definiert, dass eine Methode überschreibbar ist in den Unterklassen
	/// Wird für verschiedene Verhaltensweisen in mehreren Klassen verwendet
	/// </summary>
	public virtual void Bewegen(int distanz)
	{
		Console.WriteLine($"Das Lebewesen bewegt sich um {distanz}m");
	}

	public Lebewesen(int alter)
	{
		Alter = alter;
	}
}

/// <summary>
/// Mit : [Klasse] kann die Oberklasse definiert werden
/// "Mensch ist ein Lebewesen"
/// </summary>
public sealed class Mensch : Lebewesen
{
	public string Name { get; set; }

	/// <summary>
	/// Strg + .: Konstruktor generieren
	/// 
	/// Bei Vererbung müssen Konstruktoren verkettet werden (mit einer Ebene darüber)
	/// Weitere Parameter können einfach hinzugefügt werden
	/// </summary>
	public Mensch(int alter, string name) : base(alter)
	{
		Name = name;
	}

	/// <summary>
	/// override + Leerzeichen -> Vorschläge für Überschreibungen
	/// 
	/// Wenn in Mensch eine override Methode definiert ist, wird diese Implementation statt Lebewesen verwendet
	/// Override ist optional
	/// </summary>
	public sealed override void Bewegen(int distanz)
	{
		Console.WriteLine($"{Name} bewegt sich um {distanz}m");
	}
}