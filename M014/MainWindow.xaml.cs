using System.Windows;
using System.Windows.Controls;

namespace M014;

public partial class MainWindow : Window
{
	public int Zaehler = 0;

	public MainWindow()
	{
		InitializeComponent();

		Dropdown.ItemsSource = new List<int>() { 1, 2, 3, 4, 5 };
		Wochentage.ItemsSource = Enum.GetValues<DayOfWeek>();
		LB.ItemsSource = new List<int>() { 1, 2, 3, 4, 5 };
	}

	/// <summary>
	/// Eigenschaften -> Oben Rechts -> Blitz
	/// Alle Events
	/// Doppelklick auf das Textfeld -> Methode erzeugen
	/// </summary>
	private void Button_Click(object sender, RoutedEventArgs e)
	{
		MessageBoxResult result = MessageBox.Show("Willst du den Zähler um 1 erhöhen?", "Zähler erhöhen", MessageBoxButton.YesNo, MessageBoxImage.Question);
		if (result == MessageBoxResult.Yes)
		{
			Zaehler++;
			Textfeld.Text = $"Zahl: {Zaehler}";

			//Neues Fenster öffnen
			MainWindow mw = new MainWindow();
			mw.Show();

			//mw.Close();
			this.Close();
		}
	}

	private void Dropdown_SelectionChanged(object sender, SelectionChangedEventArgs e)
	{
		Textfeld.Text = Dropdown.SelectedItem.ToString();
	}

	private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
	{
		//	string alle = "";
		//	foreach (object o in LB.SelectedItems)
		//	{
		//		alle += o.ToString() + ", ";
		//	}
		//	Textfeld.Text = alle.TrimEnd(',', ' ');

		Textfeld.Text = string.Join(", ", LB.SelectedItems.OfType<int>());
	}
}