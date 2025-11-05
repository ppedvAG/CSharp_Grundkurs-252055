namespace M007;

internal class Program
{
	static void Main(string[] args)
	{
		//var x = Enumerable.Range(0, 1_000_000_000).ToList(); //1Mrd. Integer = 4GB Arbeitsspeicher
		//Am Ende des Programms, werden diese Integer aus dem Arbeitsspeicher gelöscht

		////////////////////////////////////////////

		//Static
		//"Global"
		//Wird über den Klassennamen angesprochen
		//Hängt nicht mit Objekten zusammen
		Book b1 = new Book();
		Book b2 = new Book();
		Book b3 = new Book();
		Book.Number++;

		////////////////////////////////////////////

		//class und struct

		//class
		//Referenztyp
		//Wenn ein Objekt eines Referenztypens zugewiesen (Variable) wird, wird eine Referenz erstellt
		//Wenn zwei Objekte von Referenztypen verglichen werden, werden die Speicheradressen verglichen
		Book book1 = new Book();
		Book book2 = book1; //book2 hat eine Referenz auf das Objekt unter book1
		book1.Id = 10; //Id wird bei beiden Variablen auf 10 gesetzt, weil unter beiden Variablen dasselbe Objekt liegt

		Console.WriteLine(book1.GetHashCode());
		Console.WriteLine(book2.GetHashCode());
		Console.WriteLine(book1 == book2);
		Console.WriteLine(book1.GetHashCode() == book2.GetHashCode());

		//struct
		//Wertetyp
		//Wenn ein Objekt eines Wertetypens zugewiesen (Variable) wird, wird eine Kopie erstellt
		//Wenn zwei Objekte von Wertetypen verglichen werden, werden die Inhalte verglichen
		int z1 = 5;
		int z2 = z1;
		z1 = 10;

		//book1 wird verändert, z1 wird nicht verändert
		Test(book1);
		Test(z1);

		//ref
		//Reference
		//Kann bei einem Typen verwendet werden, um diesen referenzierbar zu machen
		int x = 5;
		ref int y = ref x;
		y = 10;

		Test2(ref z1);

		////////////////////////////////////////////

		//Null
		//Wert, wenn eine Variable leer ist
		Book b4 = null;
		if (b4 == null) //Null Prüfung
		{
			//...
		}

		//Typen, welche nicht null sein können:
		//- int
		//- float
		//- bool
		//- char
		//- Rechenart
		//- ...

		//Klassen können null sein, struct können nicht null sein
		//int k = null; //nicht erlaubt
		int? n = null; //Mit ? am Ende des Typens, kann jeder Typ nullable sein
	}

	static void Test(Book b) => b.Id = 50;

	static void Test(int x) => x = 50;

	static void Test2(ref int x) => x = 50;
}

public class Book
{
	public int Id { get; set; }

	public string Name { get; set; }

	public string Title { get; set; }

	public string Description { get; set; }

	public string Author { get; set; }

	public static int Number { get; set; }
}