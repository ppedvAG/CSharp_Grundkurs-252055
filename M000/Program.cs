while (true)
{
	double z1 = 0;
	Console.Write("Gib eine Zahl ein: ");
	z1 = int.Parse(Console.ReadLine());

	double z2 = 0;
	Console.Write("Gib eine weitere Zahl ein: ");
	z2 = int.Parse(Console.ReadLine());

	Console.WriteLine("Wähle eine Rechenart aus: ");
	Rechenart[] rechenarten = Enum.GetValues<Rechenart>();
	foreach (Rechenart art in rechenarten)
	{
		Console.WriteLine($"{(int) art}: {art}");
	}

	Rechenart r = Enum.Parse<Rechenart>(Console.ReadLine());
	switch (r)
	{
		case Rechenart.Addition:
			Console.WriteLine($"Ergebnis: {z1 + z2}");
			break;
		case Rechenart.Subtraktion:
			Console.WriteLine($"Ergebnis: {z1 - z2}");
			break;
		case Rechenart.Multiplikation:
			Console.WriteLine($"Ergebnis: {z1 * z2}");
			break;
		case Rechenart.Division:
			if (z2 != 0)
				Console.WriteLine($"Ergebnis: {z1 / z2}");
			else
				Console.WriteLine("Teilung durch 0 nicht möglich!");
			break;
		default:
			Console.WriteLine("Fehler bei der Rechenart");
			break;
	}

	Console.WriteLine("Enter drücken um zu Wiederholen");
	ConsoleKeyInfo c = Console.ReadKey();
	if (c.Key != ConsoleKey.Enter)
	{
		break;
	}
	Console.Clear();
}