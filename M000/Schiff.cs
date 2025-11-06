namespace M000;

public class Schiff : Fahrzeug
{
	public int Laderaum { get; set; }

	public Schiff(string name, int maxV, double preis, int laderaum) : base(name, maxV, preis)
	{
		Laderaum = laderaum;
	}

	public override string Info()
	{
		return base.Info() + $" Es hat {Laderaum}m³ Platz.";
	}
}