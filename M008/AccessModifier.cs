namespace M008;

internal class AccessModifier
{
	public int Id { get; set; } //Kann von überall angesprochen werden (innerhalb + außerhalb vom Projekt)

	internal string Name { get; set; } //Kann nur innerhalb des Projekts angesprochen werden

	private string Description { get; set; } //Kann nur innerhalb dieser Klasse angesprochen werden

	///////////////////////////////////////////////////////////////////////////////////////////////////////////
	
	protected string Haarfarbe { get; set; } //Kann nur innerhalb dieser Klasse angesprochen werden UND auch in Unterklassen von dieser Klasse

	protected internal int Alter { get; set; } //Kann nur innerhalb des Projekts angesprochen werden UND auch in Unterklassen außerhalb des Projekts

	protected private int Groesse { get; set; } //Kann nur innerhalb dieser Klasse angesprochen werden UND auch in Unterklassen von dieser Klasse ABER nur innerhalb vom Projekt
}
