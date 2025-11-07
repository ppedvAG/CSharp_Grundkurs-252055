namespace M012;

internal class Program
{
	static void Main(string[] args)
	{
		//Generisches Typargument ("Generic")
		//In den spitzen Klammern den gewünschten Typen angeben
		//Innerhalb der Klasse wird der Parameter als T definiert
		//Bei der Erstellung der Liste wird dann jedes T in der Klasse durch den gegebenen Typen ausgetauscht
		List<int> zahlen = new List<int>(); //"Liste von int"
		zahlen.Add(1);
		zahlen.Add(2);
		zahlen.Add(3);

		List<string> texte = new List<string>(); //"Liste von String"
		texte.Add("Hallo");
		texte.Add("Welt");

		//Liste mit Schleife iterieren
		foreach (int i in zahlen)
		{
			Console.WriteLine(i);
		}

		//Index wie bei Array
		Console.WriteLine(zahlen[0]);

		zahlen.Remove(2); //Zahl in der Mitte löschen, Elemente werden aufgeschoben
		zahlen.Add(10); //Zahl hinzufügen, wird am Ende hinzugefügt

		///////////////////////////////////////////////////////////////////
		
		//Dictionary
		//Liste von Key-Value Pairs
		//Liste, bei der jedes Element eine Bezeichnung hat
		Dictionary<string, int> einwohnerzahlen = new Dictionary<string, int>();
		einwohnerzahlen.Add("Wien", 2_000_000);
		einwohnerzahlen.Add("Berlin", 3_650_000);
		einwohnerzahlen.Add("Paris", 2_160_000);
		//einwohnerzahlen.Add("Paris", 2_160_000); //Schlüssel dürfen nicht mehrmals existieren

		foreach (var kv in einwohnerzahlen) //var: Typ wird vom Compiler automatisch ergänzt
		{
			Console.WriteLine($"Die Stadt {kv.Key} hat {kv.Value} Einwohner.");
		}

		if (einwohnerzahlen.ContainsKey("Paris")) //Wenn der Schlüssel nicht existiert, Absturz
			Console.WriteLine(einwohnerzahlen["Paris"]); //2_160_000
	}
}
