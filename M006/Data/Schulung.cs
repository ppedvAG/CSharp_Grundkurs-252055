namespace M006.Data;

/// <summary>
/// Eigenschaften:
/// - Teilnehmer: Person[]
/// - Trainer: Person
/// - Ort
/// - Dauer
/// - Titel
/// - ...
/// 
/// Methoden:
/// - TeilnehmerHinzufügen
/// - PrintKurs
/// - ...
/// 
/// Konstruktor
/// </summary>
public class Schulung
{
	public string Titel { get; private set; }

	public int Dauer { get; private set; }

	public string Ort { get; private set; }

	public Person Trainer { get; private set; }

	public Person[] Teilnehmer { get; private set; }

	public Schulung(string titel, int dauer, string ort, Person trainer, params Person[] teilnehmer)
	{
		Titel = titel;
		Dauer = dauer;
		Ort = ort;
		Trainer = trainer;
		Teilnehmer = teilnehmer;
	}

	public void TeilnehmerHinzufuegen(Person tn)
	{
		Teilnehmer = Teilnehmer.Append(tn).ToArray();
	}

	public void PrintKurs()
	{
		Console.WriteLine($"Der Kurs {Titel} dauert {Dauer} Tage findet am Ort {Ort} statt und hat folgende Teilnehmer: ");
		Console.WriteLine($"- Trainer: {Trainer.VollerName}");
		foreach (Person p in Teilnehmer)
		{
			Console.WriteLine($"- Teilnehmer: {p.VollerName}"); 
		}
	}
}
