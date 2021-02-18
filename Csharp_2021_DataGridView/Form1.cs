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

		// Liste anlegen, in der alle Objekte gespeichert werden
		List<Fahrzeug> meineFahrzeugListe = new List<Fahrzeug>();
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			// Objekte der Liste hinzufügen
			meineFahrzeugListe.Add(new Fahrzeug("Polo", "R-AD-123", 10));
			meineFahrzeugListe.Add(new Fahrzeug("BMW", "N-XY-123", 50));
			meineFahrzeugListe.Add(new Fahrzeug("Golf", "SAD-AB-456", 30));

			// Liste an bindingSource übergeben
			bindingSource.DataSource = meineFahrzeugListe;

			// Datenquelle mit DataGridView verbinden
			grdFahrzeuge.DataSource = bindingSource;

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
			// Objekt für das neue Formular erzeugen
			var frmNeuesFahrzeug = new FormNeuesFahrzeug();

			// Form anzeigen
			frmNeuesFahrzeug.ShowDialog();

			// Rückgabe des Formulars auswerten:
			// Bei "OK" => soll der Datenquelle das neue Fahrzeug hinzugefügt werden
			if (frmNeuesFahrzeug.DialogResult == DialogResult.OK)
				bindingSource.Add(frmNeuesFahrzeug.NeuesFahrzeug);
		}

		private void löschenToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// Aktuell ausgewähltes Element aus der Datenquelle löschen
			bindingSource.RemoveCurrent();
		}

		private void btnFilterKennzeichen_Click(object sender, EventArgs e)
		{
			// grdFahrzeuge.DataSource  : Eigenschaft Datenquelle des DataGridView
			// bindingSource						: Datenquelle
			// .List										: Ruft alle Elemente der Datenquelle als Liste ab
			// .OfType<Fahrzeug>()			:	interpretiert die Elemente der Datenquelle als Typ "Fahrzeug"
			// .Where										:	Einschränkung
			//		f											:	steht für ein Element der Liste
			//		=>										:	Lambda-Ausdruck
			//		f.Kennzeichen....			:	prüft, ob für dieses Element die Eigenschaft "Kennzeichen"
			//														den in der txtFilterKennzeichen eingegebenen Text enthält
			// .ToList()								:	Alle Elemente, für die die oben eingegebene Einschränkung gilt
			//													  der Liste hinzufügen
			bindingSource.DataSource =
				meineFahrzeugListe
				.Where(f => f.Kennzeichen.Contains(txtFilterKennzeichen.Text))
				.ToList();
		}

		private void btnFilterBezeichnung_Click(object sender, EventArgs e)
		{
			bindingSource.DataSource =
				meineFahrzeugListe
				.Where(f => f.Bezeichnung.Contains(txtFilterBezeichnung.Text))
				.ToList();
		}

		private void btnAlleAnzeigen_Click(object sender, EventArgs e)
		{
			// Im DataGridView werden alle Elemente der Datenquelle angezeigt
			bindingSource.DataSource = meineFahrzeugListe;
		}

		private void btnAufsteigendNachGeschwindigkeit_Click(object sender, EventArgs e)
		{
			bindingSource.DataSource =
				meineFahrzeugListe
				.OrderBy(f => f.Geschwindigkeit)
				.ToList();
		}

		private void btnAbsteigendNachBezeichnung_Click(object sender, EventArgs e)
		{
			bindingSource.DataSource =
				meineFahrzeugListe
				.OrderByDescending(f => f.Bezeichnung)
				.ToList();
		}
	}
}
