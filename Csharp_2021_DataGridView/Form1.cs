using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_2021_DataGridView
{
	public partial class Form1 : Form
	{
		// Datenquelle anlegen
		BindingSource bindingSource = new BindingSource();
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			// Datenquelle mit DataGridView verbinden
			grdFahrzeuge.DataSource = bindingSource;

			// Datenquelle befüllen
			bindingSource.Add(new Fahrzeug("Polo", "R-AD-123", 10));
			bindingSource.Add(new Fahrzeug("BWM", "N-XY-123", 50));
			bindingSource.Add(new Fahrzeug("Golf", "SAD-AB-456", 30));

			// Datenbindungen einrichten
			// Eigenschaften der Steuerelemente werden an die Datenquelle
			// gebunden => Dadurch werden automatisch die Daten des aktuell
			// ausgewählten Elements angezeigt
			txtBeschreibung.DataBindings.Add(new Binding(
				"Text", bindingSource, "Bezeichnung"));
			txtKennzeichen.DataBindings.Add(new Binding(
				"Text", bindingSource, "Kennzeichen"));
			txtGeschwindigkeit.DataBindings.Add(new Binding(
				"Text", bindingSource, "Geschwindigkeit"));
		}

		private void ValidateOnEnter(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				e.SuppressKeyPress = true;
				Validate();
			}
		}

		private void btnFahrzeugAusgeben_Click(object sender, EventArgs e)
		{
			// Auf aktuell ausgewähltes Element der Datenquelle zugreifen
			// bindingSource.Current liefert aktuell ausgewähltes Element
			// als "object" zurück
			// => mit "as Fahrzeug" kann es in den Datentyp "Fahrzeug" 
			// umgewandelt werden (englisch: Cast)
			var ausgewähltesFahrzeug = bindingSource.Current as Fahrzeug;

			Console.WriteLine("Ausgewähltes Fahrzeug: " + 
				ausgewähltesFahrzeug.Bezeichnung + " - " +
				ausgewähltesFahrzeug.Kennzeichen + " - " + 
				ausgewähltesFahrzeug.Geschwindigkeit);
		}

		private void btnBeschleunigen_Click(object sender, EventArgs e)
		{
			try
			{
				// Eingabe aus TextBox in Zahl umwandeln
				if (!int.TryParse(txtBeschleunigen.Text, out int wert))
					throw new ArgumentException("Bitte eine Zahl eingeben!");

				// Auf aktuell ausgewähltes Objekt zugreifen &
				// in Fahrzeug casten
				var ausgewähltesFahrzeug = bindingSource.Current as Fahrzeug;

				// Ausgewähltes Fahrzeug beschleunigen
				ausgewähltesFahrzeug.Beschleunigen(wert);

				// Update der Datenquelle durchführen
				bindingSource.ResetBindings(true);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void hinzufügenToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}
	}
}
