namespace M000;

public class Fahrzeug
{
	public string Name { get; set; }

	public int MaxV { get; set; }

	public int AktV { get; private set; } = 0;

	public double Preis { get; set; }

	public bool MotorLaeuft { get; private set; } = false;

	public Fahrzeug(string name, int maxV, double preis)
	{
		Name = name;
		MaxV = maxV;
		Preis = preis;
	}

	public string Info()
	{
		string gesamt = $"Das Fahrzeug {Name} kostet {Preis}€ und könnte maximal {MaxV}km/h fahren.";
		if (MotorLaeuft)
			gesamt += $" Es fährt gerade {AktV}/{MaxV}km/h.";
		return gesamt;
	}

	public void StarteMotor()
	{
		if (!MotorLaeuft)
		{
			MotorLaeuft = true;
			Console.WriteLine("Der Motor wurde gestartet.");
		}
		else
			Console.WriteLine("Motor läuft bereits.");
	}

	public void StoppeMotor()
	{
		//Fehler 1
		if (!MotorLaeuft)
		{
			Console.WriteLine("Motor läuft nicht.");
			return; //Funktion abbrechen
		}

		//Fehler 2
		if (AktV > 0)
		{
			Console.WriteLine("Auto fährt noch.");
			return; //Funktion abbrechen
		}

		//Erfolg
		MotorLaeuft = true;
		Console.WriteLine("Motor wurde gestoppt.");
	}

	public void Beschleunige(int a)
	{
		int neueV = AktV + a;
		if (neueV > MaxV)
		{
			Console.WriteLine("Maximale Geschwindigkeit würde überschritten werden!");
			return;
		}

		if (neueV < 0)
		{
			Console.WriteLine("0 würde unterschritten werden!");
			return;
		}

		AktV = neueV;
		Console.WriteLine($"Neue Geschwindigkeit: {AktV}");
	}
}
