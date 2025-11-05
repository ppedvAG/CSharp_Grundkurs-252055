using M006.Data;

namespace M006;

internal class Program
{
	/// <summary>
	/// Dokumentationskommentar
	/// 
	/// Wird verwendet, um Member (Methoden, Klassen, Funktionen, Variablen, ...) zu dokumentieren
	/// </summary>
	/// <param name="args">Die Programmargumente</param>
	static void Main(string[] args)
	{
		Person p = new Person(); //Erstellung von einem Objekt
		p.SetVorname("Max"); //Beschreibung von vorname über SetVorname (Methode)
		p.Nachname = "Mustermann"; //Beschreibung von nachname über Nachname (Property)
		p.Alter = 33;
		p.Geschlecht = Geschlecht.M;

		Console.WriteLine(p.VollerName);

		Person p2 = new Person("Udo", "Mustermann");
		//p2.SetVorname("Max"); //Kann jetzt weggelassen werden
		//p2.Nachname = "Mustermann"; //Kann jetzt weggelassen werden
		p2.Alter = 50;

		Person p3 = new Person("Tim", "Mustermann", 25);

		p.Sprechen("Hallo");
		p2.Sprechen("Welt");
		p3.Sprechen("!");

		///////////////////////////////////////////////////////////////////////////////////////

		//Namespace
		//Organisationseinheit um Klassen/Structs/Enums/... zu gruppieren
		//Beispiele:
		//- System.IO: Dateien
		//- System.Net: Netzwerk
		//- System.Collections: Verschiedene Listentypen
		//- System.Windows: GUI
		//Namespace anlegen: namespace <Name>;
		//Namespace verwenden: using <Name>;

		///////////////////////////////////////////////////////////////////////////////////////

		//Assozation von Objekten
		//Objekte in andere Objekte verschachteln
		//Objekte werden aus Objekten aufgebaut, diese werden wieder aus Objekten aufgebaut, ...
		Schulung s = new Schulung("C# Grundkurs", 4, "Virtuell", p, p2, p3);
		s.PrintKurs();
	}
}