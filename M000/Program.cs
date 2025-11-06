using M000;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

//Übung 6
//Fahrzeug fzg = new Fahrzeug("VW", 200, 20000);
//fzg.StarteMotor();
//fzg.Beschleunige(50);
//fzg.Beschleunige(500);
//Console.WriteLine(fzg.Info());
//fzg.Beschleunige(-100);
//fzg.StoppeMotor();
//fzg.Beschleunige(-50);
//fzg.StoppeMotor();

//Übung 8
PKW p = new PKW("VW", 250, 20000, 5);
Console.WriteLine(p.Info());

Schiff s = new Schiff("Titanic", 50, 50_000_000, 10_000);
Console.WriteLine(s.Info());

Flugzeug f = new Flugzeug("Airbus A320", 1000, 20_000_000, "Kerosin");
Console.WriteLine(f.Info());

//Übung 9
Fahrzeug[] fzg = new Fahrzeug[10];
for (int i = 0; i < 10; i++)
{
	fzg[i] = Fahrzeug.GeneriereFahrzeug(i.ToString());
	Console.WriteLine(fzg[i].ToString());
}

//foreach (Fahrzeug fahrzeug in fzg)
//	Console.WriteLine(fahrzeug.ToString());

fzg[2].Hupen();

int pkw = 0, schiff = 0, flugzeug = 0;
foreach (Fahrzeug fahrzeug in fzg)
{
	if (fahrzeug is PKW)
		pkw++;
	if (fahrzeug is Schiff)
		schiff++;
	if (fahrzeug is Flugzeug)
		flugzeug++;
}
Console.WriteLine($"Es wurden {pkw} PKWs, {schiff} Schiffe, {flugzeug} Flugzeuge produziert.");

//fzg.GroupBy(e => e.GetType()).ToDictionary(e => e.Key, e => e.Count());
//fzg.CountBy(e => e.GetType()).ToDictionary();

//Übung 10
void TesteBeladung(object o1, object o2)
{
	if (o1 is IBeladbar)
	{
		if (o2 is Fahrzeug)
		{
			IBeladbar b = (IBeladbar) o1;
			Fahrzeug f = (Fahrzeug) o2;
			b.Belade(f);
		}
	}

	if (o1 is Fahrzeug fzg && o2 is IBeladbar bel)
	{
		bel.Belade(fzg);
	}
}

TesteBeladung(fzg[0], fzg[1]);


#region Rechner
//while (true)
//{
//	double z1 = ZahlEingabe("Gib eine Zahl ein: ");
//	double z2 = ZahlEingabe("Gib eine weitere Zahl ein: ");
//	Rechenart r = RechenartEingabe();
//	Berechne(z1, z2, r);

//	Console.WriteLine("Enter drücken um zu Wiederholen");
//	ConsoleKeyInfo c = Console.ReadKey();
//	if (c.Key != ConsoleKey.Enter)
//	{
//		break;
//	}
//	Console.Clear();
//}

//double Berechne(double z1, double z2, Rechenart a)
//{
//	switch (a)
//	{
//		case Rechenart.Addition:
//			Console.WriteLine($"{z1} + {z2} = {z1 + z2}");
//			return z1 + z2;
//		case Rechenart.Subtraktion:
//			Console.WriteLine($"{z1} - {z2} = {z1 - z2}");
//			return z1 - z2;
//		case Rechenart.Multiplikation:
//			Console.WriteLine($"{z1} * {z2} = {z1 * z2}");
//			return z1 * z2;
//		case Rechenart.Division:
//			if (z2 != 0)
//			{
//				Console.WriteLine($"{z1} / {z2} = {z1 / z2}");
//				return z1 / z2;
//			}
//			else
//			{
//				Console.WriteLine("Teilung durch 0 nicht möglich!");
//				return double.NaN;
//			}
//		default:
//			Console.WriteLine("Fehler bei der Rechenart");
//			return double.NaN;
//	}
//}

//double ZahlEingabe(string text)
//{
//	while (true)
//	{
//		double z = 0;
//		Console.Write(text);
//		bool b = double.TryParse(Console.ReadLine(), out z);
//		if (b)
//			return z;
//	}
//}

//Rechenart RechenartEingabe()
//{
//	while (true)
//	{
//		//Console.WriteLine("Wähle eine Rechenart aus: ");
//		//Rechenart[] rechenarten = Enum.GetValues<Rechenart>();
//		//foreach (Rechenart art in rechenarten)
//		//{
//		//	Console.WriteLine($"{(int) art}: {art}");
//		//}

//		string str = "Wähle eine Rechenart aus:\n";
//		Rechenart[] rechenarten = Enum.GetValues<Rechenart>();
//		foreach (Rechenart art in rechenarten)
//		{
//			str += $"{(int) art}: {art}\n";
//		}

//		double zahl = ZahlEingabe(str);
//		Rechenart r = (Rechenart) zahl;
//		if (Enum.IsDefined(r))
//			return r;
//	}
//}
#endregion