while (true)
{
	double z1 = ZahlEingabe("Gib eine Zahl ein: ");
	double z2 = ZahlEingabe("Gib eine weitere Zahl ein: ");
	Rechenart r = RechenartEingabe();
	Berechne(z1, z2, r);

	Console.WriteLine("Enter drücken um zu Wiederholen");
	ConsoleKeyInfo c = Console.ReadKey();
	if (c.Key != ConsoleKey.Enter)
	{
		break;
	}
	Console.Clear();
}

double Berechne(double z1, double z2, Rechenart a)
{
	switch (a)
	{
		case Rechenart.Addition:
			Console.WriteLine($"{z1} + {z2} = {z1 + z2}");
			return z1 + z2;
		case Rechenart.Subtraktion:
			Console.WriteLine($"{z1} - {z2} = {z1 - z2}");
			return z1 - z2;
		case Rechenart.Multiplikation:
			Console.WriteLine($"{z1} * {z2} = {z1 * z2}");
			return z1 * z2;
		case Rechenart.Division:
			if (z2 != 0)
			{
				Console.WriteLine($"{z1} / {z2} = {z1 / z2}");
				return z1 / z2;
			}
			else
			{
				Console.WriteLine("Teilung durch 0 nicht möglich!");
				return double.NaN;
			}
		default:
			Console.WriteLine("Fehler bei der Rechenart");
			return double.NaN;
	}
}

double ZahlEingabe(string text)
{
	while (true)
	{
		double z = 0;
		Console.Write(text);
		bool b = double.TryParse(Console.ReadLine(), out z);
		if (b)
			return z;
	}
}

Rechenart RechenartEingabe()
{
	while (true)
	{
		//Console.WriteLine("Wähle eine Rechenart aus: ");
		//Rechenart[] rechenarten = Enum.GetValues<Rechenart>();
		//foreach (Rechenart art in rechenarten)
		//{
		//	Console.WriteLine($"{(int) art}: {art}");
		//}

		string str = "Wähle eine Rechenart aus:\n";
		Rechenart[] rechenarten = Enum.GetValues<Rechenart>();
		foreach (Rechenart art in rechenarten)
		{
			str += $"{(int) art}: {art}\n";
		}

		double zahl = ZahlEingabe(str);
		Rechenart r = (Rechenart) zahl;
		if (Enum.IsDefined(r))
			return r;
	}
}