namespace M000;

internal class Container : IBeladbar
{
	public Fahrzeug GeladenesFahrzeug { get; set; }

	public void Belade(Fahrzeug fzg)
	{
		if (GeladenesFahrzeug == null)
		{
			GeladenesFahrzeug = fzg;
			Console.WriteLine($"{fzg.Name} wurde geladen");
		}
		else
		{
			Console.WriteLine($"Laderaum ist bereits beladen mit {GeladenesFahrzeug.Name}");
		}
	}

	public Fahrzeug Entlade()
	{
		if (GeladenesFahrzeug == null)
		{
			Console.WriteLine("Kein Fahrzeug geladen");
			return null;
		}

		Fahrzeug zwischenspeicher = GeladenesFahrzeug;
		GeladenesFahrzeug = null;
		return zwischenspeicher;
	}
}
