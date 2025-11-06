namespace M010;

/// <summary>
/// Interface
/// 
/// Effektiv identisch zur Abstrakten Klasse, aber eine Klasse kann mehrere Interfaces haben (im Gegensatz zu einer Oberklasse)
/// Interfaces werden ausschließlich für Polymorphismus
/// -> Typen gruppieren, welche keinen Bezug zueinander haben
/// Interfaces verwenden, wenn Klassen eine Vererbungshierarchie haben sollen, aber nicht explizit zusammen gehören
/// </summary>
internal class Program
{
	static void Main(string[] args)
	{
		Smartphone s = new Smartphone();
		s.Aufladen(50);
		s.PrintLadezustand();

		Wertkarte w = new Wertkarte();
		w.Aufladen(50);
		w.PrintLadezustand();

		IAufladbar a = s;
		a.PrintLadezustand();
		a = w;
		a.PrintLadezustand();

		IAufladbar[] aufladbar = [s, w];
		foreach (IAufladbar i in aufladbar)
		{
			i.Aufladen(10);
			i.PrintLadezustand();
		}

		if (s is IAufladbar)
		{
			//...
		}
	}

	static void Test(IAufladbar a)
	{

	}
}

//Aufgabe: Smartphone und Wertkarte
//Beide Klassen haben die Eigenschaft, aufladbar zu sein
//Klasse macht hier keinen Sinn, da diese beiden Klassen keinen expliziten Bezug miteinander haben
//Interface macht hier mehr Sinn, da diese beiden Klassen gemeinsam sein sollen
public class Smartphone : IAufladbar
{
	public int Ladezustand { get; set; }

	public int Maximum { get; } = 100;

	public void Aufladen(int x)
	{
		Ladezustand += x;
		if (Ladezustand > Maximum)
			Ladezustand = Maximum;
	}

	public void PrintLadezustand()
	{
		Console.WriteLine($"Das Smartphone ist gerade {Ladezustand}/{Maximum}% geladen.");
	}

	public double ProzentLadung()
	{
		return Ladezustand / Maximum;
	}
}

public class Wertkarte : IAufladbar
{
	public int Ladezustand { get; set; }

	public int Maximum { get; } = 500;

	public void Aufladen(int x)
	{
		Ladezustand += x;
		if (Ladezustand > Maximum)
		{
			Console.WriteLine($"Wertkarte über Maximum geladen ({Maximum})");
			Ladezustand = Maximum;
		}
	}

	public void PrintLadezustand()
	{
		Console.WriteLine($"Die Wertkarte ist mit {Ladezustand}€ geladen.");
	}

	public double ProzentLadung()
	{
		return Ladezustand / Maximum;
	}
}

public interface IAufladbar
{
	int Ladezustand { get; set; }

	int Maximum { get; }

	void Aufladen(int x);

	void PrintLadezustand();

	double ProzentLadung();
}