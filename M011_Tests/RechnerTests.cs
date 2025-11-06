using M011;

namespace M011_Tests;

/// <summary>
/// Neues Projekt -> MSTest-Testprojekt -> Alle Einstellung Standard lassen
/// Referenz auf das zu testende Projekt hinzufügen (M011)
/// 
/// Unit Tests sollten regelmäßig ausgeführt werden
/// </summary>
[TestClass]
public sealed class RechnerTests
{
	private Rechner r;

	[TestInitialize]
	public void Startup() => r = new Rechner();

	[TestCleanup]
	public void Cleanup() => r = null;

	[TestMethod]
	public void TestAddiere()
	{
		//AAA
		//Arrange - Act - Assert

		//Arrange
		//Rechner r = new Rechner();

		//Act
		double ergebnis = r.Addiere(2, 3); //Sollte 5 sein

		//Assert
		Assert.AreEqual(5, ergebnis);
	}

	[TestMethod]
	public void TestSubtrahiere()
	{
		//Rechner r = new Rechner();
		double ergebnis = r.Subtrahiere(5, 3);
		Assert.AreEqual(2, ergebnis);
	}
}
