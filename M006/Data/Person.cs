namespace M006.Data;

/// <summary>
/// Klassen und Objekte
/// 
/// Klasse:
/// Klassen sind Baupläne für Objekte
/// Werden verwendet, um komplexe Datentypen darzustellen
/// Innerhalb einer Klasse werden Variablen (oder Properties) und Methoden definiert
/// Alle später aus dieser Klasse erzeugten Objekte haben alle definierten Member (Variablen, Properties und Methoden)
/// 
/// Objekt:
/// Konkrete Instanz von einer Klasse
/// Enthält tatsächliche Daten
/// Aus einer Klasse können beliebig viele Objekte erzeugt werden
/// 
/// Das Datentypen Quiz
/// - int: Ganze Zahl
/// - double: Dezimalzahl
/// - string: Text
/// - bool: Wahr-/Falschwert
/// - Person: ? (komplex)
/// 
/// Eigenschaften:
/// - Größe
/// - Alter
/// - Geschlecht
/// - Vorname
/// - Nachname
/// - ...
/// 
/// Methoden:
/// - Sprechen
/// </summary>
public class Person
{
	#region Variable
	/// <summary>
	/// private: Kann nur innerhalb der Klasse angesprochen werden
	/// </summary>
	private string vorname;

	/// <summary>
	/// Get-Methoden sehen generell immer so aus
	/// Get-Methoden geben nur ihr dahinter liegendes Feld zurück
	/// </summary>
	public string GetVorname()
	{
		return vorname;
	}

	/// <summary>
	/// Nehmen immer den neuen Wert als Parameter und schreiben diesen in das Feld dahinter
	/// Vor dem Schreiben können Sicherheitsprüfungen durchgeführt werden
	/// </summary>
	public void SetVorname(string vorname)
	{
		if (vorname.Length >= 3 && vorname.Length <= 15 && vorname.All(char.IsLetter))
		{
			//this: Greife auf das Feld innerhalb der Klasse zu
			//Wird hier verwendet um vorname oben (Variable) und vorname hier (Parameter) zu unterscheiden
			this.vorname = vorname;
		}
		else
		{
			Console.WriteLine("Vorname muss zw. 3 und 15 Zeichen beinhalten, und darf nur aus Buchstaben bestehen!");
		}
	}
	#endregion

	#region Property
	private string nachname;

	/// <summary>
	/// Property (Eigenschaft)
	/// 
	/// Andere Schreibweise für Get-/Setmethoden
	/// Beim Beschreiben in Program.cs kann das Feld direkt mit = beschrieben werden
	/// </summary>
	public string Nachname
	{
		get
		{
			return nachname;
		}
		set
		{
			//value: Der Name des Parameters
			//In jedem Set-Accessor wird der Parameter als value bezeichnet
			if (value.Length >= 3 && value.Length <= 15 && value.All(char.IsLetter))
			{
				nachname = value;
			}
			else
			{
				Console.WriteLine("Nachname muss zw. 3 und 15 Zeichen beinhalten, und darf nur aus Buchstaben bestehen!");
			}
		}
	}

	//Drei Typen von Properties:
	//- Full Property (siehe oben)
	//- Auto Property
	//- Get-Only Property

	/// <summary>
	/// Auto Property
	/// 
	/// Wird verwendet, um Kompatilität mit anderen Werkzeugen zu ermöglichen
	/// z.B.: Binding in der GUI, Serialisierung mit JSON/XML, ...
	/// Generell sollten Variablen immer mit { get; set; } angelegt werden
	/// </summary>
	public int Alter { get; set; }

	/// <summary>
	/// Get-Only Property
	/// 
	/// Kann nur ausgelesen werden
	/// Hat keinen Set-Accessor
	/// </summary>
	public string VollerName
	{
		get
		{
			return vorname + " " + nachname;
		}
	}

	public string VollerName2
	{
		get => vorname + " " + nachname;
	}

	public string VollerName3 => vorname + " " + nachname;

	public Geschlecht Geschlecht { get; set; }
	#endregion

	#region Konstruktor
	/// <summary>
	/// Konstruktor
	/// 
	/// Startcode von dem Objekt
	/// Wird bei new Person() ausgeführt
	/// Bei diesem Konstruktor müssen zwei Werte übergeben werden
	/// </summary>
	public Person(string vorname, string nachname) : this()
	{
		SetVorname(vorname);
		Nachname = nachname;
	}

	/// <summary>
	/// Leerer Konstruktor (Standardkonstruktor)
	/// Wird bei Erstellung eines anderes Konstruktors überschrieben (gelöscht)
	/// Kann neu erzeugt werden (siehe hier)
	/// </summary>
	public Person()
	{
		Console.WriteLine("Person erzeugt");
	}

	/// <summary>
	/// Konstruktoren verketten
	/// 
	/// Wenn dieser Konstruktor ausgeführt wird, wird auch der obige Konstruktor ausgeführt
	/// Warum Verkettung? Wenn sich ein Konstruktor ändert, wird die Änderung automatisch in den Kettengliedern übernommen
	/// </summary>
	public Person(string vorname, string nachname, int alter) : this(vorname, nachname)
	{
		//SetVorname(vorname);
		//Nachname = nachname;
		Alter = alter;
	}
	#endregion

	#region Methode
	/// <summary>
	/// Methoden in einer Klasse
	/// 
	/// Können nur über Objekte ausgeführt werden
	/// Nein: Person.Sprechen(...)
	/// Ja: p.Sprechen(...)
	/// </summary>
	public void Sprechen(string text)
	{
		Console.WriteLine($"{vorname} {nachname} sagt: {text}");
	}
	#endregion
}