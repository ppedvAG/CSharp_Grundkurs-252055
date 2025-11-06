namespace M000;

public class Flugzeug : Fahrzeug
{
	public string Treibstoff { get; set; }

	public Flugzeug(string name, int maxV, double preis, string treibstoff) : base(name, maxV, preis)
	{
		Treibstoff = treibstoff;
	}

	public override string Info()
	{
		return base.Info() + $" Es fliegt mit {Treibstoff}.";
	}
}