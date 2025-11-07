using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace M015;

internal class Program
{
	static void Main(string[] args)
	{
		//Path, File, Directory
		string folderPath = "Test";

		string filePath = Path.Combine(folderPath, "Test.txt"); //Relativer Pfad: Geht von der Executable selbst aus (C:\Users\lk3\source\repos\CSharp_Grundkurs_2025_11_04\M015\bin\Debug\net9.0\M015.exe)

		//Pfade alleine haben keinen Effekt (nur Strings)

		//Ordner erstellen
		if (!Directory.Exists(folderPath))
			Directory.CreateDirectory(folderPath);

		//File erstellen
		StreamWriter sw = new StreamWriter(filePath); //Öffnet einen Stream zu der Datei (zum Schreiben bereit)
		sw.WriteLine("Hallo"); //Jeder Stream schreibt seinen Inhalt nur in einen Buffer
		sw.WriteLine("Welt"); //Dieser Buffer muss im Anschluss in das File geschrieben werden
		sw.WriteLine("!");
		sw.Flush(); //Buffer entleeren und in die Datei schreiben
		sw.Close(); //Gibt alle verwendeten Ressourcen wieder frei (Garbage Collection per Hand)

		StreamReader sr = new StreamReader(filePath);
		//Gesamtes File lesen
		sr.ReadToEnd();

		//Gesamtes File Zeile für Zeile lesen
		//Flexibler, u.a. Parallelisierung und Teile von Datei lesen
		List<string> lines = [];
		while (!sr.EndOfStream)
			lines.Add(sr.ReadLine());
		sr.Close();

		//Using-Block
		//Schließt den Stream am Ende des Blocks automatisch (Dispose())
		//Wird ermöglicht durch das IDisposable Interface
		using (StreamWriter sw2 = new StreamWriter(filePath))
		{
			sw2.WriteLine("Hallo");
			sw2.WriteLine("Welt");
			sw2.WriteLine("!");
		} //Dispose() wird automatisch gemacht (diese macht auch Flush())

		//Using-Statement
		//Wird am Ende der Methode geschlossen
		using StreamWriter sw3 = new StreamWriter(filePath);	
		sw3.WriteLine("Hallo");
		sw3.WriteLine("Welt");
		sw3.WriteLine("!");
		sw3.Close(); //Für Json, Xml

		//NuGet-Pakete
		//Externe Pakete in das Projekt hinzufügen, um extra Funktionalitäten, die nicht in .NET standardmäßig implementiert sind, hinzuzufügen
		//Beispiel:
		//- Datenbanken (MSSQL, MySQL, Oracle DB, Postgres, ...)
		//- Logging (Serilog)
		//- Testing (Moq)

		//Newtonsoft.Json
		//Externen Json Paket (seit 2012)
		List<Fahrzeug> fahrzeuge = new List<Fahrzeug>
		{
			new Fahrzeug(251, FahrzeugMarke.BMW),
			new Fahrzeug(274, FahrzeugMarke.BMW),
			new Fahrzeug(146, FahrzeugMarke.BMW),
			new Fahrzeug(208, FahrzeugMarke.Audi),
			new Fahrzeug(189, FahrzeugMarke.Audi),
			new Fahrzeug(133, FahrzeugMarke.VW),
			new Fahrzeug(253, FahrzeugMarke.VW),
			new Fahrzeug(304, FahrzeugMarke.BMW),
			new Fahrzeug(151, FahrzeugMarke.VW),
			new Fahrzeug(250, FahrzeugMarke.VW),
			new Fahrzeug(217, FahrzeugMarke.Audi),
			new Fahrzeug(125, FahrzeugMarke.Audi)
		};

		//File.WriteAllText(filePath, JsonConvert.SerializeObject(fahrzeuge));

		//string readJson = File.ReadAllText(filePath);
		//Fahrzeug[] readFzg = JsonConvert.DeserializeObject<Fahrzeug[]>(readJson);

		//System.Text.Json
		//Internes Json Paket (seit .NET Core 3.0, 2016)
		File.WriteAllText(filePath, JsonSerializer.Serialize(fahrzeuge));

		string readJson = File.ReadAllText(filePath);
		Fahrzeug[] readFzg = JsonSerializer.Deserialize<Fahrzeug[]>(readJson);

		//XML
		XmlSerializer xml = new XmlSerializer(fahrzeuge.GetType());
		using (StreamWriter sw4 = new StreamWriter(filePath))
		{
			xml.Serialize(sw4, fahrzeuge);
		}

		using (StreamReader sr2 = new StreamReader(filePath))
		{
			List<Fahrzeug> read = (List<Fahrzeug>) xml.Deserialize(sr2);
		}
	}
}

[DebuggerDisplay("Marke: {Marke}, MaxV: {MaxV}")]
public class Fahrzeug
{
	public int MaxV { get; set; }

	public FahrzeugMarke Marke { get; set; }

	public Fahrzeug(int MaxV, FahrzeugMarke Marke)
	{
		this.MaxV = MaxV;
		this.Marke = Marke;
	}

	public Fahrzeug()
	{
		
	}
}

public enum FahrzeugMarke
{
	Audi, BMW, VW
}